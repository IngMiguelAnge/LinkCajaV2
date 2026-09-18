using LinkCajaV2.Catalogs;
using LinkCajaV2.Data;
using LinkCajaV2.Items;
using LinkCajaV2.Model;
using LinkCajaV2.Reports;
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
            CargarOpciones();
        }

        // Tabla actualizada 
        public void CrearGridCortes()
        {
            dgvFondoCaja.DataSource = null;
            dgvFondoCaja.Columns.Clear();
            dgvFondoCaja.AutoGenerateColumns = false;
            dgvFondoCaja.ReadOnly = true;
            dgvFondoCaja.AllowUserToAddRows = false;
            dgvFondoCaja.RowHeadersVisible = false; 
            

     

            // Columnas Visibles
            dgvFondoCaja.Columns.Add(new DataGridViewTextBoxColumn { Name = "Caja", HeaderText = "Turno / Caja", DataPropertyName = "Caja" });
            dgvFondoCaja.Columns.Add(new DataGridViewTextBoxColumn { Name = "Apertura", HeaderText = "Fecha de Apertura", DataPropertyName = "Apertura" });
            dgvFondoCaja.Columns.Add(new DataGridViewTextBoxColumn { Name = "Cierre", HeaderText = "Fecha de Cierre", DataPropertyName = "Cierre" });
            dgvFondoCaja.Columns.Add(new DataGridViewTextBoxColumn { Name = "Estatus", HeaderText = "Estatus", DataPropertyName = "Estatus" });
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
            btnEditar.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            btnEditar.Width = 100;
            dgvFondoCaja.Columns.Add(btnEditar);

            //DataGridViewButtonColumn btnRetiros = new DataGridViewButtonColumn();
            //btnRetiros.Name = "btnRetiros";
            //btnRetiros.HeaderText = "Acción";
            //btnRetiros.Text = "Retiros";
            //btnRetiros.UseColumnTextForButtonValue = true;
            //btnRetiros.FlatStyle = FlatStyle.Flat;
            //btnRetiros.DefaultCellStyle.BackColor = Color.FromArgb(240, 242, 245);
            //btnRetiros.DefaultCellStyle.ForeColor = Color.FromArgb(1, 110, 203);
            //dgvFondoCaja.Columns.Add(btnRetiros);

            //DataGridViewButtonColumn btnIngresos = new DataGridViewButtonColumn();
            //btnIngresos.Name = "btnIngresos";
            //btnIngresos.HeaderText = "Acción";
            //btnIngresos.Text = "Ingresos";
            //btnIngresos.UseColumnTextForButtonValue = true;
            //btnIngresos.FlatStyle = FlatStyle.Flat;
            //btnIngresos.DefaultCellStyle.BackColor = Color.FromArgb(240, 242, 245);
            //btnIngresos.DefaultCellStyle.ForeColor = Color.FromArgb(1, 110, 203);
            //dgvFondoCaja.Columns.Add(btnIngresos);
        }

        public void CrearGridResumenEntradas(bool esResumen)
        {
            dgvFondoCaja.DataSource = null;
            dgvFondoCaja.Columns.Clear();
            dgvFondoCaja.AutoGenerateColumns = false;
            dgvFondoCaja.ReadOnly = true;
            dgvFondoCaja.AllowUserToAddRows = false;
            dgvFondoCaja.RowHeadersVisible = false;

            // CONCEPTO
            dgvFondoCaja.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Concepto",
                HeaderText = "Concepto",
                DataPropertyName = "Concepto",
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
                Width = esResumen ? 350 : 150
            });

            // Si no es resumen agregamos las columnas de entradas y salidas

            if (!esResumen)
            {
                // Columna oculta para mostrar el motivo
                dgvFondoCaja.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "VerConcepto",
                    HeaderText = "Ver Concepto",
                    DataPropertyName = "VerConcepto",
                    ReadOnly = true,
                    Visible = false,
                    Width = 300
                });

                // ARTICULO
                dgvFondoCaja.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "Articulo",
                    HeaderText = "Articulo",
                    DataPropertyName = "Articulo",
                    ReadOnly = true,
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                });

                // FECHA
                dgvFondoCaja.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "Fecha",
                    HeaderText = "Fecha",
                    DataPropertyName = "Fecha",
                    ReadOnly = true,
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
                    Width = 220
                });
            }

            // MONTO
            dgvFondoCaja.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Monto",
                HeaderText = "Monto",
                DataPropertyName = "Monto",
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
                Width = 110
            });

            // ACCIÓN AL FINAL
            if (!esResumen)
            {
                DataGridViewButtonColumn btnVer = new DataGridViewButtonColumn
                {
                    Name = "Ver",
                    HeaderText = "Acción",
                    Text = "Ver motivo",
                    UseColumnTextForButtonValue = true,
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
                    Width = 110,
                    FlatStyle = FlatStyle.Flat
                };

                btnVer.DefaultCellStyle.BackColor =
                    Color.FromArgb(245, 245, 245);

                btnVer.DefaultCellStyle.ForeColor =
                    Color.FromArgb(108, 117, 125);

                dgvFondoCaja.Columns.Add(btnVer);
            }
        }
        private async void Buscar()
        {
            progressBar1.Style = ProgressBarStyle.Marquee;
            progressBar1.MarqueeAnimationSpeed = 30;
            btnBuscar.Enabled = false;
            btnNuevo.Enabled = false;

            try
            {
                AppRepository obj = new AppRepository();

                switch (CBoptions.Text)
                {
                   
                    // CORTES
                  
                    case "Ver corte":
                        {
                            CrearGridCortes();

                            int cajaSeleccionada = 0;

                            if (CBcaja.SelectedValue != null)
                            {
                                int.TryParse(
                                    CBcaja.SelectedValue.ToString(),
                                    out cajaSeleccionada
                                );
                            }

                            var lista = await Task.Run(() =>
                                obj.GetCashFund(
                                    dtDesde.Value,
                                    dtHasta.Value,
                                    cajaSeleccionada
                                )
                            );

                            if (lista == null || lista.Count == 0)
                            {
                                dgvFondoCaja.DataSource = null;

                                MessageBox.Show(
                                    "No se encontraron cortes.",
                                    "Información",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information
                                );

                                return;
                            }

                            dgvFondoCaja.DataSource = lista;

                            break;
                        }

                   
                    // RESUMEN
                 
                    case "Ver resumen":
                        {
                            CrearGridResumenEntradas(true);

                            var detalles = await obj.GetCashDrop(
                                dtDesde.Value,
                                dtHasta.Value,
                                false
                            );

                            var listaFinal = detalles?
                                .OrderBy(x => x.Fecha)
                                .ToList()
                                ?? new List<CashDropModel>();

                            if (listaFinal.Count == 0)
                            {
                                dgvFondoCaja.DataSource = null;

                                MessageBox.Show(
                                    "No se encontraron datos para el resumen.",
                                    "Información",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information
                                );

                                return;
                            }

                            dgvFondoCaja.DataSource = listaFinal;

                            break;
                        }

              
                    // ENTRADAS Y SALIDAS
              
                    case "Ver entradas y salidas":
                        {
                            CrearGridResumenEntradas(false);

                            var detalles = await obj.GetCashDrop(
                                dtDesde.Value,
                                dtHasta.Value,
                                true
                            );

                            var listaFinal = detalles?
                                .OrderBy(x => x.Fecha)
                                .ToList()
                                ?? new List<CashDropModel>();

                            if (listaFinal.Count == 0)
                            {
                                dgvFondoCaja.DataSource = null;

                                MessageBox.Show(
                                    "No se encontraron entradas o salidas.",
                                    "Información",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information
                                );

                                return;
                            }

                            dgvFondoCaja.DataSource = listaFinal;

                            break;
                        }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
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
            if (CBoptions.Text == "Seleccione")
            {
                MessageBox.Show("Seleccione una opción.","Aviso",   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CBoptions.Focus();
                return;
            }
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
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            string columna = dgvFondoCaja.Columns[e.ColumnIndex].Name;

            switch (columna)
            {
            
                // VER CORTE
            
                case "btnEditar":
                    {
                        ListCashFundModel fila =dgvFondoCaja.Rows[e.RowIndex].DataBoundItem as ListCashFundModel;
                        if (fila == null)return;
                        Fund fund = new Fund();
                        fund.Id = fila.Id;
                        fund.IdBox = fila.IdBox;
                        fund.ShowDialog();
                        Buscar();
                        break;
                    }

            
                // VER  ENTRADAS / SALIDAS
      
                case "Ver":
                    {
                        string concepto = Convert.ToString( dgvFondoCaja.Rows[e.RowIndex].Cells["VerConcepto"].Value);

                        MessageBox.Show( concepto,"Concepto",MessageBoxButtons.OK, MessageBoxIcon.Information );
                        break;
                    }
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
                if (CBcaja.SelectedValue != null) int.TryParse(CBcaja.SelectedValue.ToString(), out cajaSeleccionada);

                AppRepository obj = new AppRepository();
                var listaCortes = await Task.Run(() => obj.GetCashFund(desde, hasta, cajaSeleccionada));
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

                // cargamos las cajas
                var listaCajas = await Task.Run(() => obj.GetBoxsActives());

                if (listaCajas != null)
                {
                    listaCajas.Insert(0, new ListBoxModel { Id = 0, Nombre = "TODAS LAS CAJAS" });
                    CBcaja.DataSource = listaCajas;
                    CBcaja.DisplayMember = "Nombre";
                    CBcaja.ValueMember = "Id";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los filtros: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CargarOpciones()
        {
            CBoptions.Items.Clear();
            CBoptions.Items.Add("Seleccione");
            CBoptions.Items.Add("Ver corte");
            CBoptions.Items.Add("Ver resumen");
            CBoptions.Items.Add("Ver entradas y salidas");

            CBoptions.DropDownStyle = ComboBoxStyle.DropDownList;
            CBoptions.SelectedIndex = 0;

            CBcaja.Visible = false;
            lblNombre.Visible = false;
            BtnImpresion.Visible = false;
        }

        private void CBoptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvFondoCaja.DataSource = null;
            switch (CBoptions.Text)
            {
                case "Seleccione":
                    {                                                                                                                                                                                               
                        CBcaja.Visible = false;
                        lblNombre.Visible = false;
                        BtnImpresion.Visible = false;

                        dgvFondoCaja.DataSource = null;
                        dgvFondoCaja.Columns.Clear();

                        break;
                    }
                case "Ver corte":
                    {

                        CBcaja.Visible = true;
                        lblNombre.Visible = true;
                        BtnImpresion.Visible = true;

                        CrearGridCortes();

                        break;
                    }

                case "Ver resumen":
                    {
                        CBcaja.Visible = false;
                        lblNombre.Visible = false;
                        BtnImpresion.Visible = false;

                        CrearGridResumenEntradas(true);

                        break;
                    }

                case "Ver entradas y salidas":
                    {
                        CBcaja.Visible = false;
                        lblNombre.Visible = false;
                        BtnImpresion.Visible = false;

                        CrearGridResumenEntradas(false);

                        break;
                    }
            }
    }
  }
}
