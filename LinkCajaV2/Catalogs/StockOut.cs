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

                var lista = await app.GetArticles("", "", false, 0, true, 0);

                // Mostrar solo lo que queremos lo demas lo oculto y ocupa todo el ancho de el cuadro 
                dgvArticulos.DataSource = lista;
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
                var lista = await app.GetArticles(codigoBuscar, nombreBuscar, false, 0, true, 0);

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
            try
            {
                //Busca y quita espacios en blanco 
              
                string codigoBuscar = txtCodigo.Text.Trim();
                string nombreBuscar = txtNombre.Text.Trim();

               
                LinkCajaV2.Data.AppRepository app = new LinkCajaV2.Data.AppRepository();

              
                var lista = await app.GetArticles(codigoBuscar, nombreBuscar, false, 0, true, 0);

                
                dgvArticulos.DataSource = lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error al buscar: " + ex.Message);
            }
        }
    }
}