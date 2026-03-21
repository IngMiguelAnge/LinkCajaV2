using LinkCajaV2.Data;
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
    public partial class Article : Form
    {
        public int Id { get; set; }
        public Article()
        {
            InitializeComponent();
        }

        private void btnImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog selector = new OpenFileDialog();
            selector.Filter = "Imagenes|*.jpg;*.jpeg;*.png;*.bmp";

            if (selector.ShowDialog() == DialogResult.OK)
            {
                PBProducto.Image = Image.FromFile(selector.FileName);
                // Ajustamos la imagen al tamaño del PictureBox
                PBProducto.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCodigo.Text) || string.IsNullOrEmpty(txtDescripcion.Text) ||
                string.IsNullOrEmpty(txtNombre.Text) || (int)cbPresentacion.SelectedValue == 0 ||
                (int)cbPresentacionS.SelectedValue == 0)
            {
                MessageBox.Show("Datos incompletos revise la información", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ArticleModel Articulo = new ArticleModel()
            {
                Id = Id,
                Name = txtNombre.Text,
                Description = txtDescripcion.Text,
                Image = PBProducto.Image != null ? ImageToByteArray() : null
            };
            AppRepository obj = new AppRepository();
            if (obj.SaveArticle(Articulo).Result)
            {
                MessageBox.Show("Articulo guardado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
                MessageBox.Show("Erro al guardar la información", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        public byte[] ImageToByteArray()
        {
            using (MemoryStream ms = new MemoryStream())
            {
                // Guardamos la imagen del PictureBox en el MemoryStream
                PBProducto.Image.Save(ms, PBProducto.Image.RawFormat);

                // Retornamos el arreglo de bytes
                return ms.ToArray();
            }
        }

        private void Article_Load(object sender, EventArgs e)
        {
            AppRepository obj = new AppRepository();
            var ListPresentation = obj.GetPresentations().Result;
            // Insertamos un objeto "fantasma" al inicio para el placeholder
            ListPresentation.Insert(0, new ListPresentationsModel { Id = 0, Name = "Seleccione" });

            // Configuramos el ComboBox
            cbPresentacion.DisplayMember = "Name";
            cbPresentacion.ValueMember = "Id";
            cbPresentacion.DataSource = ListPresentation;
            cbPresentacion.SelectedIndex = 0;
            if (Id == 0) return;
            var Article = obj.GetArticlebyId(Id).Result;
            txtNombre.Text = Article.Name;
            txtDescripcion.Text = Article.Description;
            if (Article.Image != null)
            {
                using (MemoryStream ms = new MemoryStream(Article.Image))
                {
                    PBProducto.Image = Image.FromStream(ms);
                    PBProducto.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
            txtCodigo.Text = Article.Code;
            cbPresentacion.SelectedValue = Article.IdPresentation;
            nudExistencias.Value = Article.Stock;
            nudPrecio.Value = Article.Price;
            nudCada.Value = Article.SuggestedStock;
            CambiarPresentacion2();
            cbPresentacionS.SelectedValue = Article.SuggestedPresentation;
        }

        private void cbPresentacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            CambiarPresentacion2();
        }
        public void CambiarPresentacion2()
        {
            List<ListPresentationsModel> ListPresentation = new List<ListPresentationsModel>();
            ListPresentation.Insert(0, new ListPresentationsModel { Id = 0, Name = "Seleccione" });
            if (cbPresentacion.SelectedIndex > 0)
            {
                var Id = (int)cbPresentacion.SelectedValue;
                switch (cbPresentacion.Text.ToUpper())
                {
                    case "KG":
                    case "GR":
                        ListPresentation.Insert(1, new ListPresentationsModel { Id = 1, Name = "Kg" });
                        ListPresentation.Insert(2, new ListPresentationsModel { Id = 2, Name = "gr" });
                        nudExistencias.DecimalPlaces = 3;
                        nudExistencias.Increment = 0.001M;
                        nudCada.DecimalPlaces = 3;
                        nudCada.Increment = 0.001M;
                        break;
                    case "LT":
                    case "ML":
                        ListPresentation.Insert(1, new ListPresentationsModel { Id = 3, Name = "Lt" });
                        ListPresentation.Insert(2, new ListPresentationsModel { Id = 4, Name = "ml" });
                        nudExistencias.DecimalPlaces = 3;
                        nudExistencias.Increment = 0.001M;
                        nudCada.DecimalPlaces = 3;
                        nudCada.Increment = 0.001M;
                        break;
                    default:
                        ListPresentation.Insert(1, new ListPresentationsModel { Id = Id, Name = cbPresentacion.Text });
                        nudExistencias.DecimalPlaces = 0;
                        nudExistencias.Increment = 1M;
                        nudCada.DecimalPlaces = 0;
                        nudCada.Increment = 1M;
                        break;
                }
            }

            cbPresentacionS.DisplayMember = "Name";
            cbPresentacionS.ValueMember = "Id";
            cbPresentacionS.DataSource = ListPresentation;
            cbPresentacionS.SelectedIndex = 0;
        }
    }
}
