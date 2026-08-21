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
    public partial class StockOut : Form
    {
        public StockOut()
        {
            InitializeComponent();
        }

        private async void StockOut_Load(object sender, EventArgs e)
        {
            try
            {
                AppRepository app = new AppRepository();
                var ListCategories = await app.GetCategoriesActives();
                ListCategories.Insert(0, new CategorieModel { Id = 0, Name = "Seleccione" });
                cbCategoria.DataSource = null;
                cbCategoria.DisplayMember = "Name";
                cbCategoria.ValueMember = "Id";
                cbCategoria.DataSource = ListCategories;
                cbCategoria.SelectedIndex = 0;
                // De nuevo uso app
                var ListProveedores = app.GetSuppliersActives().Result.OrderBy(x => x.Name).ToList();
                ListProveedores.Insert(0, new ListSuppliersActivesModel { Id = 0, Name = "Seleccione" });
                cbProveedor.Items.Clear();
                cbProveedor.DisplayMember = "Name";
                cbProveedor.ValueMember = "Id";
                cbProveedor.DataSource = ListProveedores;
                cbProveedor.SelectedIndex = 0;

                await EjecutarBusqueda();
            }
            catch (Exception ex)
            {
                // Por si pasa algo raro
            }
        }

        private async void BtnBuscar_Click(object sender, EventArgs e)
        {
            await EjecutarBusqueda();
        }

        // Aca es la pura busqueda
        private async Task EjecutarBusqueda()
        {
            CrearGridView();
            // Esto es lo de la barra y que se bloqueen los botones
            progressBar1.Style = ProgressBarStyle.Marquee;
            progressBar1.MarqueeAnimationSpeed = 30;
            BtnBuscar.Enabled = false;
            BtnImpresion.Enabled = false;

            try
            {
                AppRepository app = new AppRepository();
                // Aca se llama directo con el .text
                var lista = await app.GetArticles(
                    txtCodigo.Text,
                    txtNombre.Text,
                    txtDescripcion.Text,
                    false,
                    cbCategoria.SelectedIndex > 0 ? (int)cbCategoria.SelectedValue : 0,
                    true,
                    cbProveedor.SelectedIndex > 0 ? (int)cbProveedor.SelectedValue : 0
                );

                if (lista != null && lista.Count > 0)
                {
                    dgvArticulos.DataSource = lista;

                }
                else
                {
                    MessageBox.Show("No se encontraron artículos agotados.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Cerrar todo con finalmente 
                progressBar1.Style = ProgressBarStyle.Blocks;
                progressBar1.Value = 0;
                progressBar1.MarqueeAnimationSpeed = 0;
                BtnBuscar.Enabled = true;
                BtnImpresion.Enabled = true;
            }
        }

        private async void BtnImpresion_Click(object sender, EventArgs e)
        {
            try
            {
                AppRepository app = new AppRepository();
                // Imprimimos y uso de nuevo a app 
                var lista = await app.GetArticles(txtCodigo.Text, txtNombre.Text, txtDescripcion.Text, false, 0, true, 0);

                if (lista == null || lista.Count == 0)
                {
                    MessageBox.Show("No hay artículos agotados para imprimir.");
                    return;
                }

                List<PrinterPricesModel> articulos = lista.Select(x => new PrinterPricesModel
                {
                    Articulo = x.Articulo,
                    Categoria = x.Categoria,
                    ClaveSAT = x.ClaveSAT,
                    Precio = x.Precio,
                    Stock = x.Existencias,
                    StockMinimo = x.ExistenciasMinimas
                }).ToList();

                ImpressionsGeneral im = new ImpressionsGeneral();
                im.ImpresionListaAgotados(articulos);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar el PDF: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Reutilizar el codigo de creacion de tablas
        public void CrearGridView()
        {
            dgvArticulos.Columns.Clear();
            dgvArticulos.AutoGenerateColumns = false;

            dgvArticulos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Codigo",
                HeaderText = "Código",
                DataPropertyName = "Codigo",
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            });

            dgvArticulos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Articulo",
                HeaderText = "Artículo",
                DataPropertyName = "Articulo",
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvArticulos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Categoria",
                HeaderText = "Categoría",
                DataPropertyName = "Categoria",
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            });

            dgvArticulos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Existencias",
                HeaderText = "Existencias",
                DataPropertyName = "Existencias",
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            });

            dgvArticulos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ExistenciasMinimas",
                HeaderText = "Existencias Mínimas",
                DataPropertyName = "ExistenciasMinimas",
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            });

            dgvArticulos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Precio",
                HeaderText = "Precio Venta",
                DataPropertyName = "Precio", 
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            });
        }
    }
}