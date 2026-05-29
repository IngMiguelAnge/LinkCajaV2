using LinkCajaV2.Configuraciones;
using LinkCajaV2.Data;
using LinkCajaV2.Items;
using LinkCajaV2.Model;
using LinkCajaV2.Reports;
using LinkCajaV2.Sales;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinkCajaV2.Catalogs
{
    public partial class Articles : System.Windows.Forms.Form
    {
        public int IdUsuario { get; set; }
        public string NameUser { get; set; }
        public int IdTypeUser { get; set; }
        public int Id { get; set; }
        public bool IsVenta { get; set; } = false;
        public bool IsReceta { get; set; } = false;
        public int IdSeleccionado { get; set; }
        private List<ListArticlesModel> ListaImprimir { get; set; }
        public bool Impresion = false;
        ConfigPageModel ConfigBox;
        List<ListConfigImpressionsModel> ConfigImpressions;
        public Articles()
        {
            InitializeComponent();
        }
        private void btnPanelVentas_Click(object sender, EventArgs e)
        {
            Venta s = new Venta();
            s.IdUsuario = IdUsuario;
            s.NameUser = NameUser;
            s.IdTypeUser = IdTypeUser;
            s.Show();
            this.Hide();
        }
        private void btnPanelArticulos_Click(object sender, EventArgs e)
        {
            //Articles a = new Articles();
            //a.IsVenta = false;
            //a.Show();
            //this.Hide();
        }

        private void btnPanelEmpresa_Click(object sender, EventArgs e)
        {
            Company m = new Company();
            m.Show();
        }

        private void btnPanelCorte_Click(object sender, EventArgs e)
        {
            CashDrop c = new CashDrop();
            c.Show();
        }
        private void BtnPanelSalir_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
        private void btnPanelMenu_Click(object sender, EventArgs e)
        {
            Menu m = new Menu();
            m.IdUsuario = IdUsuario;
            m.NameUser = NameUser;
            m.IdTypeUser = IdTypeUser;
            m.Show();
            this.Hide();
        }
        private async void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Trim() == "" && txtCodigo.Text.Trim() == "")
            {
                DialogResult resultado = MessageBox.Show("Ha dejado el campo vacio, esto buscara a todos los articulos pero puede demorar ¿Quiere continuar?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.No)
                {
                    return;
                }
            }
            Impresion = false;
            await BuscarArticulos();
        }
        public async Task BuscarArticulos()
        {
            progressBar1.Style = ProgressBarStyle.Marquee; // La barra empieza a moverse sola
            progressBar1.MarqueeAnimationSpeed = 30; // Velocidad de la animación
            btnNuevo.Enabled = false;
            BtnBuscar.Enabled = false;
            BtnImpresion.Enabled = false;
            if (Impresion == false)
            {
                dgvArticulos.DataSource = null;
                dgvArticulos.Columns.Clear();
            }

            try
            {
                AppRepository obj = new AppRepository();
                int IdCategory = cbCategoria.SelectedIndex > 0 ? (int)cbCategoria.SelectedValue : 0;
                var lista1 = new List<ListArticlesModel>();
                var lista2 = new List<ListArticlesActivesModel>();
                if (IsVenta == false)
                    lista1 = await Task.Run(()=>obj.GetArticles(txtCodigo.Text, txtNombre.Text, IsReceta, IdCategory,CBAgotados.Checked));
                else
                    lista2 = await Task.Run(()=>obj.GetArticlesActives(txtCodigo.Text, txtNombre.Text,IdCategory));

                if (Impresion == false)
                    if (IsVenta == false)
                        dgvArticulos.DataSource = lista1 != null && lista1.Count > 0 ? lista1 : null;
                    else
                    {
                        dgvArticulos.DataSource = lista2 != null && lista2.Count > 0 ? lista2 : null;
                    }
                   else
                   ListaImprimir = lista1;
                if ((lista1 == null || lista1.Count == 0) && (lista2 == null || lista2.Count == 0))
                {
                    MessageBox.Show("No se encontraron articulos.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    if (Impresion == false)
                    {
                        AgregarBotones();
                        //MessageBox.Show("Carga completa", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                if (dgvArticulos.Columns["Id"] != null)
                {
                    dgvArticulos.Columns["Id"].Visible = false;
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
                progressBar1.MarqueeAnimationSpeed = 0;
                btnNuevo.Enabled = true;
                BtnBuscar.Enabled = true;
                BtnImpresion.Enabled = true;
            }
        }
        private async void btnNuevo_Click(object sender, EventArgs e)
        {
            Article m = new Article();
            m.Id = 0;
            m.ShowDialog();
            await BuscarArticulos();
        }
        private async void dgvArticulos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Evitar errores si hacen click en el encabezado
            if (e.RowIndex < 0) return;
            var Id = dgvArticulos.Rows[e.RowIndex].Cells["Id"].Value;

            switch (dgvArticulos.Columns[e.ColumnIndex].Name)
            {
                case "btnEditar":
                    Article m = new Article();
                    m.Id = Convert.ToInt32(Id);
                    m.ShowDialog();
                    await BuscarArticulos();
                    break;
                case "btnAsignar":
                    this.IdSeleccionado = Convert.ToInt32(Id);
                    // 2. Indicamos que la operación fue exitosa
                    this.DialogResult = DialogResult.OK;
                    break;
                case "btnCambiar":
                    AppRepository obj = new AppRepository();
                    await obj.UpdateStatusArticle(Convert.ToInt32(Id));
                    await BuscarArticulos();
                    break;
                case "btnStock":
                    Stock s = new Stock();
                    s.IdArticle = Convert.ToInt32(Id);
                    s.Nombre = dgvArticulos.Rows[e.RowIndex].Cells["Articulo"].Value.ToString();
                    s.ShowDialog();
                    await BuscarArticulos();
                    break;
                case "btnProveedores":
                    PricesSuppliers pr = new PricesSuppliers();
                    pr.IdArticle = Convert.ToInt32(Id);
                    pr.ShowDialog();
                    await BuscarArticulos();
                    break;
            }
        }
        private void AgregarBotones()
        {
            if (IsVenta || IsReceta)
            {
                DataGridViewButtonColumn btnAsignar = new DataGridViewButtonColumn();
                btnAsignar.Name = "btnAsignar";
                btnAsignar.HeaderText = "Acción";
                btnAsignar.Text = "Asignar";
                btnAsignar.UseColumnTextForButtonValue = true;
                btnAsignar.FlatStyle = FlatStyle.Flat;
                btnAsignar.DefaultCellStyle.BackColor = Color.FromArgb(240, 242, 245);
                btnAsignar.DefaultCellStyle.ForeColor = Color.FromArgb(1, 110, 203);

                dgvArticulos.Columns.Add(btnAsignar);
                btnAsignar.DisplayIndex = 0;
                return;
            }
            DataGridViewButtonColumn btnEditar = new DataGridViewButtonColumn();
            btnEditar.Name = "btnEditar";
            btnEditar.HeaderText = "Acción";
            btnEditar.Text = "Editar";
            btnEditar.UseColumnTextForButtonValue = true;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.DefaultCellStyle.BackColor = Color.FromArgb(240, 242, 245);
            btnEditar.DefaultCellStyle.ForeColor = Color.FromArgb(1, 110, 203);
            dgvArticulos.Columns.Add(btnEditar);
            DataGridViewButtonColumn btnCambiar = new DataGridViewButtonColumn();
            btnCambiar.Name = "btnCambiar";
            btnCambiar.HeaderText = "Acción";
            btnCambiar.Text = "Cambiar Estatus";
            btnCambiar.UseColumnTextForButtonValue = true;
            btnCambiar.FlatStyle = FlatStyle.Flat;
            btnCambiar.DefaultCellStyle.BackColor = Color.FromArgb(240, 242, 245);
            btnCambiar.DefaultCellStyle.ForeColor = Color.FromArgb(1, 110, 203);
            dgvArticulos.Columns.Add(btnCambiar);
            DataGridViewButtonColumn btnProveedores = new DataGridViewButtonColumn();
            btnProveedores.Name = "btnProveedores";
            btnProveedores.HeaderText = "Acción";
            btnProveedores.Text = "Proveedores";
            btnProveedores.UseColumnTextForButtonValue = true;
            btnProveedores.FlatStyle = FlatStyle.Flat;
            btnProveedores.DefaultCellStyle.BackColor = Color.FromArgb(240, 242, 245);
            btnProveedores.DefaultCellStyle.ForeColor = Color.FromArgb(1, 110, 203);
            dgvArticulos.Columns.Add(btnProveedores);
            DataGridViewButtonColumn btnStock = new DataGridViewButtonColumn();
            btnStock.Name = "btnStock";
            btnStock.HeaderText = "Acción";
            btnStock.Text = "Stock";
            btnStock.UseColumnTextForButtonValue = true;
            btnStock.FlatStyle = FlatStyle.Flat;
            btnStock.DefaultCellStyle.BackColor = Color.FromArgb(240, 242, 245);
            btnStock.DefaultCellStyle.ForeColor = Color.FromArgb(1, 110, 203);
            dgvArticulos.Columns.Add(btnStock);
        }
        private void Articles_Load(object sender, EventArgs e)
        {
            if (IdTypeUser == 2)//Vendedor
            {
                //Menu lateral
                btnPanelEmpresa.Visible = false;
                btnPanelCorte.Visible = false;
            }
            if (IdTypeUser == 3)//Almacenista
            {
                //Menu lateral
                btnPanelEmpresa.Visible = false;
                btnPanelCorte.Visible = false;
                btnPanelVentas.Visible = false;
            }
            if (IsVenta || IsReceta)
            {
                btnNuevo.Visible = false;
                BtnImpresion.Visible = false;
                btnPanelArticulos.Visible = false;
                btnPanelCorte.Visible = false;
                btnPanelEmpresa.Visible = false;
                btnPanelMenu.Visible = false;
                BtnPanelSalir.Visible = false;
                btnPanelVentas.Visible = false;
                RBEtiquetas.Visible = false;
                RBListaPrecios.Visible = false;
                CBAgotados.Visible = false;
                BtnSAT.Visible = false;
            }
            AppRepository obj = new AppRepository();
            var ListCategories = obj.GetCategoriesActives().Result;
            // Insertamos un objeto "fantasma" al inicio para el placeholder
            ListCategories.Insert(0, new CategorieModel { Id = 0, Name = "Seleccione" });
            cbCategoria.Items.Clear();
            cbCategoria.DisplayMember = "Name";
            cbCategoria.ValueMember = "Id";
            cbCategoria.DataSource = ListCategories;
            cbCategoria.SelectedIndex = 0;
        }
        private async void BtnImpresion_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Trim() == "" && txtCodigo.Text.Trim() == "" && cbCategoria.SelectedIndex == 0)
            {
                DialogResult resultado = MessageBox.Show("Ha dejado el campo vacio, esto buscara  e imprimira todos los articulos pero puede demorar ¿Quiere continuar?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.No)
                {
                    return;
                }
            }
            Impresion = true;
            await BuscarArticulos();
            try
            {
                if (ListaImprimir == null || ListaImprimir.Count == 0)
                {
                    MessageBox.Show("No hay artículos para mostrar en el PDF.");
                    return;
                }
                List<PrinterPricesModel> articulos = ListaImprimir
                .Select(x => new PrinterPricesModel
                {
                    Articulo = x.Articulo,
                    Categoria = x.Categoria,
                    ClaveSAT = x.ClaveSAT,
                    Precio = x.Precio,
                    Stock = x.Existencias,
                    StockMinimo = x.ExistenciasMinimas
                })
                .ToList();
                ImpressionsGeneral im = new ImpressionsGeneral();
                if(RBEtiquetas.Checked && !CBAgotados.Checked)
                    im.ImpresionEtiquetas(articulos);
                if(RBListaPrecios.Checked && !CBAgotados.Checked)
                    im.ImpresionListaPrecios(articulos);
                if (CBAgotados.Checked)
                    im.ImpresionListaAgotados(articulos);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar el PDF: " + ex.Message);
            }
        }

        private void Articles_FormClosed(object sender, FormClosedEventArgs e)
        {
            Menu m = new Menu();
            m.IdUsuario = IdUsuario;
            m.NameUser = NameUser;
            m.IdTypeUser = IdTypeUser;
            m.Show();
            this.Hide();
        }

        private async void BtnSAT_Click(object sender, EventArgs e)
        {
            if (dgvArticulos.Rows.Count == 0)
            {
                MessageBox.Show("No hay artículos para agregar codigo SAT.");
                return;

            }
            SAT s = new SAT();
            if (s.ShowDialog() != DialogResult.OK)
            {
                MessageBox.Show("Introducción de clave cancelada por el usuario.", "Clave Cancelada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int IdCategory = cbCategoria.SelectedIndex > 0 ? (int)cbCategoria.SelectedValue : 0;

            AppRepository obj = new AppRepository();
            await obj.UpdateSAT(s.Clave,txtCodigo.Text, txtNombre.Text, IdCategory);
            await BuscarArticulos();
        }

        private void CBAgotados_CheckedChanged(object sender, EventArgs e)
        {
            if (CBAgotados.Checked)
            { 
            RBEtiquetas.Enabled = false;
            RBListaPrecios.Enabled = false;
            }
            else
            {
                RBEtiquetas.Enabled = true;
                RBListaPrecios.Enabled = true;
            }
        }
    }
}
