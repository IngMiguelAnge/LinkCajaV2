using LinkCajaV2.Data;
using LinkCajaV2.Items;
using LinkCajaV2.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinkCajaV2.Catalogs
{
    public partial class Premios : Form
    {
        List<ListPrizesModel> lista;
        public Premios()
        {
            InitializeComponent();
        }
        private async void btnNuevo_Click(object sender, EventArgs e)
        {
            Articles article = new Articles();
            article.IsVenta = true;
            if (article.ShowDialog() == DialogResult.OK)
            {
                await AgregarArticulo(0, article.IdSeleccionado);
                await BuscarPremios();
            }   
        }
        public async Task AgregarArticulo(int id, int idarticle)
        {
            if (lista != null)
            {
                if (id == 0 && lista.Where(x => x.IdArticle == idarticle).Count() > 0)
                {
                    MessageBox.Show("Ya existe un premio con ese articulo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                var articuloExistente = lista.FirstOrDefault(x => x.IdArticle == idarticle);
                if (articuloExistente != null)
                {
                    // 3. Validamos si el Id es diferente (es decir, pertenece a OTRO registro)
                    if (articuloExistente.Id != id)
                    {
                        MessageBox.Show("Ya existe un premio con ese articulo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }

            AppRepository obj = new AppRepository();
            // Usamos await en lugar de .Result para evitar bloqueos
            var articulo = await obj.GetArticleActive(idarticle, string.Empty);

            if (articulo == null)
            {
                MessageBox.Show("Código no válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (articulo.Status == false)
            {
                MessageBox.Show("El artículo no está activo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var presentacion = await obj.GetPresentationbyId(articulo.IdPresentation);
            decimal cantidadEntrante = 0;
            Decimals d = new Decimals();
            d.Presentation = presentacion.Presentation;
            d.Nombre = presentacion.Name;
            presentacion.Decimals = presentacion.Decimals;
            if (d.ShowDialog() == DialogResult.OK) // Asumiendo que devuelve OK
            {
                cantidadEntrante = d.Kilos;
            }
            else
            {
                return; // Si el usuario cancela, no agregamos el artículo
            }

            PrizeModel p = new PrizeModel()
            {
                Id = id,
                IdArticle = idarticle,
                Stock = cantidadEntrante
            };
            bool result = obj.SavePrize(p).Result;
            if (result)
            {
                MessageBox.Show("Guardado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Error al guardar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            await BuscarPremios();
        }

        private void Premios_Load(object sender, EventArgs e)
        {

        }

        private async void dgvPremios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Evitar errores si hacen click en el encabezado
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            int Id = (int)dgvPremios.Rows[e.RowIndex].Cells["Id"].Value;

            switch (dgvPremios.Columns[e.ColumnIndex].Name)
            {
                case "btnEditar":
                    Articles article = new Articles();
                    article.IsVenta = true;
                    if (article.ShowDialog() == DialogResult.OK)
                    {
                        AgregarArticulo(Id, article.IdSeleccionado);
                    }
                    await BuscarPremios();
                    break;
                case "btnCambiar":
                    AppRepository obj = new AppRepository();
                    await obj.UpdateStatusPrize(Id);
                    await BuscarPremios();
                    break;
            }
        }
        private void AgregarBotones()
        {
            // 1. Limpieza de seguridad: si ya existen por una búsqueda previa, los borramos
            if (dgvPremios.Columns["btnEditar"] != null) dgvPremios.Columns.Remove("btnEditar");
            if (dgvPremios.Columns["btnCambiar"] != null) dgvPremios.Columns.Remove("btnCambiar");
            DataGridViewButtonColumn btnEditar = new DataGridViewButtonColumn();
            btnEditar.Name = "btnEditar";
            btnEditar.HeaderText = "Acción";
            btnEditar.Text = "Editar";
            btnEditar.UseColumnTextForButtonValue = true;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.DefaultCellStyle.BackColor = Color.FromArgb(240, 242, 245);
            btnEditar.DefaultCellStyle.ForeColor = Color.FromArgb(1, 110, 203);
            dgvPremios.Columns.Add(btnEditar);
            DataGridViewButtonColumn btnCambiar = new DataGridViewButtonColumn();
            btnCambiar.Name = "btnCambiar";
            btnCambiar.HeaderText = "Acción";
            btnCambiar.Text = "Cambiar Estatus";
            btnCambiar.UseColumnTextForButtonValue = true;
            btnCambiar.FlatStyle = FlatStyle.Flat;
            btnCambiar.DefaultCellStyle.BackColor = Color.FromArgb(240, 242, 245);
            btnCambiar.DefaultCellStyle.ForeColor = Color.FromArgb(1, 110, 203);
            dgvPremios.Columns.Add(btnCambiar);
        }
        private async void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Trim() == "")
            {
                DialogResult resultado = MessageBox.Show("Ha dejado el campo vacio, esto buscara a todos los articulos pero puede demorar ¿Quiere continuar?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.No)
                {
                    return;
                }
            }
            await BuscarPremios();
        }
        public async Task BuscarPremios()
        {
            progressBar1.Style = ProgressBarStyle.Marquee; // La barra empieza a moverse sola
            progressBar1.MarqueeAnimationSpeed = 30; // Velocidad de la animación
            btnNuevo.Enabled = false;
            BtnBuscar.Enabled = false;

            try
            {
                dgvPremios.DataSource = null;
                AppRepository obj = new AppRepository();
                lista = await Task.Run(() => obj.GetPrizes(0,txtNombre.Text));
                if (lista == null || lista.Count == 0)
                {
                    MessageBox.Show("No se encontraron premios.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    dgvPremios.DataSource = lista;
                    AgregarBotones();
                    if (dgvPremios.Columns["Id"] != null)
                    {
                        dgvPremios.Columns["Id"].Visible = false;
                    }
                    if (dgvPremios.Columns["IdArticle"] != null)
                    {
                        dgvPremios.Columns["IdArticle"].Visible = false;
                    }
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
            }
        }
    }
}
