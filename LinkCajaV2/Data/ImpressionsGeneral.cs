using LinkCajaV2.Model;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static QuestPDF.Helpers.Colors;
using Spire.Pdf;
namespace LinkCajaV2.Data
{
    public class ImpressionsGeneral
    {
        ConfigPageModel ConfigBox;
        List<ListConfigImpressionsModel> ConfigImpressions;
        public void ImpresionPrecios(List<PrinterPricesModel> ListArticulos) {
            try
            {
                AppRepository obj = new AppRepository();
                ConfigBox = obj.GetConfigBox().Result;
                ConfigImpressions = obj.GetConfigImpressions().Result;
                // 2. Configurar licencia y ruta
                QuestPDF.Settings.License = LicenseType.Community;
                string nombreArchivo = "Lista de precios.pdf";
                string rutaCompleta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory + "\\Impresiones", nombreArchivo);

                // 3. Crear el documento
                Document.Create(container =>
                {
                    container.Page(page =>
                    {
                        if (ConfigBox.Page == "A4")
                        {
                            page.Size(PageSizes.A4);
                            page.Margin(1, Unit.Centimetre);
                        }
                        else
                        {
                            const float MM = 2.8346f;
                            page.Size((float)ConfigBox.WidthPage * MM, (float)ConfigBox.HightPage * MM);//88mm X 250mm
                            page.Margin(2f * MM);
                        }

                        page.PageColor(Colors.White);

                        int TituloFontsize = ConfigImpressions.Find(x => x.Name == "Titulo") != null ? Convert.ToInt32(ConfigImpressions.Find(x => x.Name == "Titulo").FontSize) : 16;
                        string TituloColor = ConfigImpressions.Find(x => x.Name == "Titulo") != null ? ConfigImpressions.Find(x => x.Name == "Titulo").FontColor : "Black";
                        TituloColor = CodigodeColor(TituloColor);
                        string TituloFontStyle = ConfigImpressions.Find(x => x.Name == "Titulo") != null ? ConfigImpressions.Find(x => x.Name == "Titulo").FontStyle : "SemiBold";
                        var EstiloTitulo = ObtenerEstiloPersonalizado(TituloFontStyle, TituloFontsize, TituloColor);
                        int FechaFontsize = ConfigImpressions.Find(x => x.Name == "Fecha") != null ? Convert.ToInt32(ConfigImpressions.Find(x => x.Name == "Fecha").FontSize) : 16;
                        string FechaColor = ConfigImpressions.Find(x => x.Name == "Fecha") != null ? ConfigImpressions.Find(x => x.Name == "Fecha").FontColor : "Black";
                        FechaColor = CodigodeColor(FechaColor);
                        string FechaFontStyle = ConfigImpressions.Find(x => x.Name == "Fecha") != null ? ConfigImpressions.Find(x => x.Name == "Fecha").FontStyle : "SemiBold";
                        var EstiloFecha = ObtenerEstiloPersonalizado(FechaFontStyle, FechaFontsize, FechaColor);
                        // Cabecera del documento
                        page.Header().Row(row =>
                        {
                            row.RelativeItem().Column(col =>
                            {
                                col.Item().Text("CATÁLOGO DE PRECIOS").Style(EstiloTitulo);
                                col.Item().Text("Generado el: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm")).Style(EstiloFecha);
                            });
                        });

                        // Contenido en Cuadrícula (Fluye de izquierda a derecha)
                        page.Content().PaddingVertical(10).Inlined(inlined =>
                        {
                            inlined.Spacing(ConfigBox.Spacing); // Espacio entre recuadros
                            switch (ConfigBox.Align)
                            {
                                case "AlignCenter":
                                    inlined.AlignCenter(); // Centra la cuadrícula en la hoja
                                    break;
                                case "AlignLeft":
                                    inlined.AlignLeft(); // Izquierda la cuadrícula en la hoja
                                    break;
                                case "AlignRight":
                                    inlined.AlignRight(); // Derecha la cuadrícula en la hoja
                                    break;
                                default:
                                    break;
                            }

                            int ArticuloFontsize = ConfigImpressions.Find(x => x.Name == "Articulo") != null ? Convert.ToInt32(ConfigImpressions.Find(x => x.Name == "Articulo").FontSize) : 16;
                            string ArticuloColor = ConfigImpressions.Find(x => x.Name == "Articulo") != null ? ConfigImpressions.Find(x => x.Name == "Articulo").FontColor : "Black";
                            ArticuloColor = CodigodeColor(ArticuloColor);
                            string ArticuloFontStyle = ConfigImpressions.Find(x => x.Name == "Articulo") != null ? ConfigImpressions.Find(x => x.Name == "Articulo").FontStyle : "SemiBold";
                            var EstiloArticulo = ObtenerEstiloPersonalizado(ArticuloFontStyle, ArticuloFontsize, ArticuloColor);

                            int PrecioFontsize = ConfigImpressions.Find(x => x.Name == "Precio") != null ? Convert.ToInt32(ConfigImpressions.Find(x => x.Name == "Precio").FontSize) : 16;
                            string PrecioColor = ConfigImpressions.Find(x => x.Name == "Precio") != null ? ConfigImpressions.Find(x => x.Name == "Precio").FontColor : "Black";
                            PrecioColor = CodigodeColor(PrecioColor);
                            string PrecioFontStyle = ConfigImpressions.Find(x => x.Name == "Precio") != null ? ConfigImpressions.Find(x => x.Name == "Precio").FontStyle : "SemiBold";
                            var EstiloPrecio = ObtenerEstiloPersonalizado(PrecioFontStyle, PrecioFontsize, PrecioColor);

                            foreach (var item in ListArticulos)
                            {
                                inlined.Item().Element(c => DibujarCuadroArticulo(c, item.Articulo, item.Precio, EstiloArticulo, EstiloPrecio));
                            }
                        });

                        // Pie de página
                        page.Footer().AlignCenter().Text(x =>
                        {
                            x.Span("Página ");
                            x.CurrentPageNumber();
                        });
                    });
                })
                .GeneratePdf(rutaCompleta);

