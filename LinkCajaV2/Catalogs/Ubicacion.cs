using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using ImageMagick;
using System;
using System.Net;
using System.Windows.Forms;


namespace LinkCajaV2.Catalogs
{
    public partial class Ubicacion : Form
    {
        public int IdCliente { get; set; }
        public string DireccionSeleccionada { get; set; }
        public string LatitudSeleccionada { get; set; }
        public string LongitudSeleccionada { get; set; }
        public decimal CostoSeleccionado { get; set; }

        GMapOverlay capaMarcadores;
        GMarkerGoogle marcador;

        public Ubicacion()
        {
            InitializeComponent();
        }

        private PointLatLng? BuscarEnOpenStreetMap(string direccion)
        {
            try
            {
                WebClient client = new WebClient();
                client.Encoding = System.Text.Encoding.UTF8;
                client.Headers.Add("user-agent", "LinkCajaV2/1.0 (admin@correo.com)");

                string url = $"https://nominatim.openstreetmap.org/search?format=json&q={Uri.EscapeDataString(direccion)}&limit=1";
                string json = client.DownloadString(url);

                if (json.Length < 10) return null;

                int latStart = json.IndexOf("\"lat\":\"") + 7;
                int latEnd = json.IndexOf("\"", latStart);
                string latStr = json.Substring(latStart, latEnd - latStart);

                int lonStart = json.IndexOf("\"lon\":\"") + 7;
                int lonEnd = json.IndexOf("\"", lonStart);
                string lonStr = json.Substring(lonStart, lonEnd - lonStart);

                double lat = double.Parse(latStr, System.Globalization.CultureInfo.InvariantCulture);
                double lon = double.Parse(lonStr, System.Globalization.CultureInfo.InvariantCulture);

                return new PointLatLng(lat, lon);
            }
            catch
            {
                return null;
            }
        }

        public void Ubicacion_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            //Coordenadas por defecto 

            double latitude = 18.68165869879;
            double longitude = -97.64837265014;

            GMap.NET.MapProviders.GMapProvider.UserAgent = "LinkCajaV2_v1.0";
            gMap.MapProvider = GMap.NET.MapProviders.OpenStreetMapProvider.Instance;

            cmbMapas.SelectedIndex = 3;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;

            gMap.Position = new PointLatLng(latitude, longitude);
            gMap.MinZoom = 2;
            gMap.MaxZoom = 20;
            gMap.Zoom = 18;

            gMap.DragButton = MouseButtons.Right;
            capaMarcadores = new GMapOverlay("capa1");
            gMap.Overlays.Add(capaMarcadores);

            marcador = new GMarkerGoogle(gMap.Position, GMarkerGoogleType.red_pushpin);
            marcador.IsVisible = true;
            capaMarcadores.Markers.Add(marcador);

            gMap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionWithoutCenter;
        }

        private void gMap_OnMarkerEnter(GMapMarker item)
        {
            marcador = (GMarkerGoogle)item;
        }

