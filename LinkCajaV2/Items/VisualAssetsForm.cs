using LinkCajaV2.Data;
using LinkCajaV2.Model;
using Svg;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LinkCajaV2.Items
{
    public partial class VisualAssetsForm : Form
    {
        private string rutaImagenSeleccionada = string.Empty;
        public VisualAssetsForm()
        {
            InitializeComponent();
        }

        private async void VisualAssetsForm_Load(object sender, EventArgs e)
        {
            cbTipoAsset.Items.Clear();
            cbTipoAsset.Items.Add("Ganador");
            cbTipoAsset.Items.Add("No Ganador");
            cbTipoAsset.SelectedIndex = 0;
            await CargarAssetSeleccionado();

        }

        private Image CargarImagenSinBloquear(string ruta)
        {
            using (FileStream fs = new FileStream(ruta, FileMode.Open,FileAccess.Read))
            {
                using (Image img = Image.FromStream(fs))
                {
                    return new Bitmap(img);
                }
            }
        }
        private async Task CargarAssetSeleccionado()
        {
            try
            {
                string assetKey = cbTipoAsset.SelectedIndex == 0? "GANADOR" : "NO_GANADOR";
                string imagenPredeterminada = assetKey == "GANADOR"? "Felicidades.png" : "Perdiste.png";
                AppRepository obj = new AppRepository();
                var lista = await obj.GetVisualAssets(assetKey);
                var asset = lista.FirstOrDefault();
                string rutaImagen = string.Empty;
                if (asset != null &&
                    !string.IsNullOrWhiteSpace(asset.FilePath))
                {
                    string rutaPersonalizada = Path.Combine(Application.StartupPath, asset.FilePath );
                    if (File.Exists(rutaPersonalizada))
                    {
                        rutaImagen = rutaPersonalizada;
                    }
                }

                // Si no hay personalizada usamos la predeterminada
                if (string.IsNullOrWhiteSpace(rutaImagen))
                {
                    rutaImagen = Path.Combine( Application.StartupPath,"Icons",imagenPredeterminada );
                }

                if (File.Exists(rutaImagen))
                {
                    if (pbPreview.Image != null)
                    {
                        pbPreview.Image.Dispose();
                        pbPreview.Image = null;
                    }

                    string extension = Path.GetExtension(rutaImagen).ToLower();

                    if (extension == ".svg")
                    {
                        pbPreview.Image = CargarSvgComoBitmap(rutaImagen);
                    }
                    else
                    {
                        pbPreview.Image = CargarImagenSinBloquear(rutaImagen);
                    }

                    pbPreview.SizeMode = PictureBoxSizeMode.Zoom;

                    lblInfo.Text =
                        asset != null && !string.IsNullOrWhiteSpace(asset.FileName)
                            ? asset.FileName
                            : imagenPredeterminada;
                }
                else
                {
                    pbPreview.Image = null;
                    lblInfo.Text = "Imagen no encontrada";
                }

                // Al cambiar de tipo todavía no hay una imagen nueva seleccionada
                rutaImagenSeleccionada = string.Empty;
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
        private string SeleccionarImagen()
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter ="Imágenes|*.png;*.jpg;*.jpeg;*.svg";

            ofd.Title ="Seleccionar imagen";

            if (ofd.ShowDialog() != DialogResult.OK)return string.Empty;

            FileInfo archivo = new FileInfo(ofd.FileName);
            // Máximo 2 MB
            long limiteBytes = 2 * 1024 * 1024;

            if (archivo.Length > limiteBytes)
            {
                MessageBox.Show(
                    "La imagen supera el tamaño máximo permitido de 2 MB.",
                    "Archivo demasiado grande",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return string.Empty;
            }

            return ofd.FileName;
        }

        private async Task<bool> GuardarAsset(string assetKey, string rutaSeleccionada)
        {
            if (string.IsNullOrWhiteSpace(rutaSeleccionada))
                return true;

            try
            {
                FileInfo archivo = new FileInfo(rutaSeleccionada);  
                long limiteBytes = 2 * 1024 * 1024;

                if (archivo.Length > limiteBytes)
                {
                    MessageBox.Show(
                        $"La imagen de {assetKey} supera el máximo permitido de 2 MB.",
                        "Archivo demasiado grande",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    return false;
                }

         
                string extension =
                    Path.GetExtension(rutaSeleccionada).ToLower();

                string[] extensionesPermitidas ={".png",".jpg", ".jpeg",".svg"};

                if (!extensionesPermitidas.Contains(extension))
                {
                    MessageBox.Show(
                        $"El formato {extension} no está permitido.",
                        "Formato no válido",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    return false;
                }

            
                int? width = null;
                int? height = null;

                if (extension == ".png" ||
                    extension == ".jpg" ||
                    extension == ".jpeg")
                {
                    using (Image img = Image.FromFile(rutaSeleccionada))
                    {
                        width = img.Width;
                        height = img.Height;
                    }
                }
                else if (extension == ".svg")
                {
                    SvgDocument documento =
                        SvgDocument.Open(rutaSeleccionada);

                    using (Bitmap bmp = documento.Draw())
                    {
                        width = bmp.Width;
                        height = bmp.Height;
                    }
                }

                int anchoRecomendado = 600;
                int altoRecomendado = 600;

                if (width.HasValue &&
                    height.HasValue &&
                    (width.Value != anchoRecomendado ||
                     height.Value != altoRecomendado))
                {
                    DialogResult respuesta = MessageBox.Show(
                        $"La imagen seleccionada tiene una resolución de " +
                        $"{width.Value} x {height.Value} px.\n\n" +
                        $"La resolución recomendada es " +
                        $"{anchoRecomendado} x {altoRecomendado} px.\n\n" +
                        "¿Desea continuar de todos modos?",
                        "Resolución recomendada",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning
                    );

                    if (respuesta == DialogResult.No)
                    {
                        return false;
                    }
                }
                string carpetaDestino = Path.Combine(
                    Application.StartupPath,
                    "Assets",
                    "Feedback"
                );

                Directory.CreateDirectory(carpetaDestino);
     
                string nombreBase =
                    assetKey == "GANADOR"
                        ? "Ganador"
                        : "NoGanador";

                string nombreArchivo =nombreBase + extension;
                string rutaDestino = Path.Combine(carpetaDestino, nombreArchivo );
              
                File.Copy(
                    rutaSeleccionada,
                    rutaDestino,
                    true
                );
   
                string rutaRelativa = Path.Combine(
                    "Assets",
                    "Feedback",
                    nombreArchivo
                );

          
                VisualAssetModel model =new VisualAssetModel
                    {
                        AssetKey = assetKey,
                        FilePath = rutaRelativa,
                        FileName = nombreArchivo,
                        Extension = extension,
                        FileSize = archivo.Length,
                        Width = width,
                        Height = height
                    };

            
                AppRepository obj =new AppRepository();
                return await obj.SaveVisualAsset(model);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Error al guardar la imagen de {assetKey}: " +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return false;
            }
        }

        private async void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(rutaImagenSeleccionada))
            {
                MessageBox.Show(
                    "Seleccione una imagen antes de guardar.",
                    "Información",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                return;
            }

            string assetKey = cbTipoAsset.SelectedIndex == 0? "GANADOR": "NO_GANADOR";
            bool resultado = await GuardarAsset(assetKey, rutaImagenSeleccionada);
            if (resultado)
            {
                MessageBox.Show(
                    "Imagen guardada correctamente.",
                    "Éxito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                rutaImagenSeleccionada = string.Empty;
                await CargarAssetSeleccionado();
            }
        }

        private async void cbTipoAsset_SelectedIndexChanged(object sender, EventArgs e)
        {
            await CargarAssetSeleccionado();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            string ruta = SeleccionarImagen();

            if (string.IsNullOrWhiteSpace(ruta))
                return;

            rutaImagenSeleccionada = ruta;

            string extension = Path.GetExtension(ruta).ToLower();

            if (pbPreview.Image != null)
            {
                pbPreview.Image.Dispose();
                pbPreview.Image = null;
            }

            if (extension == ".png" || extension == ".jpg" || extension == ".jpeg")
            {
                pbPreview.Image = CargarImagenSinBloquear(ruta);
                pbPreview.SizeMode = PictureBoxSizeMode.Zoom;

                using (Image img = Image.FromFile(ruta))
                {
                    lblInfo.Text = $"{Path.GetFileName(ruta)} - {img.Width}x{img.Height}px";
                }
            }
            else if (extension == ".svg")
            {
                SvgDocument documento = SvgDocument.Open(ruta);
                Bitmap bmp = documento.Draw();
                pbPreview.Image = bmp;
                pbPreview.SizeMode = PictureBoxSizeMode.Zoom;

                lblInfo.Text = $"{Path.GetFileName(ruta)} - {bmp.Width}x{bmp.Height}px";
            }
        }
        private Image CargarSvgComoBitmap(string ruta)
        {
            SvgDocument documento = SvgDocument.Open(ruta);

            return documento.Draw();
        }
    }
}
