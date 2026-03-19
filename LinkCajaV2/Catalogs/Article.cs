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
            ArticleModel Articulo = new ArticleModel()
            {
                Id = Id,
                Name = txtNombre.Text,
                Description = txtDescripcion.Text,
                Image = PBProducto.Image != null ? ImageToByteArray() : null
            };
            AppRepository obj = new AppRepository();
            if (obj.SaveArticle(Articulo).Result)
                MessageBox.Show("Guardado satisfactoriamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (Id == 0) return;

        }
    }
}