        public void gMap_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && marcador != null)
            {
                PointLatLng pos = gMap.FromLocalToLatLng(e.X, e.Y);
                marcador.Position = pos;

                txtLatitud.Text = pos.Lat.ToString();
                txtLongitud.Text = pos.Lng.ToString();
            }
        }

        public void BuscarPorDireccion(string direccionBuscada)
        {
            PointLatLng? pos = BuscarEnOpenStreetMap(direccionBuscada);

            if (pos.HasValue)
            {
                gMap.Position = pos.Value;
                if (marcador != null)
                {
                    marcador.Position = pos.Value;
                    Obtenerdireccion();
                }

                gMap.MinZoom = 2;
                gMap.MaxZoom = 20;
                gMap.Zoom = 18;

                txtLatitud.Text = pos.Value.Lat.ToString();
                txtLongitud.Text = pos.Value.Lng.ToString();
            }
            else
            {
                MessageBox.Show("No se encontró: '" + direccionBuscada + "'. Intenta ser más específico.", "Sin resultados");
            }
        }

        private void BuscarPorCoordenadas(decimal latitud, decimal longitud)
        {
            try
            {
                if (double.TryParse(txtLatitud.Text, out double lat) && double.TryParse(txtLongitud.Text, out double lng))
                {
                    PointLatLng pos = new PointLatLng(lat, lng);
                    gMap.Position = pos;

                    if (marcador != null)
                    {
                        marcador.Position = pos;
                        Obtenerdireccion();
                    }

                    gMap.MinZoom = 2;
                    gMap.MaxZoom = 20;
                    gMap.Zoom = 18;
                }
                else
                {
                    MessageBox.Show("Por favor, ingresa coordenadas numéricas válidas.", "Error de formato");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al posicionar las coordenadas: " + ex.Message);
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrWhiteSpace(txtDireccionProporcionada.Text) && CBCoordendadas.Checked == false) ||
       ((string.IsNullOrWhiteSpace(txtLatitud.Text) || string.IsNullOrWhiteSpace(txtLongitud.Text)) && CBCoordendadas.Checked == true))
            {
                MessageBox.Show("Por favor, ingresa una dirección o coordenadas para buscar.", "Datos insuficientes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            this.Cursor = Cursors.WaitCursor;
            BtnBuscar.Enabled = false;
            btnCancelarDireccion.Enabled = false;

            try
            {
                if (!string.IsNullOrWhiteSpace(txtDireccionProporcionada.Text) && CBCoordendadas.Checked == false)
                    BuscarPorDireccion(txtDireccionProporcionada.Text);

                if (!string.IsNullOrWhiteSpace(txtLatitud.Text) && !string.IsNullOrWhiteSpace(txtLongitud.Text) && CBCoordendadas.Checked == true)
                    BuscarPorCoordenadas(Convert.ToDecimal(txtLatitud.Text), Convert.ToDecimal(txtLongitud.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al buscar: " + ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
                BtnBuscar.Enabled = true;
                btnCancelarDireccion.Enabled = true;

            }
        }

        public void Obtenerdireccion()
        {
      
            string calleEncontrada = ObtenerCalleDesdeCoordenadas(marcador.Position.Lat, marcador.Position.Lng);

            txtDireccionProporcionada.Text = calleEncontrada;
        }

        private void gMap_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && marcador != null)
            {
                Obtenerdireccion();
            }
        }

        private string ObtenerCalleDesdeCoordenadas(double lat, double lon)
        {
            try
            {
                WebClient client = new WebClient();
                client.Encoding = System.Text.Encoding.UTF8;
                client.Headers.Add("user-agent", "LinkCajaV2/1.0");

                string url = string.Format(System.Globalization.CultureInfo.InvariantCulture,
                    "https://nominatim.openstreetmap.org/reverse?format=json&lat={0}&lon={1}&zoom=18&addressdetails=1", lat, lon);

                string json = client.DownloadString(url);

                if (json.Contains("\"display_name\":\""))
                {
                    int start = json.IndexOf("\"display_name\":\"") + 16;
                    int end = json.IndexOf("\"", start);
                    string direccionCompleta = json.Substring(start, end - start);

                    return System.Text.RegularExpressions.Regex.Unescape(direccionCompleta);
                }
                return "Dirección no encontrada";
            }
            catch
            {
                return "Error al obtener dirección";
            }
        }

        private void cmbMapas_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbMapas.Text)
            {
                case "Calles (Google)":
                    gMap.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
                    break;
                case "Satélite":
                    gMap.MapProvider = GMap.NET.MapProviders.GoogleSatelliteMapProvider.Instance;
                    break;
                case "Híbrido":
                    gMap.MapProvider = GMap.NET.MapProviders.GoogleHybridMapProvider.Instance;
                    break;
                case "OpenStreet":
                    GMap.NET.MapProviders.GMapProvider.UserAgent = "LinkCajaV2_v1.0";
                    gMap.MapProvider = GMap.NET.MapProviders.OpenStreetMapProvider.Instance;
                    break;
            }
        }

        private void btnAceptarUbicacion_Click(object sender, EventArgs e)
        {

            if (txtDireccionProporcionada.Text.Trim() == string.Empty)
            {
                MessageBox.Show("No hay una dirección sugerida para aceptar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (numCostoEnvio.Value <= 0)
            {
                MessageBox.Show("Debes ingresar un costo de viaje mayor a $0.", "Tarifa Obligatoria", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numCostoEnvio.Focus();
                return;
            }


            txtDireccionOficial.Text = txtDireccionProporcionada.Text;

            DireccionSeleccionada = txtDireccionOficial.Text.Trim();
            LatitudSeleccionada = txtLatitud.Text.Trim();
            LongitudSeleccionada = txtLongitud.Text.Trim();
            CostoSeleccionado = numCostoEnvio.Value; 

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancelarDireccion_Click(object sender, EventArgs e)
        {
            txtDireccionProporcionada.Enabled = true;
            txtLatitud.Enabled = true;
            txtLongitud.Enabled = true;

        }

   
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            // Valido la tarifa 
            if (numCostoEnvio.Value <= 0)
            {
                MessageBox.Show("Debes ingresar una tarifa mayor a $0.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numCostoEnvio.Focus();
                return;
            }

           
            DireccionSeleccionada = txtDireccionProporcionada.Text.Trim();
            LatitudSeleccionada = txtLatitud.Text.Trim();
            LongitudSeleccionada = txtLongitud.Text.Trim();
            CostoSeleccionado = numCostoEnvio.Value;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void CBCoordendadas_CheckedChanged(object sender, EventArgs e)
        {
            
            if (CBCoordendadas.Checked)
            {
                txtLatitud.Enabled = true;
                txtLongitud.Enabled = true;
                txtDireccionProporcionada.Enabled = false;
            }
            else
            {
                
                txtLatitud.Enabled = false;
                txtLongitud.Enabled = false;
                txtDireccionProporcionada.Enabled = true;
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            txtDireccionProporcionada.Clear();
            txtDireccionOficial.Clear();
            txtLatitud.Clear();
            txtLongitud.Clear();

          
            txtDireccionProporcionada.Enabled = true;
            BtnBuscar.Enabled = true;
            BtnGuardar.Enabled = false;
       

        }

        private void btnConfirmarDireccion_Click(object sender, EventArgs e)
        {
            txtDireccionProporcionada.Enabled = false;
            txtLatitud.Enabled = false;
            txtLongitud.Enabled = false;
        }
    }
}