using ImageMagick;
using LinkCajaV2.Data;
using LinkCajaV2.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
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
            selector.Filter = "Imagenes|*.jpg;*.jpeg;*.png;*.bmp;*.webp";

            if (selector.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // 1. Usamos MagickImage para leer el archivo (aunque sea WebP con extensión .jpg)
                    using (MagickImage image = new MagickImage(selector.FileName))
                    {
                        // 2. Definimos explícitamente el formato a Bmp para asegurar compatibilidad
                        image.Format = MagickFormat.Bmp;

                        // 3. Obtenemos los bytes de la imagen convertida
                        byte[] bytes = image.ToByteArray();

                        using (MemoryStream ms = new MemoryStream(bytes))
                        {
                            // 4. CREAR UN NUEVO BITMAP: Esto es vital. 
                            // Al hacer 'new Bitmap(ms)', el PictureBox ya no depende del stream.
                            Bitmap bmp = new Bitmap(ms);

                            // 5. Limpieza de memoria de la imagen anterior
                            if (PBProducto.Image != null)
                            {
                                PBProducto.Image.Dispose();
                            }

                            // 6. Asignamos la nueva imagen y refrescamos
                            PBProducto.Image = bmp;
                            PBProducto.SizeMode = PictureBoxSizeMode.Zoom;
                            PBProducto.Refresh(); // Forzamos al control a redibujarse
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error visualizando la imagen: " + ex.Message);
                }
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCodigo.Text) || string.IsNullOrEmpty(txtDescripcion.Text) ||
                string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("Datos incompletos revise la información", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            AppRepository obj = new AppRepository();

            var exist = obj.GetArticle(0,txtCodigo.Text).Result;
            if (exist != null && exist.Id != Id)
            {
                MessageBox.Show("Ya se encuentra el codigo en uso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ArticleModel Articulo = new ArticleModel()
            {
                Id = Id,
                Name = txtNombre.Text,
                Description = txtDescripcion.Text,
                Image = PBProducto.Image != null ? ImageToByteArray() : null,
                Code = txtCodigo.Text,
            };
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
            if (PBProducto.Image == null) return null;

            // Creamos una copia de la imagen para evitar bloqueos de GDI+
            using (Bitmap tempImage = new Bitmap(PBProducto.Image))
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    // Forzamos el guardado en un formato específico (ej. Png o Jpeg)
                    // Esto es mucho más seguro que usar RawFormat
                    tempImage.Save(ms, System.Drawing.Imaging.ImageFormat.Png);

                    return ms.ToArray();
                }
            }
        }
        private void Article_Load(object sender, EventArgs e)
        {
            AppRepository obj = new AppRepository();
            if (Id == 0) return; 
            var Article = obj.GetArticle(Id,string.Empty).Result;
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
        }      
    }
}
