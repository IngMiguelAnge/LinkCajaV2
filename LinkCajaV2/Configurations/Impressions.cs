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
    public partial class Impressions : System.Windows.Forms.Form
    {
        List<ListConfigImpressionsModel> ConfigImpressions;

        public Impressions()
        {
            InitializeComponent();
        }

        public void Iniciar()
        {
            CBModificar.Items.Add("Seleccione");
            CBModificar.Items.Add("Titulo");
            CBModificar.Items.Add("Fecha");

            if (CBImpresiones.Text != "Ticket")
            {
                CBModificar.Items.Add("Articulos");
                CBModificar.Items.Add("Precios");
                if (CBImpresiones.Text != "Lista de precios")
                    CBModificar.Items.Add("Recuadro");
            }
            else
            {
                CBModificar.Items.Add("Nombre de empresa");
                CBModificar.Items.Add("RFC");
                CBModificar.Items.Add("Tabla");
                CBModificar.Items.Add("Total");
            }
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

            CBColorLetra.DisplayMember = "Texto";
            CBColorLetra.ValueMember = "Valor";
            CBColorLetra.DataSource = listaColores;
            CBColorLetra.SelectedIndex = 0;

            if (CBImpresiones.Text != "Ticket")
            {
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
        }

        private void Impressions_Load(object sender, EventArgs e)
        {
            cbTicketAutomatico.Visible = true;//check box visible
            CBImpresiones.Items.Add("Seleccione");
            CBImpresiones.Items.Add("Lista de precios");
            CBImpresiones.Items.Add("Ticket");
            CBImpresiones.Items.Add("Etiquetas");
            CBImpresiones.SelectedIndex = 0;
        }

        // lo deje vacio por si truena 
        private void CBPagina_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void CBModificar_SelectedIndexChanged(object sender, EventArgs e)
        {
            GBCuadros.Visible = false;
            GBLetras.Visible = false;
            GBLinea.Visible = false;
            GBUnidos.Visible = false;
            lblPosicion.Visible = false;
            cbPosicionPrecio.Visible = false;

            string Color = "Black";
            string FontStyle = "SemiBold";

            if (CBModificar.Text != "Seleccione" &&
               CBModificar.Text != "Recuadro" &&
               CBModificar.Text != string.Empty)
            {
                GBUnidos.Visible = true;
                GBLetras.Visible = true;
                int Fontsize = ConfigImpressions.Find(x => x.Name == CBModificar.Text) != null ? Convert.ToInt32(ConfigImpressions.Find(x => x.Name == CBModificar.Text).FontSize) : 16;
                NUDSizeLetra.Value = Fontsize;
                int Caracteres = ConfigImpressions.Find(x => x.Name == CBModificar.Text) != null ? Convert.ToInt32(ConfigImpressions.Find(x => x.Name == CBModificar.Text).Caracters) : 500;
                nudCaracteres.Value = Caracteres;
                Color = ConfigImpressions.Find(x => x.Name == CBModificar.Text) != null ? ConfigImpressions.Find(x => x.Name == CBModificar.Text).FontColor : "Black";
                CBColorLetra.SelectedValue = Color;
                FontStyle = ConfigImpressions.Find(x => x.Name == CBModificar.Text) != null ? ConfigImpressions.Find(x => x.Name == CBModificar.Text).FontStyle : "SemiBold";
                CBEstilo.SelectedItem = FontStyle;
                if (CBModificar.Text == "Articulos" && CBImpresiones.Text == "Etiquetas")
                {
                    lblCaracteres.Visible = true;
                    nudCaracteres.Visible = true;
                }
                else
                {
                    lblCaracteres.Visible = false;
                    nudCaracteres.Visible = false;
                }
            }
            if (CBModificar.Text == "Precios" && CBImpresiones.Text == "Etiquetas")
            {
                lblPosicion.Visible = true;
                cbPosicionPrecio.Visible = true;
            }
        }

        private void CBImpresiones_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbTicketAutomatico.Visible = true;
            lblPosicion.Visible = false;
            cbPosicionPrecio.Visible = false;
            GBMPagina.Visible = false;

            CBModificar.Items.Clear();
            CBModificar.Text = string.Empty;
            CBEstilo.Items.Clear();
            CBEstilo.Text = string.Empty;
            CBColorLetra.DataSource = null;
            CBColorLetra.Items.Clear();
            CBAlineacion.DataSource = null;
            CBAlineacion.Items.Clear();
            CBColorLinea.DataSource = null;
            CBColorLinea.Items.Clear();

            switch (CBImpresiones.Text)
            {
                case "Lista de precios":
                    Iniciar();
                    AppRepository obj = new AppRepository();
                    ConfigPageModel ConfigBox = obj.GetConfigBox().Result;
                    CBColorLinea.SelectedValue = ConfigBox.ColorLine;
                    CBAlineacion.SelectedValue = ConfigBox.Align;
                    NUDEspacio.Value = ConfigBox.Spacing;
                    NUDHightLine.Value = ConfigBox.HightLine;
                    NUDAncho.Value = ConfigBox.Width;
                    NUDALMilimetros.Value = ConfigBox.HightPage;
                    NUDAMilimetros.Value = ConfigBox.WidthPage;
                    ConfigImpressions = obj.GetConfigImpressions("Lista de precios").Result;
                    break;

                case "Ticket":
                    MessageBox.Show("Esta opción requerira de una impresora POS como predeterminada.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Iniciar();
                    cbTicketAutomatico.Visible = true;
                    AppRepository obj2 = new AppRepository();
                    ConfigPageModel ConfigPage = obj2.GetConfigPage().Result;
                    NUDALMilimetros.Value = ConfigPage.HightPage;
                    NUDAMilimetros.Value = ConfigPage.WidthPage;
                    cbTicketAutomatico.Checked = ConfigPage.TicketAutomatico;
                    ConfigImpressions = obj2.GetConfigImpressions("Ticket").Result;
                 

                    GBMPagina.Visible = true; 
                    break;

                case "Etiquetas":
                    Iniciar();
                    AppRepository obj3 = new AppRepository();
                    ConfigPageModel ConfigBox2 = obj3.GetConfigBox().Result;
                    CBColorLinea.SelectedValue = ConfigBox2.ColorLine;
                    CBAlineacion.SelectedValue = ConfigBox2.Align;
                    NUDEspacio.Value = ConfigBox2.Spacing;
                    NUDHightLine.Value = ConfigBox2.HightLine;
                    NUDAncho.Value = ConfigBox2.Width;
                    NUDALMilimetros.Value = ConfigBox2.HightPage;
                    NUDAMilimetros.Value = ConfigBox2.WidthPage;
                    ConfigImpressions = obj3.GetConfigImpressions("Etiquetas").Result;

                    if (cbPosicionPrecio.Items.Count > 0)
                    {
                        cbPosicionPrecio.Text = ConfigBox2.Abajo ? "Abajo" : "Arriba";
                    }
                    GBMPagina.Visible = true;
                    break;

                default:
                    GBCuadros.Visible = false;
                    GBLetras.Visible = false;
                    GBLinea.Visible = false;
                    cbTicketAutomatico.Visible = false;
                    break;
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (CBImpresiones.Text == "Seleccione")
            {
                MessageBox.Show("Seleccione una impresión", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (CBImpresiones.Text == "Lista de precios" || CBImpresiones.Text == "Etiquetas")
            {
                List<PrinterPricesModel> articulos = new List<PrinterPricesModel>();
                articulos.Add(new PrinterPricesModel() { Articulo = "Coca Cola", Categoria = "Bebidas", Precio = 15.50m });
                articulos.Add(new PrinterPricesModel() { Articulo = "Pepsi", Categoria = "Bebidas", Precio = 14.00m });
                articulos.Add(new PrinterPricesModel() { Articulo = "Fanta", Categoria = "Bebidas", Precio = 13.75m });
                articulos.Add(new PrinterPricesModel() { Articulo = "Sprite", Categoria = "Bebidas", Precio = 12.25m });
                articulos.Add(new PrinterPricesModel() { Articulo = "Agua", Categoria = "Bebidas", Precio = 10.00m });
                articulos.Add(new PrinterPricesModel() { Articulo = "Jugo", Categoria = "Bebidas", Precio = 18.00m });
                articulos.Add(new PrinterPricesModel() { Articulo = "Cerveza", Categoria = "Bebidas", Precio = 20.00m });
                articulos.Add(new PrinterPricesModel() { Articulo = "Vino", Categoria = "Bebidas", Precio = 50.00m });
                articulos.Add(new PrinterPricesModel() { Articulo = "Whisky", Categoria = "Bebidas", Precio = 100.00m });
                articulos.Add(new PrinterPricesModel() { Articulo = "Ron", Categoria = "Bebidas", Precio = 80.00m });
                ImpressionsGeneral im = new ImpressionsGeneral();

                if (CBImpresiones.Text == "Lista de precios")
                    im.ImpresionListaPrecios(articulos);
                else
                    im.ImpresionEtiquetas(articulos);
            }
            else
            {
                AppRepository obj = new AppRepository();
                CompanyModel Empresa = obj.GetCompany().Result;
                if (Empresa == null)
                {
                    MessageBox.Show("No se encontraron datos de la empresa.", "Datos de empresa no encontrados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                VentaModel Venta = new VentaModel()
                {
                    Company = Empresa,
                    Copias = 0,
                    Imprimir = cbTicketAutomatico.Checked,
                    Recibido = 100,
                    IdTicket = 0,
                    Cliente = "Publico General",
                    BoxName = "Caja de prueba",
                    Title = "TKT" + Empresa.BillingName.Trim() + "-" + DateTime.Now.Year.ToString() + "-0",
                    Articles = new BindingList<ArticlesSalesModel>()
                    {
                          new ArticlesSalesModel() { IdArticle=1,IdPresentation=1, Code = "1234", Name = "Coca-Cola", Stock = 1, Presentation = "Lata", Price = 10, Decimals = 0, Image = null},
                          new ArticlesSalesModel() { IdArticle=2,IdPresentation=1, Code = "5678", Name = "Pepsi", Stock = 1, Presentation = "Botella", Price = 20, Decimals = 0, Image = null},
                          new ArticlesSalesModel() { IdArticle=3,IdPresentation=1, Code = "9012", Name = "Fanta", Stock = 1, Presentation = "Lata", Price = 15, Decimals = 0, Image = null},
                          new ArticlesSalesModel() { IdArticle=4,IdPresentation=1, Code = "3456", Name = "Sprite", Stock = 1, Presentation = "Botella", Price = 25, Decimals = 0, Image = null},
                          new ArticlesSalesModel() { IdArticle=5,IdPresentation=1, Code = "7890", Name = "Piña", Stock = 1, Presentation = "Pieza", Price = 5, Decimals = 0, Image = null},
                    }
                };
                ImpressionsGeneral im = new ImpressionsGeneral();
                im.GenerarTicketEscPos(Venta);
            }
        }

        private async void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (CBImpresiones.Text == "Seleccione")
            {
                MessageBox.Show("Seleccione una impresión", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

           
            string tipoDeHojaAsignado = CBImpresiones.Text == "Lista de precios" ? "A4" : "mm";

            if (tipoDeHojaAsignado == "mm")
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
                Page = tipoDeHojaAsignado,
                WidthPage = tipoDeHojaAsignado == "mm" ? NUDAMilimetros.Value : 0,
                HightPage = tipoDeHojaAsignado == "mm" ? NUDALMilimetros.Value : 0,
                TicketAutomatico = cbTicketAutomatico.Checked //lee el checkbox
            };

            AppRepository obj = new AppRepository();
            bool result = await obj.SaveImpressions(objImpresion);

            if (result == false)
            {
                MessageBox.Show("Error al guardar la configuración de página", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (CBModificar.Text != "Seleccione")
            {
                switch (CBModificar.Text)
                {
                    case "Recuadro":
                        ConfigBoxModel objBox = new ConfigBoxModel()
                        {
                            Name = "BoxPrecios",
                            Spacing = Convert.ToInt32(NUDEspacio.Value),
                            Align = CBAlineacion.SelectedValue.ToString(),
                            Width = Convert.ToInt32(NUDAncho.Value),
                            HightLine = NUDHightLine.Value,
                            ColorLine = CBColorLinea.SelectedValue.ToString(),
                            Abajo = cbPosicionPrecio.Text == "Abajo"

                        };
                        result = await obj.SaveConfigBox(objBox);
                        break;

                    default:
                        ConfigImpressionsModel objConfig = new ConfigImpressionsModel()
                        {
                            Name = CBModificar.Text,
                            FontSize = Convert.ToInt32(NUDSizeLetra.Value),
                            FontColor = CBColorLetra.SelectedValue.ToString(),
                            FontStyle = CBEstilo.SelectedItem.ToString(),
                            Caracters = Convert.ToInt32(nudCaracteres.Value)
                        };
                        result = await obj.SaveConfigImpressions(objConfig);

                        if (CBModificar.Text == "Precios" && CBImpresiones.Text == "Etiquetas")
                        {
                            ConfigBoxModel objBoxPrecios = new ConfigBoxModel()
                            {
                                Name = "BoxPrecios",
                                Spacing = Convert.ToInt32(NUDEspacio.Value),
                                Align = CBAlineacion.SelectedValue != null ? CBAlineacion.SelectedValue.ToString() : "",
                                Width = Convert.ToInt32(NUDAncho.Value),
                                HightLine = NUDHightLine.Value,
                                ColorLine = CBColorLinea.SelectedValue != null ? CBColorLinea.SelectedValue.ToString() : "",
                                Abajo = cbPosicionPrecio.Text == "Abajo"
                            };
                            await obj.SaveConfigBox(objBoxPrecios);
                        }
                        break;
                }
            }

            if (result == false)
            {
                MessageBox.Show("Error al guardar la configuración de impresión", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                MessageBox.Show("Configuración guardada correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}