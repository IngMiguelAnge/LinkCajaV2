using LinkCajaV2.Catalogs;
using LinkCajaV2.Data;
using LinkCajaV2.Items;
using LinkCajaV2.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization; 
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinkCajaV2.Configurations
{
    public partial class CashFund : System.Windows.Forms.Form
    {
        public CashFund()
        {
            InitializeComponent();
            CargarCombos();
        }

        // Tabla actualizada 
        public void CrearGridView()
        {
            dgvFondoCaja.Columns.Clear();
            dgvFondoCaja.AutoGenerateColumns = false;
            dgvFondoCaja.ReadOnly = true;
            dgvFondoCaja.AllowUserToAddRows = false;
            dgvFondoCaja.RowHeadersVisible = false; 
            

            // Columnas Ocultas 
            dgvFondoCaja.Columns.Add(new DataGridViewTextBoxColumn { Name = "Id", DataPropertyName = "Id", Visible = false });
            dgvFondoCaja.Columns.Add(new DataGridViewTextBoxColumn { Name = "IdBox", DataPropertyName = "IdBox", Visible = false });

            // Columnas Visibles
            dgvFondoCaja.Columns.Add(new DataGridViewTextBoxColumn { Name = "Caja", HeaderText = "Turno / Caja", DataPropertyName = "Caja" });
            dgvFondoCaja.Columns.Add(new DataGridViewTextBoxColumn { Name = "Apertura", HeaderText = "Fecha de Apertura", DataPropertyName = "Apertura" });
            dgvFondoCaja.Columns.Add(new DataGridViewTextBoxColumn { Name = "Cierre", HeaderText = "Fecha de Cierre", DataPropertyName = "Cierre" });
            dgvFondoCaja.Columns.Add(new DataGridViewTextBoxColumn { Name = "Estatus", HeaderText = "Estatus", DataPropertyName = "Estatus" });
            dgvFondoCaja.Columns.Add(new DataGridViewTextBoxColumn { Name = "Usuario", HeaderText = "Usuario Responsable", DataPropertyName = "Usuario" });

            // Formato de Moneda
            dgvFondoCaja.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "TotalVentas",
                HeaderText = "Total Ventas",
                DataPropertyName = "TotalVentas",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "C2", FormatProvider = new CultureInfo("es-MX") }
            });

           

            // Botones ahora en este apartado 
            DataGridViewButtonColumn btnEditar = new DataGridViewButtonColumn();
            btnEditar.Name = "btnEditar";
            btnEditar.HeaderText = "Acción";
            btnEditar.Text = "Ver";
            btnEditar.UseColumnTextForButtonValue = true;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.DefaultCellStyle.BackColor = Color.FromArgb(240, 242, 245);
            btnEditar.DefaultCellStyle.ForeColor = Color.FromArgb(1, 110, 203);
            dgvFondoCaja.Columns.Add(btnEditar);

            DataGridViewButtonColumn btnRetiros = new DataGridViewButtonColumn();
            btnRetiros.Name = "btnRetiros";
            btnRetiros.HeaderText = "Acción";
            btnRetiros.Text = "Retiros";
            btnRetiros.UseColumnTextForButtonValue = true;
            btnRetiros.FlatStyle = FlatStyle.Flat;
            btnRetiros.DefaultCellStyle.BackColor = Color.FromArgb(240, 242, 245);
            btnRetiros.DefaultCellStyle.ForeColor = Color.FromArgb(1, 110, 203);
            dgvFondoCaja.Columns.Add(btnRetiros);

            DataGridViewButtonColumn btnIngresos = new DataGridViewButtonColumn();
            btnIngresos.Name = "btnIngresos";
            btnIngresos.HeaderText = "Acción";
            btnIngresos.Text = "Ingresos";
            btnIngresos.UseColumnTextForButtonValue = true;
            btnIngresos.FlatStyle = FlatStyle.Flat;
            btnIngresos.DefaultCellStyle.BackColor = Color.FromArgb(240, 242, 245);
            btnIngresos.DefaultCellStyle.ForeColor = Color.FromArgb(1, 110, 203);
            dgvFondoCaja.Columns.Add(btnIngresos);
        }

        
        private async void Buscar()
        {
            progressBar1.Style = ProgressBarStyle.Marquee;
            progressBar1.MarqueeAnimationSpeed = 30;
            btnBuscar.Enabled = false;
            btnNuevo.Enabled = false;

            // Tabla 
            CrearGridView();

            try
            {
                AppRepository obj = new AppRepository();

                int cajaSeleccionada = 0;
                int usuarioSeleccionado = 0;

                if (caja.SelectedValue != null) int.TryParse(caja.SelectedValue.ToString(), out cajaSeleccionada);
                if (id.SelectedValue != null) int.TryParse(id.SelectedValue.ToString(), out usuarioSeleccionado);

                var lista = await Task.Run(() => obj.GetCashFund(dtDesde.Value, dtHasta.Value, cajaSeleccionada, usuarioSeleccionado));

                if (lista == null || lista.Count == 0)
                {
                    dgvFondoCaja.DataSource = null;
                    MessageBox.Show("No se encontraron cortes.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Llenamos la tabla 
                dgvFondoCaja.DataSource = lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                progressBar1.Style = ProgressBarStyle.Blocks;
                progressBar1.Value = 0;
                progressBar1.MarqueeAnimationSpeed = 0;
                btnBuscar.Enabled = true;
                btnNuevo.Enabled = true;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Fund fund = new Fund();
            fund.ShowDialog();
            Buscar();
        }

        private void dgvFondoCaja_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            int Id = (int)dgvFondoCaja.Rows[e.RowIndex].Cells["Id"].Value;

            switch (dgvFondoCaja.Columns[e.ColumnIndex].Name)
            {
                case "btnEditar":
                    Fund fund = new Fund();
                    fund.Id = Id;
                    fund.IdBox = (int)dgvFondoCaja.Rows[e.RowIndex].Cells["IdBox"].Value;
                    fund.ShowDialog();
                    Buscar();
                    break;
                case "btnRetiros":
                    RetirementConcept r = new RetirementConcept();
                    r.IdCashfund = Id;
                    r.Closse = true;
                    r.Retire = true;
                    r.Show();
                    break;
                case "btnIngresos":
                    RetirementConcept ing = new RetirementConcept();
                    ing.IdCashfund = Id;
                    ing.Closse = true;
                    ing.Retire = false;
                    ing.Show();
                    break;
            }
        }

        private void BtnGastosReport_Click(object sender, EventArgs e)
        {
            ReporteGastosExtras reporte = new ReporteGastosExtras();
            reporte.ShowDialog();
        }

        private async void BtnImpresion_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime desde = dtDesde.Value;
                DateTime hasta = dtHasta.Value;

                int cajaSeleccionada = 0;
                int usuarioSeleccionado = 0;
                if (caja.SelectedValue != null) int.TryParse(caja.SelectedValue.ToString(), out cajaSeleccionada);
                if (id.SelectedValue != null) int.TryParse(id.SelectedValue.ToString(), out usuarioSeleccionado);

                AppRepository obj = new AppRepository();
                var listaCortes = await Task.Run(() => obj.GetCashFund(desde, hasta, cajaSeleccionada, usuarioSeleccionado));
                var listaFinal = listaCortes?.ToList() ?? new List<ListCashFundModel>();

                if (listaFinal.Count == 0)
                {
                    MessageBox.Show("No hay cortes en este rango para imprimir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                ImpressionsGeneral im = new ImpressionsGeneral();
                im.ImpresionReporteCortes(listaFinal, desde, hasta);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar el PDF: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void CargarCombos()
        {
            try
            {
                AppRepository obj = new AppRepository();

                // cargamos a los usuarios
                UserModel filtroUsuario = new UserModel { Name = "", User = "", IdTypeUser = 0 };
                var listaUsuarios = await Task.Run(() => obj.GetUsers(filtroUsuario));

                if (listaUsuarios != null)
                {
                    listaUsuarios.Insert(0, new ListUserModel { Id = 0, Nombre = "TODOS LOS USUARIOS" });
                    id.DataSource = listaUsuarios;
                    id.DisplayMember = "Nombre";
                    id.ValueMember = "Id";
                }

                // cargamos las cajas
                var listaCajas = await Task.Run(() => obj.GetBoxsActives());

                if (listaCajas != null)
                {
                    listaCajas.Insert(0, new ListBoxModel { Id = 0, Nombre = "TODAS LAS CAJAS" });
                    caja.DataSource = listaCajas;
                    caja.DisplayMember = "Nombre";
                    caja.ValueMember = "Id";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los filtros: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}