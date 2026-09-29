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
using System.Management;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Svg;

namespace LinkCajaV2.Catalogs
{
    public partial class Box : System.Windows.Forms.Form
    {
        public int Id { get; set; }
        private string rutaGanadorSeleccionada = string.Empty;
        private string rutaNoGanadorSeleccionada = string.Empty;
        int CantidadCajas = 0;
        public Box()
        {
            InitializeComponent();
        }

        private void Box_Load(object sender, EventArgs e)
        {
            AppRepository obj = new AppRepository();
            cbTipoAsset.Items.Clear();
            cbTipoAsset.Items.Add("Seleccione");
            cbTipoAsset.Items.Add("Ganador");
            cbTipoAsset.Items.Add("No Ganador");
            cbTipoAsset.SelectedIndex = 0;
            gbImagenRuleta.Enabled = false;
            btnSeleccionar.Enabled = false;
            KeysModel ListKeys = obj.GetKeys().Result.FirstOrDefault();
            if (ListKeys == null)
            {
                MessageBox.Show("No se encontraron licencia activa. Contacta al soporte.", "Licencia no encontrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            CBRuleta.SelectedIndex = 0;
            EncrypDesencryp objEncryp = new EncrypDesencryp();
            string Key = objEncryp.Desencriptar(ListKeys.Key);
            string[] partes = Key.Split(new string[] { "Box", "box" }, StringSplitOptions.None);
            CantidadCajas = int.Parse(partes[1]);
            if (CantidadCajas > 1)
            {
                CBPublicidad.Enabled = true;
            }
            else CBPublicidad.SelectedIndex = 2;
            if (Id == 0)
            {
                HardwareID h = new HardwareID();
                txtHard.Text = h.ObtenerHardwareID();
                return;
            }

            var model = obj.GetBoxsbyId(Id).Result;
            if (model.Publicity == true)
                CBPublicidad.SelectedIndex = 2;
            else
                CBPublicidad.SelectedIndex = 1;
            txtHard.Text = model.HardwareID;
            txtNombre.Text = model.Name;
            if (model.Rulet == true)
                CBRuleta.SelectedIndex = 1;
            else
                CBRuleta.SelectedIndex = 2;
            nudCantidad.Value = model.Amount;

        }
        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (CBPublicidad.SelectedIndex == 0)
                {
                    MessageBox.Show("Se requiere información sobre la publicidad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (CBRuleta.SelectedIndex == 0)
                {
                    MessageBox.Show("Se requiere información sobre la ruleta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (CBRuleta.SelectedIndex == 1 && nudCantidad.Value <= 0)
                {
                    MessageBox.Show("Se requiere una cantidad minima, para la ruleta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                AppRepository obj = new AppRepository();
                BoxModel model = new BoxModel
                {
                    Id = this.Id,
                    HardwareID = txtHard.Text,
                    Name = txtNombre.Text,
                    Publicity = CBPublicidad.SelectedIndex == 1 ? false : true,
                    Rulet = CBRuleta.SelectedIndex == 1 ? true : false,
                    Amount = nudCantidad.Value
                };

                if (Id == 0)
                {
                    var exit = obj.GetBoxsbyHardwareID(txtHard.Text).Result;
                    if (exit == null)
                    {
                        int list = obj.GetBoxsActives().Result.Count();
                        if (list >= CantidadCajas)
                        {
                            MessageBox.Show("Has alcanzado el limite de cajas permitidas por tu licencia. Contacta al soporte para adquirir más cajas.", "Limite de cajas alcanzado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                    else
                    {
                        if (Id != exit.Id)
                        {
                            MessageBox.Show("Ya existe una caja registrada con este hardware ID. Verifica que no estés registrando la misma caja nuevamente.", "Caja duplicada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                }

                var res = await obj.SaveBox(model);

                if (res)
                {
                    // Guardar imagen de Ganador si fue modificada
                    if (!string.IsNullOrWhiteSpace(rutaGanadorSeleccionada))
                    {
                        bool ganadorGuardado =await GuardarAsset( "GANADOR", rutaGanadorSeleccionada);

                        if (!ganadorGuardado)
                        {
                            MessageBox.Show( "La caja fue guardada, pero no se pudo guardar la imagen de Ganador.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning );
                            return;
                        }
                    }

                    // Guardar imagen de No Ganador si fue modificada
                    if (!string.IsNullOrWhiteSpace(rutaNoGanadorSeleccionada))
                    {
                        bool noGanadorGuardado = await GuardarAsset( "NO_GANADOR",rutaNoGanadorSeleccionada );

                        if (!noGanadorGuardado)
                        {
                            MessageBox.Show(
                                "La caja fue guardada, pero no se pudo guardar la imagen de No Ganador.",
                                "Advertencia",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning
                            );
                            return;
                        }
                    }

                    MessageBox.Show( "Caja guardada correctamente.", "Éxito",  MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error al guardar la caja. Intenta nuevamente.", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se encontraron licencia activa. Contacta al soporte.", "Licencia no encontrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
        }

        private string SeleccionarImagen()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Imágenes|*.png;*.jpg;*.jpeg;*.svg";
            ofd.Title = "Seleccionar imagen";

            if (ofd.ShowDialog() != DialogResult.OK)
            return string.Empty;
            FileInfo archivo = new FileInfo(ofd.FileName);
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
        private Image CargarSvgComoBitmap(string ruta)
        {
            SvgDocument documento =
                SvgDocument.Open(ruta);

            return documento.Draw();
        }
        private void CBRuleta_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBRuleta.SelectedIndex == 1)
            {
                nudCantidad.Enabled = true;
                gbImagenRuleta.Enabled = true;
            }
            else
            {
                nudCantidad.Enabled = false;
                gbImagenRuleta.Enabled = false;

                cbTipoAsset.SelectedIndex = 0;

                if (pbPreview.Image != null)
                {
                    pbPreview.Image.Dispose();
                    pbPreview.Image = null;
                }

                lblInfo.Text = "Info Imagen";
                rutaGanadorSeleccionada = string.Empty;
                rutaNoGanadorSeleccionada = string.Empty;
            }
        }
        private async Task CargarAssetSeleccionado()
        {
            try
            {
                string assetKey = cbTipoAsset.SelectedIndex == 1 ? "GANADOR": "NO_GANADOR";
                string imagenPredeterminada = assetKey == "GANADOR" ? "Felicidades.png"  : "Perdiste.png";

                // Revisar primero si hay una imagen nueva
                // seleccionada durante esta sesión.
                string rutaTemporal = assetKey == "GANADOR" ? rutaGanadorSeleccionada: rutaNoGanadorSeleccionada;

                if (!string.IsNullOrWhiteSpace(rutaTemporal) &&
                    File.Exists(rutaTemporal))
                {
                    if (pbPreview.Image != null)
                    {
                        pbPreview.Image.Dispose();
                        pbPreview.Image = null;
                    }

                    string extension =
                        Path.GetExtension(rutaTemporal).ToLower();

                    if (extension == ".svg")
                    {
                        Bitmap bmp =(Bitmap)CargarSvgComoBitmap(rutaTemporal);
                        pbPreview.Image = bmp;
                        lblInfo.Text =$"{Path.GetFileName(rutaTemporal)} - " +   $"{bmp.Width}x{bmp.Height}px";
                    }
                    else
                    {
                        pbPreview.Image =CargarImagenSinBloquear(rutaTemporal);

                        using (Image img =Image.FromFile(rutaTemporal))
                        {
                            lblInfo.Text = $"{Path.GetFileName(rutaTemporal)} - " + $"{img.Width}x{img.Height}px";
                        }
                    }

                    pbPreview.SizeMode = PictureBoxSizeMode.Zoom;
                    return;
                }
                // Si no hay imagen nueva, cargar la guardada en BD.
                AppRepository obj = new AppRepository();

                var lista = await obj.GetVisualAssets(assetKey);

                var asset = lista.FirstOrDefault();

                string rutaImagen = string.Empty;

                if (asset != null && !string.IsNullOrWhiteSpace(asset.FilePath))
                {
                    string rutaPersonalizada = Path.Combine( Application.StartupPath, asset.FilePath );

                    if (File.Exists(rutaPersonalizada))
                    {
                        rutaImagen =
                            rutaPersonalizada;
                    }
                }

                // Si no hay personalizada, usar la predeterminada.
                if (string.IsNullOrWhiteSpace(rutaImagen))
                {
                    rutaImagen =
                        Path.Combine(
                            Application.StartupPath,
                            "Icons",
                            imagenPredeterminada
                        );
                }

                if (pbPreview.Image != null)
                {
                    pbPreview.Image.Dispose();
                    pbPreview.Image = null;
                }

                if (File.Exists(rutaImagen))
                {
                    string extension =
                        Path.GetExtension(rutaImagen).ToLower();

                    if (extension == ".svg")
                    {
                        pbPreview.Image =
                            CargarSvgComoBitmap(rutaImagen);
                    }
                    else
                    {
                        pbPreview.Image =CargarImagenSinBloquear(rutaImagen);
                    }

                    pbPreview.SizeMode = PictureBoxSizeMode.Zoom;

                    lblInfo.Text =
                        asset != null && !string.IsNullOrWhiteSpace(asset.FileName) ? asset.FileName: imagenPredeterminada; }
                else
                {
                    lblInfo.Text =
                        "Imagen no encontrada";
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
        private async void cbTipoAsset_SelectedIndexChanged( object sender,EventArgs e)
        {
            if (cbTipoAsset.SelectedIndex == 0)
            {
                btnSeleccionar.Enabled = false;
                if (pbPreview.Image != null)
                {
                    pbPreview.Image.Dispose();
                    pbPreview.Image = null;
                }
                lblInfo.Text = "Info Imagen";
                return;
            }
            btnSeleccionar.Enabled = true;
            await CargarAssetSeleccionado();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (cbTipoAsset.SelectedIndex == 0)
            {
                MessageBox.Show(
                    "Seleccione primero si la imagen es de Ganador o No Ganador.",
                    "Información",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                return;
            }

            string ruta = SeleccionarImagen();

            if (string.IsNullOrWhiteSpace(ruta))
                return;

            if (cbTipoAsset.SelectedIndex == 1)
            {
                rutaGanadorSeleccionada = ruta;
            }
            else if (cbTipoAsset.SelectedIndex == 2)
            {
                rutaNoGanadorSeleccionada = ruta;
            }
            string extension = Path.GetExtension(ruta).ToLower();
            if (pbPreview.Image != null)
            {
                pbPreview.Image.Dispose();
                pbPreview.Image = null;
            }

            if (extension == ".png" ||
                extension == ".jpg" ||
                extension == ".jpeg")
            {
                pbPreview.Image = CargarImagenSinBloquear(ruta);

                using (Image img = Image.FromFile(ruta))
                {
                    lblInfo.Text =$"{Path.GetFileName(ruta)} - {img.Width}x{img.Height}px";
                }
            }
            else if (extension == ".svg")
            {
                SvgDocument documento =SvgDocument.Open(ruta);
                Bitmap bmp = documento.Draw();
                pbPreview.Image = bmp;
                lblInfo.Text = $"{Path.GetFileName(ruta)} - {bmp.Width}x{bmp.Height}px";
            }

            pbPreview.SizeMode =
                PictureBoxSizeMode.Zoom;
        }
        private async Task<bool> GuardarAsset(
    string assetKey,
    string rutaSeleccionada)
        {
            if (string.IsNullOrWhiteSpace(rutaSeleccionada))
                return true;

            try
            {
                FileInfo archivo = new FileInfo(rutaSeleccionada);

                // Tamaño máximo: 2 MB
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

                // Extensión
                string extension =
                    Path.GetExtension(rutaSeleccionada).ToLower();

                string[] extensionesPermitidas =
                {
            ".png",
            ".jpg",
            ".jpeg",
            ".svg"
        };

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

                // Dimensiones
                int? width = null;
                int? height = null;

                if (extension == ".png" ||
                    extension == ".jpg" ||
                    extension == ".jpeg")
                {
                    using (Image img =
                           Image.FromFile(rutaSeleccionada))
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

                // Resolución recomendada
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
                        return false;
                }

                // Carpeta
                string carpetaDestino = Path.Combine(
                    Application.StartupPath,
                    "Assets",
                    "Feedback"
                );

                Directory.CreateDirectory(carpetaDestino);

                // Nombre controlado
                string nombreBase = assetKey == "GANADOR" ? "Ganador"  : "NoGanador";
                string nombreArchivo =nombreBase + extension;
                string rutaDestino = Path.Combine( carpetaDestino,nombreArchivo );
                // Copiar imagen
                File.Copy( rutaSeleccionada, rutaDestino,  true );
                // Ruta que irá a BD
                string rutaRelativa = Path.Combine(  "Assets", "Feedback", nombreArchivo );

                VisualAssetModel model =
                    new VisualAssetModel
                    {
                        AssetKey = assetKey,
                        FilePath = rutaRelativa,
                        FileName = nombreArchivo,
                        Extension = extension,
                        FileSize = archivo.Length,
                        Width = width,
                        Height = height
                    };

                AppRepository obj = new AppRepository();

                return await obj.SaveVisualAsset(model);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al guardar la imagen: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return false;
            }
        }
    }
}
