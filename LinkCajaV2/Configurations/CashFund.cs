using LinkCajaV2.Catalogs;
using LinkCajaV2.Data;
using LinkCajaV2.Items;
using LinkCajaV2.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinkCajaV2.Configurations
{
    public partial class CashFund : Form
    {
        public int IdBox { get; set; }
        public CashFund()
        {
            InitializeComponent();
        }

        private void CashFund_Load(object sender, EventArgs e)
        {
            if (IdBox == 0)
            {
                MessageBox.Show("No se ha seleccionado una caja. Por favor, selecciona una caja para continuar.", "Caja no seleccionada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
                return;
            }
        }
        private void AgregarBotones()
        {
            DataGridViewButtonColumn btnEditar = new DataGridViewButtonColumn();
            btnEditar.Name = "btnEditar";
            btnEditar.HeaderText = "Acción";
            btnEditar.Text = "Editar";
            btnEditar.UseColumnTextForButtonValue = true;
            dgvFondoCaja.Columns.Add(btnEditar);
            DataGridViewButtonColumn btnCambiar = new DataGridViewButtonColumn();
            btnCambiar.Name = "btnCambiar";
            btnCambiar.HeaderText = "Acción";
            btnCambiar.Text = "Cambio Estatus";
            btnCambiar.UseColumnTextForButtonValue = true;
            dgvFondoCaja.Columns.Add(btnCambiar);
        }
        private async void Buscar() {
            progressBar1.Style = ProgressBarStyle.Marquee; // La barra empieza a moverse sola
            progressBar1.MarqueeAnimationSpeed = 30; // Velocidad de la animación
            btnBuscar.Enabled = false; // Deshabilitar el botón para evitar múltiples clics
            btnNuevo.Enabled = false;
            dgvFondoCaja.DataSource = null;
            dgvFondoCaja.Columns.Clear();
            try
            {
                AppRepository obj = new AppRepository();
                var lista = await Task.Run(() => obj.GetCashFund(IdBox, dtDesde.Value, dtHasta.Value));
                dgvFondoCaja.DataSource = lista != null && lista.Count > 0 ? lista : null;
                if (lista == null || lista.Count == 0)
                {
                    MessageBox.Show("No se encontraron fondos.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    AgregarBotones();
                    MessageBox.Show("Carga completa", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                progressBar1.Style = ProgressBarStyle.Blocks;
                progressBar1.Value = 0;
                btnBuscar.Enabled = true;
                btnNuevo.Enabled = true;
            }
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
         Buscar();
        }

        private async void btnNuevo_Click(object sender, EventArgs e)
        {
            Fund fund = new Fund();
            fund.ShowDialog();
            if (fund.DialogResult == DialogResult.OK)
            {
                AppRepository obj = new AppRepository();
                var r = await obj.GetCashFundbyDate(IdBox, fund.Date);
                if(r != null && r.Id != 0)
                {
                    MessageBox.Show("Ya existe un fondo para esta fecha. Por favor, elige otra fecha.", "Fondo existente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                CashFundModel c = new CashFundModel
                {
                    Id = 0,
                    IdBox = IdBox,
                    Date = fund.Date,
                    Cashfund = fund.Amount
                };
                bool re = obj.SaveCashFund(c).Result;
                if (re)
                {
                    MessageBox.Show("Fondo de caja guardado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Buscar();
                }
                else
                {
                    MessageBox.Show("Error al guardar el fondo de caja. Por favor, intenta nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async void dgvFondoCaja_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            int Id = (int)dgvFondoCaja.Rows[e.RowIndex].Cells["Id"].Value;

            switch (dgvFondoCaja.Columns[e.ColumnIndex].Name)
            {
                case "btnEditar":
                    Fund fund = new Fund();
                    fund.ShowDialog();
                    if (fund.DialogResult == DialogResult.OK)
                    {
                        AppRepository obj = new AppRepository();
                        var r = await obj.GetCashFundbyDate(IdBox, fund.Date);
                        if (r != null && r.Id != 0 && r.Id != Id)
                        {
                            MessageBox.Show("Ya existe un fondo para esta fecha. Por favor, elige otra fecha.", "Fondo existente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        CashFundModel c = new CashFundModel
                        {
                            Id = Id,
                            IdBox = IdBox,
                            Date = fund.Date,
                            Cashfund = fund.Amount
                        };
                        bool re = obj.SaveCashFund(c).Result;
                        if (re)
                        {
                            MessageBox.Show("Fondo de caja guardado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Buscar();
                        }
                        else
                        {
                            MessageBox.Show("Error al guardar el fondo de caja. Por favor, intenta nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    break;
                case "btnCambiar":
                    AppRepository obj2 = new AppRepository();
                    var resultado = obj2.UpdateStatusCashFund(Id).Result;
                    if (resultado)
                    {
                        MessageBox.Show("Cambio de estado exitoso", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error al cambiar el estado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    Buscar();
                    break;
            }
        }
    }
}
