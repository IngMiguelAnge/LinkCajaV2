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
             
                LinkCajaV2.Data.AppRepository app = new LinkCajaV2.Data.AppRepository();

                //Se conecta a SQL
                var ListCategories = await app.GetCategoriesActives();

                // Llena la caja 
                ListCategories.Insert(0, new CategorieModel { Id = 0, Name = "Seleccione" });
                cbCategoria.DataSource = null; 
                cbCategoria.DisplayMember = "Name";
                cbCategoria.ValueMember = "Id";
                cbCategoria.DataSource = ListCategories;
                cbCategoria.SelectedIndex = 0;

                //Lista de provedores 
                AppRepository obj = new AppRepository();
                var ListProveedores = obj.GetSuppliersActives().Result.OrderBy(x => x.Name).ToList();
                ListProveedores.Insert(0, new LinkCajaV2.Model.ListSuppliersActivesModel { Id = 0, Name = "Seleccione" });
                cbProveedor.Items.Clear();
                cbProveedor.DisplayMember = "Name";
                cbProveedor.ValueMember = "Id";
                cbProveedor.DataSource = ListProveedores;
                cbProveedor.SelectedIndex = 0;


                //Esta cosa carga la lista de cosas 
                await CargarAgotados();
            }
            catch (Exception ex)
            {
                // Por si pasa algo raro
            }
        }


        private async Task CargarAgotados()
        {
            try
            {

                LinkCajaV2.Data.AppRepository app = new LinkCajaV2.Data.AppRepository();

                var lista = await app.GetArticles("", "","", false, 0, true, 0);

                // Mostrar solo lo que queremos lo demas lo oculto y ocupa todo el ancho de el cuadro 
                dgvArticulos.DataSource = lista;
                if (dgvArticulos.Columns["ExistenciasMinimas"] != null) dgvArticulos.Columns["ExistenciasMinimas"].HeaderText = "Existencias Mínimas";
                dgvArticulos.Columns["Id"].Visible = false;
                dgvArticulos.Columns["ClaveSAT"].Visible = false;
                dgvArticulos.Columns["Precio"].Visible = false;
                dgvArticulos.Columns["PrecioProveedor"].Visible = false;
                dgvArticulos.Columns["PorCada"].Visible = false;
                dgvArticulos.Columns["Medicamento"].Visible = false;
                dgvArticulos.Columns["Estatus"].Visible = false;
                dgvArticulos.Columns["Stock"].Visible = false;
                dgvArticulos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvArticulos.ReadOnly = true;
                dgvArticulos.AllowUserToAddRows = false;
                dgvArticulos.RowHeadersVisible = false;
            }
            catch (Exception ex)
            {
        
            }
        }

        private void dgvArticulos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void BtnImpresion_Click(object sender, EventArgs e)
        {
            try
            {
                // Filtros
                string codigoBuscar = txtCodigo.Text.Trim();
                string nombreBuscar = txtNombre.Text.Trim();

                // Lista de Agostados desde SQL
                LinkCajaV2.Data.AppRepository app = new LinkCajaV2.Data.AppRepository();
                var lista = await app.GetArticles(codigoBuscar, nombreBuscar, "", false, 0, true, 0);

                // Revisa si hay algo que imprimir
                if (lista == null || lista.Count == 0)
                {
                    MessageBox.Show("No hay artículos agotados para imprimir.");
                    return;
                }

                // Codigo reciclado de el boton de imprimir de articulos
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
                MessageBox.Show("Error al generar el PDF: " + ex.Message);
            }
        }

        private async void BtnBuscar_Click(object sender, EventArgs e)
        {
            // Uso de string.Empty 
            if (txtNombre.Text.Trim() == string.Empty && txtCodigo.Text.Trim() == string.Empty && txtDescripcion.Text.Trim() == string.Empty)
            {
                DialogResult resultado = MessageBox.Show("Ha dejado el campo vacio, esto buscara a todos los articulos pero puede demorar ¿Quiere continuar?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.No)
                {
                    return;
                }
            }

            // Encender barra de progreso y bloquear botones
            progressBar1.Style = ProgressBarStyle.Marquee;
            progressBar1.MarqueeAnimationSpeed = 30;
            BtnBuscar.Enabled = false;
            BtnImpresion.Enabled = false;
            dgvArticulos.DataSource = null; // Limpiar la tabla 

            try
            {
                // limpiar las variables 
                string codigoBuscar = string.IsNullOrWhiteSpace(txtCodigo.Text) ? string.Empty : txtCodigo.Text.Trim();
                string nombreBuscar = string.IsNullOrWhiteSpace(txtNombre.Text) ? string.Empty : txtNombre.Text.Trim();
                string descBuscar = string.IsNullOrWhiteSpace(txtDescripcion.Text) ? string.Empty : txtDescripcion.Text.Trim();

                // Id de categoria
                int idCategoria = cbCategoria.SelectedIndex > 0 ? (int)cbCategoria.SelectedValue : 0;
                int idProveedor = cbProveedor.SelectedIndex > 0 ? (int)cbProveedor.SelectedValue : 0;

                // Estructura de AppRepository igual a Articles.cs recuperdo de el mismo codigo
                AppRepository obj = new AppRepository();

                // Búsqueda por descripcion
                var lista = await Task.Run(() => obj.GetArticles(codigoBuscar, nombreBuscar, descBuscar, false, idCategoria, true, idProveedor));

                if (lista != null && lista.Count > 0)
                {
                    dgvArticulos.DataSource = lista;
                    if (dgvArticulos.Columns["Id"] != null)
                    {
                        dgvArticulos.Columns["Id"].Visible = false;
                        // Todo esto de aca es para ponerle acentos en la tabla 
                        if (dgvArticulos.Columns["Codigo"] != null) dgvArticulos.Columns["Codigo"].HeaderText = "Código";
                        if (dgvArticulos.Columns["Articulo"] != null) dgvArticulos.Columns["Articulo"].HeaderText = "Artículo";
                        if (dgvArticulos.Columns["Categoria"] != null) dgvArticulos.Columns["Categoria"].HeaderText = "Categoría";
                        if (dgvArticulos.Columns["ExistenciasMinimas"] != null) dgvArticulos.Columns["ExistenciasMinimas"].HeaderText = "Existencias Mínimas";
                        if (dgvArticulos.Columns["PrecioProveedor"] != null) dgvArticulos.Columns["PrecioProveedor"].HeaderText = "Precio Proveedor";

                        // Todo esto de aca es para filtrar en la tabla 
                        if (dgvArticulos.Columns["ClaveSAT"] != null) dgvArticulos.Columns["ClaveSAT"].Visible = false;
                        if (dgvArticulos.Columns["Precio"] != null) dgvArticulos.Columns["Precio"].Visible = false;
                        if (dgvArticulos.Columns["PrecioProveed"] != null) dgvArticulos.Columns["PrecioProveed"].Visible = false;
                        if (dgvArticulos.Columns["PorCada"] != null) dgvArticulos.Columns["PorCada"].Visible = false;
                        if (dgvArticulos.Columns["Medicamento"] != null) dgvArticulos.Columns["Medicamento"].Visible = false;
                        if (dgvArticulos.Columns["Medicine"] != null) dgvArticulos.Columns["Medicine"].Visible = false;
                        if (dgvArticulos.Columns["Estatus"] != null) dgvArticulos.Columns["Estatus"].Visible = false;
                        if (dgvArticulos.Columns["Status"] != null) dgvArticulos.Columns["Status"].Visible = false;
                        if (dgvArticulos.Columns["Stock"] != null) dgvArticulos.Columns["Stock"].Visible = false;
                        if (dgvArticulos.Columns["Stocks"] != null) dgvArticulos.Columns["Stocks"].Visible = false;
                    }
                }
                else
                {
                    // Mensaje mas simple y corto 
                    MessageBox.Show("No se encontraron articulos agotados.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                // mensaje de error mas corto
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Cerrar todo con finallmente 
                progressBar1.Style = ProgressBarStyle.Blocks;
                progressBar1.Value = 0;
                progressBar1.MarqueeAnimationSpeed = 0;
                BtnBuscar.Enabled = true;
                BtnImpresion.Enabled = true;
            }
        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {

        }
    }
}