                // 4. Abrir el archivo automáticamente
                //MessageBox.Show("PDF generado con éxito.");
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(rutaCompleta) { UseShellExecute = true });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar el PDF: " + ex.Message);
            }
        }
        private TextStyle ObtenerEstiloPersonalizado(string Style, float tamano, string colorHex)
        {
            // Creamos el estilo base con el tamaño y color
            var Estilo = TextStyle.Default
                .FontSize(tamano)
                .FontColor(colorHex);
            switch (Style)
            {
                case "SemiBold":
                    Estilo = Estilo.SemiBold();
                    break;
                case "Medium":
                    Estilo = Estilo.Medium();
                    break;
                case "Bold":
                    Estilo = Estilo.Bold();
                    break;
                default:
                    break;
            }
            // Aplicamos el grosor según el nombre recibido
            return Estilo;
        }
        public string CodigodeColor(string Color)
        {
            string Codigo = "";
            switch (Color)
            {
                case "Black":
                    Codigo = "#000000";
                    break;
                case "Red":
                    Codigo = "#FF0000";
                    break;
                case "Blue":
                    Codigo = "#0000FF";
                    break;
                case "Green":
                    Codigo = "#008000";
                    break;
                default:
                    Codigo = "#808080";
                    break;
            }
            return Codigo;
        }
        private void DibujarCuadroArticulo(QuestPDF.Infrastructure.IContainer container, string nombre, decimal precio, TextStyle EstiloArticulo, TextStyle EstiloPrecio)
        {
            string Cod = CodigodeColor(ConfigBox.ColorLine);
            container
                .Width(ConfigBox.Width) // Ajusta este valor para tener más o menos cuadros por fila
                .Border(0.5f)
                .BorderColor(Colors.Black)
                .Padding(5)
                .Column(col =>
                {
                    // Nombre del artículo (arriba)
                    col.Item().Height(25).AlignCenter().Text(nombre).Style(EstiloArticulo);

                    // Línea divisoria
                    col.Item().PaddingVertical(2).LineHorizontal((float)ConfigBox.HightLine).LineColor(Cod);

                    // Precio (abajo dentro del mismo cuadro)
                    col.Item().AlignCenter().Text(precio.ToString("C2")).Style(EstiloPrecio);
                });
        }
        public void GenerarTicket(BindingList<ArticlesSalesModel> lista)
        {
            QuestPDF.Settings.License = LicenseType.Community;

            try
            {
                string nombreArchivo = $"Ticket_{DateTime.Now:yyyyMMdd_HHmmss}.pdf";
                string carpeta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Impresiones");
                if (!Directory.Exists(carpeta)) Directory.CreateDirectory(carpeta);
                string rutaCompleta = Path.Combine(carpeta, nombreArchivo);
                float mmToPt = 2.83465f;
                float anchoTicketMm = 80f; // Cambia a 58f si la impresora es pequeña
                float altoTicketMm = 200f; // Un alto genérico
                // Conversión a puntos (float)
                float anchoFinal = anchoTicketMm * mmToPt;
                float altoFinal = altoTicketMm * mmToPt;
                QuestPDF.Settings.License = LicenseType.Community;  
                var documento = Document.Create(container =>
                {
                    container.Page(page =>
                    {
                        // Usamos el ancho convertido y una altura lo suficientemente larga 
                        // QuestPDF recortará el espacio vacío al imprimir si el driver lo soporta
                        page.Size(anchoFinal, altoFinal);
                        page.Margin(2, Unit.Millimetre);
                        page.PageColor(Colors.White);
                        page.DefaultTextStyle(x => x.FontSize(8).FontFamily(Fonts.Verdana));

                        // Encabezado
                        page.Header().Column(col =>
                        {
                            col.Item().AlignCenter().Text("MI TIENDA").FontSize(12).SemiBold();
                            col.Item().AlignCenter().Text("RFC: XXXX000000").FontSize(7);
                            col.Item().AlignCenter().Text(DateTime.Now.ToString("dd/MM/yyyy HH:mm"));
                            col.Item().LineHorizontal(1);
                        });

                        // Contenido - Tabla de artículos
                        page.Content().PaddingVertical(5).Table(table =>
                        {
                            table.ColumnsDefinition(columns =>
                            {
                                columns.RelativeColumn(3); // Nombre
                                columns.RelativeColumn(1); // Cant
                                columns.RelativeColumn(2); // Total
                            });

                            foreach (var item in lista)
                            {
                                // Nombre del artículo (alineado a la izquierda)
                                table.Cell().AlignLeft().Text(item.Name);

                                // Cantidad (en medio)
                                table.Cell().AlignCenter().Text(item.Stock.ToString(item.Decimals > 0 ? "N3" : "N0"));

                                // Total (alineado a la derecha)
                                table.Cell().AlignRight().Text(item.Total.ToString("C2"));
                            }
                        });

                        // Pie - Totales
                        page.Footer().Column(col =>
                        {
                            col.Item().LineHorizontal(1);
                            decimal granTotal = lista.Sum(x => x.Total);
                            col.Item().AlignRight().Text($"TOTAL: {granTotal:C2}").FontSize(10).SemiBold();
                            col.Item().PaddingTop(5).AlignCenter().Text("¡Gracias por su compra!");
                        });
                    });
                });

                documento.GeneratePdf(rutaCompleta);
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(rutaCompleta) { UseShellExecute = true });
                ImprimirSilencioso(rutaCompleta);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al imprimir ticket: " + ex.Message);
            }
        }
        public void ImprimirSilencioso(string rutaArchivo)
        {
            PdfDocument pdf = new PdfDocument();
            pdf.LoadFromFile(rutaArchivo);

            // En algunas versiones se usa esta propiedad para ocultar el diálogo:
            pdf.PrintSettings.PrintController = new System.Drawing.Printing.StandardPrintController();

            // Si quieres asegurar la impresora predeterminada:
            // pdf.PrintSettings.PrinterName = "Nombre de tu impresora";

            pdf.Print();
        }
    }
}
