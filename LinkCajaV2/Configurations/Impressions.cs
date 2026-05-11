using LinkCajaV2.Catalogs;
using LinkCajaV2.Data;
using LinkCajaV2.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinkCajaV2.Configurations
{
    public partial class Impressions : Form
    {
        List<ListConfigImpressionsModel> ConfigImpressions;
        public Impressions()
        {
            InitializeComponent();
        }
        public void Iniciar()
        {
            CBPagina.Items.Add("Seleccione");
            CBPagina.Items.Add("A4");
            CBPagina.Items.Add("mm");
            CBPagina.SelectedIndex = 0;

            CBModificar.Items.Add("Seleccione");
            CBModificar.Items.Add("Titulo");
            CBModificar.Items.Add("Fecha");
            CBModificar.Items.Add("Articulos");
            CBModificar.Items.Add("Precios");
            CBModificar.Items.Add("Recuadro");
            CBModificar.SelectedIndex = 0;

            CBEstilo.Items.Add("Seleccione");
            CBEstilo.Items.Add("Normal");
            CBEstilo.Items.Add("Medium");
            CBEstilo.Items.Add("SemiBold");
            CBEstilo.Items.Add("Bold");
            CBEstilo.SelectedIndex = 0;

            List<OpcionComboModel> listaColores = new List<OpcionComboModel>();
            listaColores.Add(new OpcionComboModel() { Texto = "Seleccione", Valor = "0" });
            listaColores.Add(new OpcionComboModel() { Texto = "Negro", Valor = "Black" });
            listaColores.Add(new OpcionComboModel() { Texto = "Rojo", Valor = "Red" });
            listaColores.Add(new OpcionComboModel() { Texto = "Azul", Valor = "Blue" });
            listaColores.Add(new OpcionComboModel() { Texto = "Verde", Valor = "Green" });

            // Configuramos el ComboBox
            CBColorLetra.DisplayMember = "Texto";
            CBColorLetra.ValueMember = "Valor";
            CBColorLetra.DataSource = listaColores;
            CBColorLetra.SelectedIndex = 0;

            List<OpcionComboModel> listaDirecciones = new List<OpcionComboModel>();
            listaDirecciones.Add(new OpcionComboModel() { Texto = "Seleccione", Valor = "0" });
            listaDirecciones.Add(new OpcionComboModel() { Texto = "Izquierda", Valor = "AlignLeft" });
            listaDirecciones.Add(new OpcionComboModel() { Texto = "Centro", Valor = "AlignCenter" });
            listaDirecciones.Add(new OpcionComboModel() { Texto = "Derecha", Valor = "AlignRight" });


            CBAlineacion.DisplayMember = "Texto";
            CBAlineacion.ValueMember = "Valor";
            CBAlineacion.DataSource = listaDirecciones;
            CBAlineacion.SelectedIndex = 0;

            CBColorLinea.DisplayMember = "Texto";
            CBColorLinea.ValueMember = "Valor";
            CBColorLinea.DataSource = listaColores;
            CBColorLinea.SelectedIndex = 0;
        }
        private void Impressions_Load(object sender, EventArgs e)
        {
            CBImpresiones.Items.Add("Seleccione");
            CBImpresiones.Items.Add("Lista de precios");
            CBImpresiones.SelectedIndex = 0;
        }

        private void CBPagina_SelectedIndexChanged(object sender, EventArgs e)
        {
            GBMPagina.Visible = false;
            if (CBPagina.Text == "mm")
            {
                GBMPagina.Visible = true;
            }
        }

        private void CBModificar_SelectedIndexChanged(object sender, EventArgs e)
        {
            GBCuadros.Visible = false;
            GBLetras.Visible = false;
            GBLinea.Visible = false;
            int Fontsize = 16;
            string Color = "Black";
            string FontStyle = "SemiBold";

            if (CBModificar.Text == "Titulo" ||
               CBModificar.Text == "Fecha" ||
               CBModificar.Text == "Articulos" ||
               CBModificar.Text == "Precios")
            {
                GBLetras.Visible = true;
                Fontsize = ConfigImpressions.Find(x => x.Name == "Titulo") != null ? Convert.ToInt32(ConfigImpressions.Find(x => x.Name == "Titulo").FontSize) : 16;
                NUDSizeLetra.Value = Fontsize;
                Color = ConfigImpressions.Find(x => x.Name == "Titulo") != null ? ConfigImpressions.Find(x => x.Name == "Titulo").FontColor : "Black";
                CBColorLetra.SelectedValue = Color;
                FontStyle = ConfigImpressions.Find(x => x.Name == "Titulo") != null ? ConfigImpressions.Find(x => x.Name == "Titulo").FontStyle : "SemiBold";
                CBEstilo.SelectedItem = FontStyle;
            }
            if (CBModificar.Text == "Recuadro")
            {
                GBCuadros.Visible = true;
                GBLinea.Visible = true;
            }
        }

        private void CBImpresiones_SelectedIndexChanged(object sender, EventArgs e)
        {
            CBModificar.Items.Clear();
            CBModificar.Text = string.Empty;
            CBPagina.Items.Clear();
            CBPagina.Text = string.Empty;
            CBEstilo.Items.Clear();
            CBEstilo.Text = string.Empty;
            CBColorLetra.DataSource = null;
            CBColorLetra.Items.Clear();
            CBAlineacion.DataSource = null;
            CBAlineacion.Items.Clear();
            CBColorLinea.DataSource = null;
            CBColorLinea.Items.Clear();

            if (CBImpresiones.Text == "Lista de precios")
            {
                Iniciar();
                AppRepository obj = new AppRepository();
                ConfigPageModel ConfigBox = obj.GetConfigBox().Result;
                CBColorLinea.SelectedValue = ConfigBox.ColorLine;
                CBAlineacion.SelectedValue = ConfigBox.Align;
                NUDEspacio.Value = ConfigBox.Spacing;
                NUDHightLine.Value = ConfigBox.HightLine;
                NUDAncho.Value = ConfigBox.Width;
                NUDALMilimetros.Value = ConfigBox.HightPage;
                CBPagina.SelectedItem = ConfigBox.Page;
                NUDAMilimetros.Value = ConfigBox.WidthPage;
                ConfigImpressions = obj.GetConfigImpressions().Result;
            }
            else
            {
                GBCuadros.Visible = false;
                GBLetras.Visible = false;
                GBLinea.Visible = false;
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            List<PrinterPricesModel> articulos = new List<PrinterPricesModel>();
            articulos.Add(new PrinterPricesModel() { Articulo = "Coca Cola", Precio = 15.50m });
            articulos.Add(new PrinterPricesModel() { Articulo = "Pepsi", Precio = 14.00m });
            articulos.Add(new PrinterPricesModel() { Articulo = "Fanta", Precio = 13.75m });
            articulos.Add(new PrinterPricesModel() { Articulo = "Sprite", Precio = 12.25m });
            articulos.Add(new PrinterPricesModel() { Articulo = "Agua", Precio = 10.00m });
            articulos.Add(new PrinterPricesModel() { Articulo = "Jugo", Precio = 18.00m });
            articulos.Add(new PrinterPricesModel() { Articulo = "Cerveza", Precio = 20.00m });
            articulos.Add(new PrinterPricesModel() { Articulo = "Vino", Precio = 50.00m });
            articulos.Add(new PrinterPricesModel() { Articulo = "Whisky", Precio = 100.00m });
            articulos.Add(new PrinterPricesModel() { Articulo = "Ron", Precio = 80.00m });
            ImpressionsGeneral im = new ImpressionsGeneral();
            im.ImpresionPrecios(articulos);
        }

        private async void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (CBImpresiones.Text == "Seleccione")
            {
                MessageBox.Show("Seleccione una impresión", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (CBPagina.Text == "Seleccione")
            {
                MessageBox.Show("Seleccione un tamaño de página", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (CBPagina.Text == "mm")
            {
                if (NUDALMilimetros.Value <= 0 || NUDAMilimetros.Value <= 0)
                {
                    MessageBox.Show("Ingrese un valor válido para el tamaño de página en milímetros", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            ImpressionsModel objImpresion = new ImpressionsModel()
            {
                Name = CBImpresiones.Text,
                Page = CBPagina.Text,
                WidthPage = CBPagina.Text == "mm" ? NUDAMilimetros.Value : 0,
                HightPage = CBPagina.Text == "mm" ? NUDALMilimetros.Value : 0
            };
            AppRepository obj = new AppRepository();
            if (obj.SaveImpressions(objImpresion).Result == false)
            {
                MessageBox.Show("Error al guardar la configuración de página", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            switch(CBModificar.Text)
            {
                case "Recuadro":
                 ConfigBoxModel objBox = new ConfigBoxModel()
                        {
                        Name = "BoxPrecios",
                        Spacing = Convert.ToInt32(NUDEspacio.Value),
                        Align = CBAlineacion.SelectedValue.ToString(),
                        Width = Convert.ToInt32(NUDAncho.Value),
                        HightLine = NUDHightLine.Value,
                        ColorLine = CBColorLinea.SelectedValue.ToString()
                    };
                    await obj.SaveConfigBox(objBox);
                    break;
               
            }
        }
    }
}
