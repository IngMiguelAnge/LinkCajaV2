using LinkCajaV2.Data;
using LinkCajaV2.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinkCajaV2.Catalogs
{
    public partial class RetirementConcept : Form
    {
        public int IdCashfund { get; set; }
        public decimal TotalMax { get; set; }
        public decimal TotalGeneral { get; set; }
        private int Id { get; set; }
        public DateTime FechaMinima { get; set; }
        public bool sicambio { get; set; } = false;
        public bool Closse { get; set; } = false;
        public bool Retire { get; set; } = false;
        public bool loaded { get; set; } = false;
        public decimal Inicio { get; set; } = 0;
        public RetirementConcept()
        {
            InitializeComponent();
        }

        private void NudRetiro_KeyUp(object sender, KeyEventArgs e)
        {
            DomainUpDown dud = sender as DomainUpDown;
            if (dud == null) return;

            // Buscamos el TextBox interno de forma segura
            TextBox tb = null;
            foreach (Control c in dud.Controls)
            {
                if (c is TextBox)
                {
                    tb = (TextBox)c;
                    break;
                }
            }

            if (tb != null)
            {
                int cursorPosition = tb.SelectionStart;
                tb.SelectionStart = cursorPosition;
            }
        }

        private void RetirementConcept_Load(object sender, EventArgs e)
        {
            if(Closse)
            {
                btnActualizar.Visible = false;
                btnNuevo.Visible = false;
            }
            if(Retire == false)
            {
              lblFecha.Text = "Fecha del ingreso";
              lblRetiro.Text = "Ingreso";
            }
            dtpRetiro.MinDate = FechaMinima;
            dtpRetiro.MaxDate = DateTime.Now;
            CrearGridView();
            BuscarRetiros();
            loaded = true;
        }
        public async void BuscarRetiros()
        {
            AppRepository obj = new AppRepository();
            var lista = await Task.Run(() => obj.GetRetirementsByIdCashfund(IdCashfund,Retire));

            if (lista != null && lista.Count > 0)
            {
                TotalGeneral = lista.Where(x => x.Status == "Activo").Sum(x => x.Amount);
                if(loaded == false)
                Inicio = TotalGeneral;
                var bindingList = new BindingList<ListRetirementsModel>(lista);
                dgvRetiros.DataSource = bindingList;
            }
        }
        public void CrearGridView()
        {
            dgvRetiros.Columns.Clear();
            dgvRetiros.AutoGenerateColumns = false;
            dgvRetiros.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Id",
                HeaderText = "Id",
                DataPropertyName = "Id",
                ReadOnly = true,
                Visible = false,
                Width = 100
            });
            dgvRetiros.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Amount",
                HeaderText = "Cantidad",
                DataPropertyName = "Amount",
                ReadOnly = true,
                Width = 100
            });
            dgvRetiros.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Created",
                HeaderText = "Fecha",
                DataPropertyName = "Created",
                ReadOnly = true,
                Width = 100
            });
            dgvRetiros.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Concept",
                HeaderText = "Concepto",
                DataPropertyName = "Concept",
                ReadOnly = true,
                Visible = false,
                Width = 100
            });
            dgvRetiros.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Status",
                HeaderText = "Estatus",
                DataPropertyName = "Status",
                ReadOnly = true,
                Visible = true,
                Width = 100
            });
            DataGridViewButtonColumn btnVer = new DataGridViewButtonColumn
            {
                Name = "Ver",
                HeaderText = "Acción",
                Text = "Ver",
                UseColumnTextForButtonValue = true, // Para que todos los botones digan "Quitar"
                Width = 90,
                FlatStyle = FlatStyle.Flat,
            };
            btnVer.DefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);
            btnVer.DefaultCellStyle.ForeColor = Color.FromArgb(108, 117, 125);
            dgvRetiros.Columns.Add(btnVer);

            if (Closse == false)
            {
                DataGridViewButtonColumn btnEliminar = new DataGridViewButtonColumn
                {
                    Name = "Cambiar",
                    HeaderText = "Acción",
                    Text = "Cambiar Estatus",
                    UseColumnTextForButtonValue = true, // Para que todos los botones digan "Quitar"
                    Width = 130,
                    FlatStyle = FlatStyle.Flat,
                };
                btnEliminar.DefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);
                btnEliminar.DefaultCellStyle.ForeColor = Color.FromArgb(108, 117, 125);
                dgvRetiros.Columns.Add(btnEliminar);
            }
            dgvRetiros.AllowUserToAddRows = false;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            if(NudRetiro.Value <= 0)
            {
                MessageBox.Show("Debe ingresar una cantidad mayor a cero", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string mensaje = Retire == true ? "Debe ingresar un motivo para el retiro" : "Debe ingresar un motivo para el ingreso";
            if (txtMotivo.Text.Trim() == string.Empty )
            {
                MessageBox.Show(mensaje, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (Retire)
            {
                if (TotalGeneral + NudRetiro.Value > TotalMax)
                {
                    MessageBox.Show("El monto del retiro no puede ser mayor al total disponible", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else
            { 
            TotalGeneral = TotalGeneral - Inicio <0 ? TotalGeneral : TotalGeneral - Inicio;
            }
            btnActualizar.Visible = false;
            AppRepository obj = new AppRepository();
            var retiro = new RetirementModel
            {
                Id= 0,
                IdCashfund = IdCashfund,
                Amount = NudRetiro.Value,
                Concept = txtMotivo.Text,
                Created = dtpRetiro.Value,
                Retire = Retire
            };
            Id = 0;
            var result = obj.SaveRetirement(retiro).Result;
            mensaje = Retire == true ? "Retiro guardado correctamente" : "Ingreso guardado correctamente";
            if (result)
                MessageBox.Show(mensaje, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                MessageBox.Show("Error al guardar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }        
          
            sicambio = true;
            BuscarRetiros();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (NudRetiro.Value <= 0)
            {
                MessageBox.Show("Debe ingresar una cantidad mayor a cero", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string mensaje = Retire == true ? "Debe ingresar un motivo para el retiro" : "Debe ingresar un motivo para el ingreso";

            if (txtMotivo.Text.Trim() == string.Empty)
            {
                MessageBox.Show(mensaje, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            TotalGeneral = TotalGeneral - (decimal)dgvRetiros.Rows.Cast<DataGridViewRow>().Where(x => (int)x.Cells["Id"].Value == Id).Select(x => x.Cells["Amount"].Value).FirstOrDefault();
            if (Retire)
            {
                if (TotalGeneral + NudRetiro.Value > TotalMax)
                {
                    MessageBox.Show("El monto del retiro no puede ser mayor al total disponible", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            
            AppRepository obj = new AppRepository();
            var retiro = new RetirementModel
            {
                Id = Id,
                IdCashfund = IdCashfund,
                Amount = NudRetiro.Value,
                Concept = txtMotivo.Text,
                Created = dtpRetiro.Value,
                Retire = Retire
            };
            var result = obj.SaveRetirement(retiro).Result;
            mensaje = Retire == true ? "Retiro guardado correctamente" : "Ingreso guardado correctamente";

            if (result)
                MessageBox.Show(mensaje, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                MessageBox.Show("Error al guardar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            sicambio = true;
            BuscarRetiros();
        }

        private async void dgvRetiros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            Id = (int)dgvRetiros.Rows[e.RowIndex].Cells["Id"].Value;
            switch (dgvRetiros.Columns[e.ColumnIndex].Name)
            {
                case "Cambiar":
                    AppRepository obj = new AppRepository();
                    await obj.UpdateStatusRetirement(Convert.ToInt32(Id));
                    sicambio = true;
                    BuscarRetiros();
                    break;
                case "Ver":
                    if(Closse == false)
                    btnActualizar.Visible = true;
                    NudRetiro.Value = (decimal)dgvRetiros.Rows[e.RowIndex].Cells["Amount"].Value;
                    txtMotivo.Text = dgvRetiros.Rows[e.RowIndex].Cells["Concept"].Value.ToString();
                    dtpRetiro.Value = dgvRetiros.Rows[e.RowIndex].Cells["Created"].Value != null ? Convert.ToDateTime(dgvRetiros.Rows[e.RowIndex].Cells["Created"].Value) : DateTime.Now;
                    break;
            }
        }

        private void dtpRetiro_ValueChanged(object sender, EventArgs e)
        {
            DateTime Minima = FechaMinima;
            DateTime fechaMaxima = DateTime.Now;

            if (dtpRetiro.Value < Minima)
            {
                dtpRetiro.Value = Minima;
            }
            else if (dtpRetiro.Value > fechaMaxima)
            {
                dtpRetiro.Value = fechaMaxima;
                System.Media.SystemSounds.Beep.Play();
            }
        }
    }
}
