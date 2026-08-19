using LinkCajaV2.Data;
using LinkCajaV2.Model;
using Mikrotik_Administrador.Settings;
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
    public partial class FrmReporteGastosExtras : Form
    {
        public FrmReporteGastosExtras()
        {
            InitializeComponent();
        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                btnBuscar.Enabled = false;
                BtnImpresion.Enabled = false;
                progressBar1.Visible = true;

                // Tomamos las fechas
                DateTime desde = dtDesde.Value;
                DateTime hasta = dtHasta.Value;

                // Consultamos la base de datos
                AppRepository obj = new AppRepository();
                var listaGastos = await obj.GetExtraordinaryExpenses(desde, hasta);
                var listaFinal = listaGastos?.ToList() ?? new List<Model.ExpenseReportModel>();

                // Validamos si hay datos
                if (listaFinal.Count == 0)
                {
                    MessageBox.Show("No se encontraron gastos en el rango seleccionado.", "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblTotalGastos.Text = "Total Consolidado: $0.00";
                    dgvGastos.DataSource = null;
                    return;
                }
                dgvGastos.DataSource = new SortableBindingList<ExpenseReportModel>(listaFinal);

                // Llenamos la tabla
                dgvGastos.DataSource = new BindingList<ExpenseReportModel>(listaFinal);
                dgvGastos.AllowUserToAddRows = false;
                dgvGastos.AllowUserToDeleteRows = false;
                dgvGastos.ReadOnly = true;

                // Ponemos nombres para las columnas 
                dgvGastos.Columns["DateRecord"].HeaderText = "Fecha y Hora";
                dgvGastos.Columns["UserName"].HeaderText = "Caja";
                dgvGastos.Columns["Concept"].HeaderText = "Concepto o Motivo";
                dgvGastos.Columns["Amount"].HeaderText = "Monto";
                dgvGastos.Columns["Amount"].DefaultCellStyle.Format = "'$' #,##0.00";
                dgvGastos.Columns["TypeMovement"].HeaderText = "Tipo de Movimiento";
                dgvGastos.Columns["IsExpense"].Visible = false;


                //  Total 
                decimal granTotal = listaFinal.Sum(x => x.Amount);
                lblTotalGastos.Text = "Total Consolidado: " + granTotal.ToString("'$' #,##0.00");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar el reporte: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally {

                btnBuscar.Enabled = true;
                BtnImpresion.Enabled = true;
                progressBar1.Visible = false;

            }
        }

        private async void progressBar1_Click(object sender, EventArgs e)
        {
            try
            {
                progressBar1.Visible = true; // Prendemos la barra

                DateTime desde = dtDesde.Value;
                DateTime hasta = dtHasta.Value;

                AppRepository obj = new AppRepository();
                var listaGastos = await obj.GetExtraordinaryExpenses(desde, hasta);
                var listaFinal = listaGastos?.ToList() ?? new List<ExpenseReportModel>();

                if (listaFinal.Count == 0)
                {
                    MessageBox.Show("No se encontraron gastos en el rango seleccionado.", "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblTotalGastos.Text = "Total Consolidado: $0.00";
                    dgvGastos.DataSource = null;
                    return;
                }

                dgvGastos.DataSource = new BindingList<ExpenseReportModel>(listaFinal);

                decimal granTotal = listaFinal.Sum(x => x.Amount);
                lblTotalGastos.Text = "Total Consolidado: " + granTotal.ToString("'$' #,##0.00");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar el reporte: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                progressBar1.Visible = false; //se apaga la barra 
            }
        }

        private async void BtnImpresion_Click(object sender, EventArgs e)
        {
            try
            {
                // Bloqueamos los botones y encendemos barra
                btnBuscar.Enabled = false;
                BtnImpresion.Enabled = false;
                progressBar1.Visible = true;

                //  Recolectamos fechas 
                DateTime desde = dtDesde.Value;
                DateTime hasta = dtHasta.Value;

                // Vamos por la info a SQL
                AppRepository obj = new AppRepository();
                var listaGastos = await obj.GetExtraordinaryExpenses(desde, hasta);
                var listaFinal = listaGastos?.ToList() ?? new List<ExpenseReportModel>();

                if (listaFinal.Count == 0)
                {
                    MessageBox.Show("No hay gastos en este rango para imprimir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                //  Invocar la clase de impresiones
                ImpressionsGeneral im = new ImpressionsGeneral();

                //Metodo de Impresion 
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
                // Extraigo el texto
                string conceptoCompleto = dgvGastos.Rows[e.RowIndex].Cells["Concept"].Value.ToString();
                string usuario = dgvGastos.Rows[e.RowIndex].Cells["UserName"].Value.ToString();
                string fecha = dgvGastos.Rows[e.RowIndex].Cells["DateRecord"].Value.ToString();

                //  Y armo un mensaje bien estructurado
                string mensaje = $"Usuario / Caja: {usuario}\n" +
                                 $"Fecha: {fecha}\n\n" +
                                 $"Detalle del Movimiento:\n{conceptoCompleto}";

                MessageBox.Show(mensaje, "Detalle Completo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
