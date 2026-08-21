using LinkCajaV2.Data;
using LinkCajaV2.Model;
using Mikrotik_Administrador.Settings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using System.Globalization;

namespace LinkCajaV2.Catalogs
{
    public partial class ReporteGastosExtras : Form
    {
        public ReporteGastosExtras()
        {
            InitializeComponent();
        }

      
        public void CrearGridView()
        {
            dgvGastos.Columns.Clear();
            dgvGastos.AutoGenerateColumns = false;
            dgvGastos.ReadOnly = true;
            dgvGastos.AllowUserToAddRows = false;
            dgvGastos.AllowUserToDeleteRows = false;

            dgvGastos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "DateRecord",
                HeaderText = "Fecha y Hora",
                DataPropertyName = "DateRecord",
                Width = 150
            });

            dgvGastos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "UserName",
                HeaderText = "Caja",
                DataPropertyName = "UserName",
                Width = 120
            });

            dgvGastos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Concept",
                HeaderText = "Concepto o Motivo",
                DataPropertyName = "Concept",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvGastos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Amount",
                HeaderText = "Monto",
                DataPropertyName = "Amount",
                Width = 100,
                DefaultCellStyle = new DataGridViewCellStyle {
                    Format = "C2", 
                    FormatProvider = new CultureInfo("es-MX")
                }
            });

            dgvGastos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "TypeMovement",
                HeaderText = "Tipo de Movimiento",
                DataPropertyName = "TypeMovement",
                Width = 150
            });
        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                btnBuscar.Enabled = false;
                BtnImpresion.Enabled = false;
                progressBar1.Visible = true;

                // Iniciamos la tabla
                CrearGridView();

                DateTime desde = dtDesde.Value;
                DateTime hasta = dtHasta.Value;

                AppRepository obj = new AppRepository();
                var listaGastos = await obj.GetExtraordinaryExpenses(desde, hasta);
                var listaFinal = listaGastos?.ToList() ?? new List<ExpenseReportModel>();

                if (listaFinal.Count == 0)
                {
                    MessageBox.Show("No se encontraron gastos en el rango seleccionado.", "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Etuiquetas de totales
                    lblTotalEntradas.Text = "Total de entradas: $0.00";
                    lblTotalGastos.Text = "Total Consolidado: $0.00";

                    dgvGastos.DataSource = null;
                    return;
                }

                // Llenamos la tabla con la lista
                dgvGastos.DataSource = new SortableBindingList<ExpenseReportModel>(listaFinal);

                // Clculo de totales
                decimal totalEntradas = listaFinal.Where(x => x.IsExpense == false).Sum(x => x.Amount);
                decimal totalGastos = listaFinal.Where(x => x.IsExpense == true).Sum(x => x.Amount);
                decimal granTotal = totalEntradas - totalGastos;
                CultureInfo culturaMX = new CultureInfo("es-MX");
                lblTotalEntradas.Text = "Total de entradas: " + totalEntradas.ToString("C2", culturaMX);
                lblTotalGastos.Text = "Total Entradas: " + granTotal.ToString("C2", culturaMX);


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar el reporte: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnBuscar.Enabled = true;
                BtnImpresion.Enabled = true;
                progressBar1.Visible = false;
            }
        }

        private async void BtnImpresion_Click(object sender, EventArgs e)
        {
            try
            {
                btnBuscar.Enabled = false;
                BtnImpresion.Enabled = false;
                progressBar1.Visible = true;

                DateTime desde = dtDesde.Value;
                DateTime hasta = dtHasta.Value;

                AppRepository obj = new AppRepository();
                var listaGastos = await obj.GetExtraordinaryExpenses(desde, hasta);
                var listaFinal = listaGastos?.ToList() ?? new List<ExpenseReportModel>();

                if (listaFinal.Count == 0)
                {
                    MessageBox.Show("No hay gastos en este rango para imprimir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                ImpressionsGeneral im = new ImpressionsGeneral();
                im.ImpresionReporteGastosExtras(listaFinal, desde, hasta);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar el PDF: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnBuscar.Enabled = true;
                BtnImpresion.Enabled = true;
                progressBar1.Visible = false;
            }
        }

        private void dgvGastos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string conceptoCompleto = dgvGastos.Rows[e.RowIndex].Cells["Concept"].Value.ToString();
                string usuario = dgvGastos.Rows[e.RowIndex].Cells["UserName"].Value.ToString();
                string fecha = dgvGastos.Rows[e.RowIndex].Cells["DateRecord"].Value.ToString();

                string mensaje = $"Usuario / Caja: {usuario}\n" +
                                 $"Fecha: {fecha}\n\n" +
                                 $"Detalle del Movimiento:\n{conceptoCompleto}";

                MessageBox.Show(mensaje, "Detalle Completo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}