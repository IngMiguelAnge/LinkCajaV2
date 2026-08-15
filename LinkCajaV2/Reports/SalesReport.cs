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

namespace LinkCajaV2.Reports
{
    public partial class SalesReport : Form
    {
        public SalesReport()
        {
            InitializeComponent();
        }

        private async void SalesReport_Load(object sender, EventArgs e)
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

                // 3. Inicializar la tabla
                ConfigurarGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los catálogos iniciales: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void ConfigurarGridView()
        {
            dgvVentas.Columns.Clear();
            dgvVentas.AutoGenerateColumns = false;
            dgvVentas.AllowUserToAddRows = false;
            dgvVentas.ReadOnly = true;
            dgvVentas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            string formatoMoneda = "$ #,##0.00";

            dgvVentas.Columns.Add(new DataGridViewTextBoxColumn { Name = "Code", HeaderText = "SKU", DataPropertyName = "Code" });
            dgvVentas.Columns.Add(new DataGridViewTextBoxColumn { Name = "Description", HeaderText = "Descripción", DataPropertyName = "Description", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
            dgvVentas.Columns.Add(new DataGridViewTextBoxColumn { Name = "Category", HeaderText = "Categoría", DataPropertyName = "Category" });
            dgvVentas.Columns.Add(new DataGridViewTextBoxColumn { Name = "QuantitySold", HeaderText = "Cant. Vendida", DataPropertyName = "QuantitySold" });

            
            dgvVentas.Columns.Add(new DataGridViewTextBoxColumn { Name = "SalePrice", HeaderText = "Precio Venta", DataPropertyName = "SalePrice", DefaultCellStyle = new DataGridViewCellStyle { Format = formatoMoneda } });
            dgvVentas.Columns.Add(new DataGridViewTextBoxColumn { Name = "SupplierPrice", HeaderText = "Costo Provedor", DataPropertyName = "SupplierPrice", DefaultCellStyle = new DataGridViewCellStyle { Format = formatoMoneda } });
            dgvVentas.Columns.Add(new DataGridViewTextBoxColumn { Name = "TotalInvestment", HeaderText = "Inversión Total", DataPropertyName = "TotalInvestment", DefaultCellStyle = new DataGridViewCellStyle { Format = formatoMoneda } });
            dgvVentas.Columns.Add(new DataGridViewTextBoxColumn { Name = "TotalSale", HeaderText = "Venta Total", DataPropertyName = "TotalSale", DefaultCellStyle = new DataGridViewCellStyle { Format = formatoMoneda } });

            dgvVentas.Columns.Add(new DataGridViewTextBoxColumn { Name = "Profit", HeaderText = "Ganancia Total", DataPropertyName = "Profit", DefaultCellStyle = new DataGridViewCellStyle { Format = formatoMoneda, Font = new Font(dgvVentas.Font, FontStyle.Bold) } });
        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                // Recolectar las fechas
                DateTime desde = dtDesde.Value.Date;
                DateTime hasta = dtHasta.Value.Date.AddDays(1).AddSeconds(-1);

                // Recolectar nombres
                string textoBusqueda = txtNombre.Text.Trim();

                // Recolectar los IDs de los ComboBox (Si es 0 trae todos)
                int idProveedor = cbProveedor.SelectedIndex > 0 ? (int)cbProveedor.SelectedValue : 0;
                int idCategoria = cbCategoria.SelectedIndex > 0 ? (int)cbCategoria.SelectedValue : 0;

                // Mandamos a tarer todos los articulos 
                int filtroEstado = 2;

                // Mandamos a llamar el nuevo metodo
                AppRepository obj = new AppRepository();
                var listaVentas = await obj.GetSalesReportData(desde, hasta, textoBusqueda, idProveedor, idCategoria, filtroEstado);

                // Colocar datos en la tabla 
                dgvVentas.DataSource = null; // este es para que limpie la anterior busqueda
                dgvVentas.DataSource = listaVentas;

                // Si no encuentra nada avisa 
                if (listaVentas == null || listaVentas.Count == 0)
                {
                    MessageBox.Show("No se encontraron ventas en el rango seleccionado.", "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar el reporte: {ex.Message}", "Error de Consulta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void BtnImpresion_Click(object sender, EventArgs e)
        {
            try
            {
                //Recolectamos los mismos filtros que usamos en el boton de buscar 
                DateTime desde = dtDesde.Value.Date;
                DateTime hasta = dtHasta.Value.Date.AddDays(1).AddSeconds(-1);
                string textoBusqueda = txtNombre.Text.Trim();
                int idProveedor = cbProveedor.SelectedIndex > 0 ? (int)cbProveedor.SelectedValue : 0;
                int idCategoria = cbCategoria.SelectedIndex > 0 ? (int)cbCategoria.SelectedValue : 0;
                int filtroEstado = 2; 

                // Traemos la informa
                AppRepository obj = new AppRepository();
                var listaVentas = await obj.GetSalesReportData(desde, hasta, textoBusqueda, idProveedor, idCategoria, filtroEstado);

                if (listaVentas == null || listaVentas.Count == 0)
                {
                    MessageBox.Show("No hay ventas en este rango para imprimir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // 3. Mandamos a llamar a tu clase centralizada de impresiones
                ImpressionsGeneral im = new ImpressionsGeneral();

                im.ImpresionReporteVentas(listaVentas, desde, hasta);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar el PDF: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool ordenAscendente = true;
        private void dgvVentas_ColumnHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var lista = dgvVentas.DataSource as List<SalesReportModel>;
            if (lista == null || lista.Count == 0) return;

            // Detectamos que columna da click el usuario 
            string columnaClic = dgvVentas.Columns[e.ColumnIndex].Name;

            // Invertimos el estado (si era de A-Z, ahora será Z-A)
            ordenAscendente = !ordenAscendente;

            // Ordenas las columnas 
            switch (columnaClic)
            {
                case "Code":
                    lista = ordenAscendente ? lista.OrderBy(x => x.Code).ToList() : lista.OrderByDescending(x => x.Code).ToList();
                    break;
                case "Description":
                    lista = ordenAscendente ? lista.OrderBy(x => x.Description).ToList() : lista.OrderByDescending(x => x.Description).ToList();
                    break;
                case "Category":
                    lista = ordenAscendente ? lista.OrderBy(x => x.Category).ToList() : lista.OrderByDescending(x => x.Category).ToList();
                    break;
                case "QuantitySold":
                    lista = ordenAscendente ? lista.OrderBy(x => x.QuantitySold).ToList() : lista.OrderByDescending(x => x.QuantitySold).ToList();
                    break;
                case "SalePrice":
                    lista = ordenAscendente ? lista.OrderBy(x => x.SalePrice).ToList() : lista.OrderByDescending(x => x.SalePrice).ToList();
                    break;
                case "SupplierPrice":
                    lista = ordenAscendente ? lista.OrderBy(x => x.SupplierPrice).ToList() : lista.OrderByDescending(x => x.SupplierPrice).ToList();
                    break;
                case "TotalInvestment":
                    lista = ordenAscendente ? lista.OrderBy(x => x.TotalInvestment).ToList() : lista.OrderByDescending(x => x.TotalInvestment).ToList();
                    break;
                case "TotalSale":
                    lista = ordenAscendente ? lista.OrderBy(x => x.TotalSale).ToList() : lista.OrderByDescending(x => x.TotalSale).ToList();
                    break;
                case "Profit":
                    lista = ordenAscendente ? lista.OrderBy(x => x.Profit).ToList() : lista.OrderByDescending(x => x.Profit).ToList();
                    break;
            }

            // Refrescamos la tabla para que muestre el nuevo orden
            dgvVentas.DataSource = null;
            dgvVentas.DataSource = lista;
        }
    }
}
