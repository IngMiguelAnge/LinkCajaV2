using LinkCajaV2.Data;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinkCajaV2.Catalogs
{
    public partial class Articles : Form
    {
        public int Id { get; set; }
        public bool IsVenta { get; set; } = false;
        public bool IsReceta { get; set; } = false;
        public int IdSeleccionado { get; set; }
        public Articles()
        {
            InitializeComponent();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Trim() == "" && txtCodigo.Text.Trim() == "")
            {
                DialogResult resultado = MessageBox.Show("Ha dejado el campo vacio, esto buscara a todos los articulos pero puede demorar ¿Quiere continuar?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.No)
                {
                    return;
                }
            }
            BuscarArticulos();
        }
        public async void BuscarArticulos() {
            progressBar1.Style = ProgressBarStyle.Marquee; // La barra empieza a moverse sola
            progressBar1.MarqueeAnimationSpeed = 30; // Velocidad de la animación
            btnNuevo.Enabled = false;
            BtnBuscar.Enabled = false;
            dgvArticulos.DataSource = null;
            dgvArticulos.Columns.Clear();
            try
            {
                AppRepository obj = new AppRepository();
                var lista = await Task.Run(() => IsVenta==false?             
                obj.GetArticles(txtCodigo.Text, txtNombre.Text, IsReceta) :
                obj.GetArticlesActives(txtCodigo.Text, txtNombre.Text)
                );
                dgvArticulos.DataSource = lista != null && lista.Count > 0 ? lista : null;
                if (lista == null || lista.Count == 0)
                {
                    MessageBox.Show("No se encontraron articulos.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    AgregarBotones();
                    MessageBox.Show("Carga completa", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                btnNuevo.Enabled = true;
                BtnBuscar.Enabled = true;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Article m = new Article();
            m.Id = 0;
            m.ShowDialog();
            BuscarArticulos();
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
                    BuscarArticulos();
                    break;
                case "btnAsignar":
                    this.IdSeleccionado = Convert.ToInt32(Id);
                    // 2. Indicamos que la operación fue exitosa
                    this.DialogResult = DialogResult.OK;
                    break;
                case "btnCambiar":
                    AppRepository obj = new AppRepository();
                    await obj.UpdateStatusArticle(Convert.ToInt32(Id));
                    BuscarArticulos();
                    break;
                case "btnStock":
                    Stock s = new Stock();
                    s.IdArticle = Convert.ToInt32(Id);
                    s.Nombre = dgvArticulos.Rows[e.RowIndex].Cells["Articulo"].Value.ToString();
                    s.ShowDialog();
                    BuscarArticulos();
                    break;
                case "btnProveedores":
                    PricesSuppliers pr = new PricesSuppliers();
                    pr.IdArticle = Convert.ToInt32(Id);
                    pr.ShowDialog();
                    BuscarArticulos();
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
                dgvArticulos.Columns.Add(btnAsignar);
                return;
            }
            DataGridViewButtonColumn btnEditar = new DataGridViewButtonColumn();
            btnEditar.Name = "btnEditar";
            btnEditar.HeaderText = "Acción";
            btnEditar.Text = "Editar";
            btnEditar.UseColumnTextForButtonValue = true;
            dgvArticulos.Columns.Add(btnEditar);
            DataGridViewButtonColumn btnCambiar = new DataGridViewButtonColumn();
            btnCambiar.Name = "btnCambiar";
            btnCambiar.HeaderText = "Acción";
            btnCambiar.Text = "Cambiar Estatus";
            btnCambiar.UseColumnTextForButtonValue = true;
            dgvArticulos.Columns.Add(btnCambiar);
            DataGridViewButtonColumn btnProveedores = new DataGridViewButtonColumn();
            btnProveedores.Name = "btnProveedores";
            btnProveedores.HeaderText = "Acción";
            btnProveedores.Text = "Proveedores";
            btnProveedores.UseColumnTextForButtonValue = true;
            dgvArticulos.Columns.Add(btnProveedores);
            DataGridViewButtonColumn btnStock = new DataGridViewButtonColumn();
            btnStock.Name = "btnStock";
            btnStock.HeaderText = "Acción";
            btnStock.Text = "Stock";
            btnStock.UseColumnTextForButtonValue = true;
            dgvArticulos.Columns.Add(btnStock);
        }

        private void Articles_Load(object sender, EventArgs e)
        {
            if (IsVenta || IsReceta)
            {
                btnNuevo.Visible = false;
            }
        }
    }
}
