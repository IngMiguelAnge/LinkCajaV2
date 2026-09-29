using LinkCajaV2.Data;
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
using Svg;

namespace LinkCajaV2.Items
{
    public partial class Resultado : Form
    {
        public string Premio {  get; set; }
        public Resultado()
        {
            InitializeComponent();
        }

        private async void Resultado_Load(object sender, EventArgs e)
        {
            try
            {
                string assetKey;
                string imagenPredeterminada;

                if (Premio != "Sin premio")
                {
                    assetKey = "GANADOR";
                    imagenPredeterminada = "Felicidades.png";
                    txtDescripcion.Text ="Felicidades a ganado: " + Premio;
                }
                else
                {
                    assetKey = "NO_GANADOR";
                    imagenPredeterminada = "Perdiste.png";
                    txtDescripcion.Text ="Suerte para la proxima";
                }

                AppRepository obj = new AppRepository();

                var lista = await obj.GetVisualAssets(assetKey);
                var asset = lista.FirstOrDefault();
                string rutaImagen = string.Empty;

                if (asset != null &&
                    !string.IsNullOrWhiteSpace(asset.FilePath))
                {
                    string rutaPersonalizada = Path.Combine(Application.StartupPath, asset.FilePath);

                    if (File.Exists(rutaPersonalizada))
                    {
                        rutaImagen = rutaPersonalizada;
                    }
                }
                if (string.IsNullOrWhiteSpace(rutaImagen))
                {
                    rutaImagen = Path.Combine(
                        Application.StartupPath,
                        "Icons",
                        imagenPredeterminada
                    );
                }
   
                if (File.Exists(rutaImagen))
                {
                    if (pictureBox1.Image != null)
                    {
                        pictureBox1.Image.Dispose();
                        pictureBox1.Image = null;
                    }

                    string extension =Path.GetExtension(rutaImagen).ToLower();

                    if (extension == ".svg")
                    {
                        pictureBox1.Image = CargarSvgComoBitmap(rutaImagen);
                    }
                    else
                    {
                        pictureBox1.Image =CargarImagenSinBloquear(rutaImagen);
                    }

                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                }
                else
                {
                    MessageBox.Show(
                        "No se encontró la imagen en: " + rutaImagen,
                        "Error de ruta",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar la imagen: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private Image CargarSvgComoBitmap(string ruta)
        {
            SvgDocument documento = SvgDocument.Open(ruta);

            return documento.Draw();
        }
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private Image CargarImagenSinBloquear(string ruta)
        {
            using (FileStream fs = new FileStream(ruta, FileMode.Open, FileAccess.Read))
            {
                using (Image img = Image.FromStream(fs))
                {
                    return new Bitmap(img);
                }
            }
        }
    }
}
