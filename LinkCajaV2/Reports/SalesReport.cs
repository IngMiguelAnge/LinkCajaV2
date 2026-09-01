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
using static QuestPDF.Helpers.Colors;

namespace LinkCajaV2.Reports
{
    public partial class SalesReport : Form
    {
        
        public SalesReport()
        {
            InitializeComponent();
        }

        private void SalesReport_Load(object sender, EventArgs e)
        {
            AppRepository obj = new AppRepository();

            try
            {
                // llenar el ComBox de Provedores
                var ListProveedores = obj.GetSuppliersActives().Result.OrderBy(x => x.Name).ToList();
                ListProveedores.Insert(0, new ListSuppliersActivesModel { Id = 0, Name = "Seleccione" });

                cbProveedor.Items.Clear(); 
                cbProveedor.DisplayMember = "Name";
                cbProveedor.ValueMember = "Id";
                cbProveedor.DataSource = ListProveedores;
                cbProveedor.SelectedIndex = 0;

                // Llenar el ComboBox de Categorias
                var ListCategorias = obj.GetCategories("").Result.ToList();
                var CategoriasOrdenadas = ListCategorias.OrderBy(x => x.Nombre).ToList();
                CategoriasOrdenadas.Insert(0, new ListCategoriesModel { Id = 0, Nombre = "Seleccione" });

                cbCategoria.Items.Clear(); 
                cbCategoria.DisplayMember = "Nombre";
                cbCategoria.ValueMember = "Id";
                cbCategoria.DataSource = CategoriasOrdenadas;
                cbCategoria.SelectedIndex = 0;

               
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los catálogos iniciales: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void ConfigurarGridView()
        {
            dgvVentas.DataSource = null; // este es para que limpie la anterior busqueda
            dgvVentas.Columns.Clear();
            dgvVentas.AutoGenerateColumns = false;
            dgvVentas.AllowUserToAddRows = false;
            dgvVentas.ReadOnly = true;
            dgvVentas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            string formatoMoneda = "'$' #,##0.00";

            dgvVentas.Columns.Add(new DataGridViewTextBoxColumn { Name = "Code", HeaderText = "SKU", DataPropertyName = "Code" });
            dgvVentas.Columns.Add(new DataGridViewTextBoxColumn { Name = "Description", HeaderText = "Descripción", DataPropertyName = "Description", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
            dgvVentas.Columns.Add(new DataGridViewTextBoxColumn { Name = "Category", HeaderText = "Categoría", DataPropertyName = "Category" });
            dgvVentas.Columns.Add(new DataGridViewTextBoxColumn { Name = "QuantitySold", HeaderText = "Cant. Vendida", DataPropertyName = "QuantitySold", DefaultCellStyle = new DataGridViewCellStyle { Format = "0.###" } });


            dgvVentas.Columns.Add(new DataGridViewTextBoxColumn { Name = "SalePrice", HeaderText = "Precio Venta", DataPropertyName = "SalePrice", DefaultCellStyle = new DataGridViewCellStyle { Format = formatoMoneda } });
            dgvVentas.Columns.Add(new DataGridViewTextBoxColumn { Name = "SupplierPrice", HeaderText = "Costo Provedor", DataPropertyName = "SupplierPrice", DefaultCellStyle = new DataGridViewCellStyle { Format = formatoMoneda } });
            dgvVentas.Columns.Add(new DataGridViewTextBoxColumn { Name = "TotalInvestment", HeaderText = "Inversión Total", DataPropertyName = "TotalInvestment", DefaultCellStyle = new DataGridViewCellStyle { Format = formatoMoneda } });
          
            dgvVentas.Columns.Add(new DataGridViewTextBoxColumn { Name = "TotalSale", HeaderText = "Venta Total", DataPropertyName = "TotalSale", DefaultCellStyle = new DataGridViewCellStyle { Format = formatoMoneda } });

            dgvVentas.Columns.Add(new DataGridViewTextBoxColumn { Name = "Profit", HeaderText = "Ganancia Total", DataPropertyName = "Profit", DefaultCellStyle = new DataGridViewCellStyle { Format = formatoMoneda, Font = new Font(dgvVentas.Font, FontStyle.Bold) } });
            dgvVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                
                progressBar1.Visible = true; 
                ConfigurarGridView();

                // Recolectamos datos de la pantalla
                DateTime desde = dtDesde.Value.Date;
                DateTime hasta = dtHasta.Value.Date;

                string codigo = ""; 
                string nombre = txtNombre.Text.Trim();
                string descripcion = txtDescripcion.Text.Trim();

                int idProveedor = cbProveedor.SelectedIndex > 0 ? (int)cbProveedor.SelectedValue : 0;
                int idCategoria = cbCategoria.SelectedIndex > 0 ? (int)cbCategoria.SelectedValue : 0;

                // Vamos por los datos a SQL
                AppRepository obj = new AppRepository();
                var listaVentas = await obj.GetSalesReportData(desde, hasta, codigo, nombre, descripcion, idProveedor, idCategoria);
                var listaFinal = listaVentas?.ToList() ?? new List<SalesReportModel>();

                if (listaFinal.Count == 0)
                {
                    MessageBox.Show("No se encontraron ventas en el rango seleccionado.", "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Los 0
                    lblTotalGeneral.Text = " Venta Total: $0.00";
                    lblInversionTotal.Text = "Inversión Total: $0.00"; 
                    lblGananciaTotal.Text = "Total Ganancia: $0.00";   
                    return;
                }

                // Ordenamos con la clase 
                dgvVentas.DataSource = new SortableBindingList<SalesReportModel>(listaFinal);

                
                decimal granTotal = listaFinal.Sum(x => x.TotalSale);
                decimal inversionTotal = listaFinal.Sum(x => x.TotalInvestment); // NUEVO
                decimal gananciaTotal = listaFinal.Sum(x => x.Profit); // NUEVO
           

                lblTotalGeneral.Text = "Venta Total: " + granTotal.ToString("'$' #,##0.00");
                lblInversionTotal.Text = "Inversión Total: " + inversionTotal.ToString("'$' #,##0.00"); // NUEVO
                lblGananciaTotal.Text = "Total Ganancia: " + gananciaTotal.ToString("'$' #,##0.00");     // NUEVO

                var ticketsDelPeriodo = await obj.GetTickets(0, desde, hasta, true);
                decimal envioTotal = ticketsDelPeriodo?.Sum(t => t.CostoEnvio) ?? 0;
                lblTotalEnvio.Text = "Total Envío: " + envioTotal.ToString("'$' #,##0.00");

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar el reporte: {ex.Message}", "Error de Consulta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                
                 progressBar1.Visible = false;
            }
        }

        private async void BtnImpresion_Click(object sender, EventArgs e)
        {
            try
            {
                //  Recolectamos fechas 
                DateTime desde = dtDesde.Value.Date;
                DateTime hasta = dtHasta.Value.Date;

                //  Recolectamos los textos 
                string codigo = "";
                string nombre = txtNombre.Text.Trim();
                string descripcion = txtDescripcion.Text.Trim();

                // Recolectamos combos
                int idProveedor = cbProveedor.SelectedIndex > 0 ? (int)cbProveedor.SelectedValue : 0;
                int idCategoria = cbCategoria.SelectedIndex > 0 ? (int)cbCategoria.SelectedValue : 0;

        

                //  Vamos por la info a SQL
                AppRepository obj = new AppRepository();
                var listaVentas = await obj.GetSalesReportData(desde, hasta, codigo, nombre, descripcion, idProveedor, idCategoria);

          
                var listaFinal = listaVentas?.ToList() ?? new List<SalesReportModel>();

                if (listaFinal.Count == 0)
                {
                    MessageBox.Show("No hay ventas en este rango para imprimir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var ticketsDelPeriodo = await obj.GetTickets(0, desde, hasta, true);
                decimal envioTotal = ticketsDelPeriodo?.Sum(t => t.CostoEnvio) ?? 0;

                // Invocar impresiones
                ImpressionsGeneral im = new ImpressionsGeneral();

                im.ImpresionReporteVentas(listaFinal, desde, hasta, envioTotal);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar el PDF: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        
            
    }
}
