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
using QRCoder;
namespace LinkCajaV2.Data
{
    public class ImpressionsGeneral
    {
        ConfigPageModel ConfigBox;
        List<ListConfigImpressionsModel> ConfigImpressions;
        public void ImpresionListaAgotados(List<PrinterPricesModel> ListArticulos)
        {
            try
            {
                AppRepository obj = new AppRepository();
                ConfigBox = obj.GetConfigBox().Result;
                ConfigImpressions = obj.GetConfigImpressions("Lista de articulos agotados").Result;

                // 2. Configurar licencia y ruta
                QuestPDF.Settings.License = LicenseType.Community;
                string nombreArchivo = "Lista de agotados.pdf";
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
                            page.Size((float)ConfigBox.WidthPage * MM, (float)ConfigBox.HightPage * MM);
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
                                col.Item().Text("LISTA DE AGOTADOS").Style(EstiloTitulo);
                                col.Item().Text("Generado el: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm")).Style(EstiloFecha);
                            });
                        });

                        // 🔥 CONTENIDO EN FORMA DE LISTA NORMAL (SIN CUADROS)
                        page.Content().PaddingVertical(10).Column(listCol =>
                        {
                            // Espaciado vertical entre cada artículo de la lista
                            listCol.Spacing((float)ConfigBox.Spacing);

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
                            listCol.Item().Column(headerCol =>
                            {
                                headerCol.Item().Row(row =>
                                {
                                    row.RelativeItem().AlignLeft().Text("Artículo").Style(EstiloArticulo);
                                    row.RelativeItem().AlignCenter().Text("Categoría").Style(EstiloArticulo);
                                    row.RelativeItem().AlignCenter().Text("Existencias").Style(EstiloArticulo);
                                    row.RelativeItem().AlignCenter().Text("Existencias Minimas").Style(EstiloArticulo);
                                });

                                // Línea divisoria ligeramente más marcada para los títulos
                                headerCol.Item().PaddingTop(5).Height(1.5f).Background(Colors.Grey.Darken1);
                            });
                            foreach (var item in ListArticulos)
                            {
                                // Reemplazamos el método del cuadro por una fila limpia de texto continuo
                                listCol.Item().Column(itemCol =>
                                {
                                    // 1. Renglón con la información del artículo
                                    itemCol.Item().Row(row =>
                                    {
                                        row.RelativeItem().AlignLeft().Text(item.Articulo).Style(EstiloArticulo);
                                        row.RelativeItem().AlignCenter().Text(item.Categoria).Style(EstiloArticulo);
                                        row.RelativeItem().AlignCenter().Text(item.Stock).Style(EstiloArticulo);
                                        row.RelativeItem().AlignCenter().Text(item.StockMinimo).Style(EstiloArticulo);
                                    });

                                    // 2. Línea divisoria horizontal (delgada y de un gris sutil para que se vea elegante)
                                    itemCol.Item().PaddingTop(5).Height(1).Background(Colors.Grey.Lighten2);
                                });
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
                //Abre pdf
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(rutaCompleta) { UseShellExecute = true });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar el PDF: " + ex.Message);
            }
        }

        public void ImpresionListaPrecios(List<PrinterPricesModel> ListArticulos)
        {
            try
            {
                AppRepository obj = new AppRepository();
                ConfigBox = obj.GetConfigBox().Result;
                ConfigImpressions = obj.GetConfigImpressions("Lista de precios").Result;

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
                            page.Size((float)ConfigBox.WidthPage * MM, (float)ConfigBox.HightPage * MM);
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
                                col.Item().Text("LISTA DE PRECIOS").Style(EstiloTitulo);
                                col.Item().Text("Generado el: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm")).Style(EstiloFecha);
                            });
                        });

                        // 🔥 CONTENIDO EN FORMA DE LISTA NORMAL (SIN CUADROS)
                        page.Content().PaddingVertical(10).Column(listCol =>
                        {
                            // Espaciado vertical entre cada artículo de la lista
                            listCol.Spacing((float)ConfigBox.Spacing);

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
                            listCol.Item().Column(headerCol =>
                            {
                                headerCol.Item().Row(row =>
                                {
                                    row.RelativeItem().AlignCenter().Text("Código").Style(EstiloArticulo);
                                    row.RelativeItem().AlignLeft().Text("Artículo").Style(EstiloArticulo);
                                    row.RelativeItem().AlignCenter().Text("Categoría").Style(EstiloArticulo);                                   
                                    row.ConstantItem(80).AlignRight().Text("Precio").Style(EstiloArticulo); // O EstiloPrecio si prefieres
                                });

                                // Línea divisoria ligeramente más marcada para los títulos
                                headerCol.Item().PaddingTop(5).Height(1.5f).Background(Colors.Grey.Darken1);
                            });
                            foreach (var item in ListArticulos)
                            {
                                // Reemplazamos el método del cuadro por una fila limpia de texto continuo
                                listCol.Item().Column(itemCol =>
                                {
                                    // 1. Renglón con la información del artículo
                                    itemCol.Item().Row(row =>
                                    {
                                        row.RelativeItem().AlignCenter().Text(item.Codigo).Style(EstiloArticulo);
                                        row.RelativeItem().AlignLeft().Text(item.Articulo).Style(EstiloArticulo);
                                        row.RelativeItem().AlignCenter().Text(item.Categoria).Style(EstiloArticulo);
                                        row.ConstantItem(80).AlignRight().Text(item.Precio.ToString("C2")).Style(EstiloPrecio);
                                    });

                                    // 2. Línea divisoria horizontal (delgada y de un gris sutil para que se vea elegante)
                                    itemCol.Item().PaddingTop(5).Height(1).Background(Colors.Grey.Lighten2);
                                });
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
                //Abre pdf
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(rutaCompleta) { UseShellExecute = true });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar el PDF: " + ex.Message);
            }
        }
        public void ImpresionEtiquetas(List<PrinterPricesModel> ListArticulos)
        {
            try
            {
                AppRepository obj = new AppRepository();
                ConfigBox = obj.GetConfigBox().Result;
                ConfigImpressions = obj.GetConfigImpressions("Etiquetas").Result;
                // 2. Configurar licencia y ruta
                QuestPDF.Settings.License = LicenseType.Community;
                string nombreArchivo = "Etiquetas.pdf";
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
                                col.Item().Text("ETIQUETAS").Style(EstiloTitulo);
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

        //Impresion de ventas ----------------------------
        public void ImpresionReporteVentas(List<SalesReportModel> ListVentas, DateTime desde, DateTime hasta, decimal envioTotal)
        {
            try
            {
                AppRepository obj = new AppRepository();
                ConfigBox = obj.GetConfigBox().Result;
                ConfigImpressions = obj.GetConfigImpressions("Lista de articulos agotados").Result;

                QuestPDF.Settings.License = LicenseType.Community;
                string nombreArchivo = $"Reporte de Ventas {DateTime.Now:dd-MM-yyyy HH-mm}.pdf";
                string rutaCompleta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory + "\\Impresiones", nombreArchivo);

                Document.Create(container =>
                {
                    container.Page(page =>
                    {
                        if (ConfigBox.Page == "A4")
                        {
                            page.Size(PageSizes.Letter);
                            page.Margin(1, Unit.Centimetre);
                        }
                        else
                        {
                            const float MM = 2.8346f;
                            page.Size((float)ConfigBox.WidthPage * MM, (float)ConfigBox.HightPage * MM);
                            page.Margin(2f * MM);
                        }
                        page.PageColor(Colors.White);

                
                        int TituloFontsize = ConfigImpressions.Find(x => x.Name == "Titulo") != null ? Convert.ToInt32(ConfigImpressions.Find(x => x.Name == "Titulo").FontSize) : 16;
                        
                        string TituloColor = ConfigImpressions.Find(x => x.Name == "Titulo") != null ? ConfigImpressions.Find(x => x.Name == "Titulo").FontColor : "#000000";
                        TituloColor = CodigodeColor(TituloColor);
                        var EstiloTitulo = ObtenerEstiloPersonalizado("SemiBold", TituloFontsize, TituloColor);

                        int FechaFontsize = ConfigImpressions.Find(x => x.Name == "Fecha") != null ? Convert.ToInt32(ConfigImpressions.Find(x => x.Name == "Fecha").FontSize) : 10;
                       
                        string FechaColor = ConfigImpressions.Find(x => x.Name == "Fecha") != null ? ConfigImpressions.Find(x => x.Name == "Fecha").FontColor : "#000000";
                        FechaColor = CodigodeColor(FechaColor);
                        var EstiloFecha = ObtenerEstiloPersonalizado("Normal", FechaFontsize, FechaColor);

                      
                        // Forzamos tamaño 8 para que todo entre perfecto en formato vertical
                        var EstiloArticulo = ObtenerEstiloPersonalizado("Normal", 8, "#000000");

                        page.Header().Row(row =>
                        {
                            row.RelativeItem().Column(col =>
                            {
                                col.Item().Text("REPORTE DE UNIDADES VENDIDAS").Style(EstiloTitulo);
                                col.Item().Text($"Periodo: {desde:dd/MM/yyyy} al {hasta:dd/MM/yyyy}").Style(EstiloFecha);
                                col.Item().Text("Generado el: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm")).Style(EstiloFecha);
                            });
                        });

                        page.Content().PaddingVertical(10).Column(listCol =>
                        {
                            listCol.Spacing((float)ConfigBox.Spacing);

                            // 1. Fila de Encabezados
                            listCol.Item().Column(headerCol =>
                            {
                                headerCol.Item().Row(row =>
                                {
                                    row.RelativeItem(1.2f).AlignLeft().Text("Código").Style(EstiloArticulo).SemiBold();
                                    row.RelativeItem(2.5f).AlignLeft().Text("Descripción").Style(EstiloArticulo).SemiBold();
                                    row.RelativeItem(1.2f).AlignCenter().Text("Categoría").Style(EstiloArticulo).SemiBold();
                                    row.RelativeItem(0.8f).AlignCenter().Text("Cant.").Style(EstiloArticulo).SemiBold();
                                    row.RelativeItem(1.2f).AlignRight().Text("P.Venta").Style(EstiloArticulo).SemiBold();
                                    row.RelativeItem(1.2f).AlignRight().Text("P.Prov").Style(EstiloArticulo).SemiBold();
                                    row.RelativeItem(1.4f).AlignRight().Text("Inversión").Style(EstiloArticulo).SemiBold();
                                    row.RelativeItem(1.4f).AlignRight().Text("Venta T.").Style(EstiloArticulo).SemiBold();
                                    row.RelativeItem(1.4f).AlignRight().Text("Ganancia").Style(EstiloArticulo).SemiBold();
                                });
                                headerCol.Item().PaddingTop(5).Height(1.5f).Background(Colors.Grey.Darken1);
                            });

                            // Variables para los totales
                            decimal sumaUnidades = 0;
                            decimal sumaInversion = 0;
                            decimal sumaVenta = 0;
                            decimal sumaGanancia = 0;

                            // 2. Filas de Datos
                            foreach (var item in ListVentas)
                            {
                                sumaUnidades += item.QuantitySold;
                                sumaInversion += item.TotalInvestment;
                                sumaVenta += item.TotalSale;
                                sumaGanancia += item.Profit;

                                listCol.Item().Column(itemCol =>
                                {
                                    itemCol.Item().Row(row =>
                                    {
                                        row.RelativeItem(1.2f).AlignLeft().Text(item.Code).Style(EstiloArticulo);
                                        row.RelativeItem(2.5f).AlignLeft().Text(item.Description).Style(EstiloArticulo);
                                        row.RelativeItem(1.2f).AlignCenter().Text(item.Category).Style(EstiloArticulo);
                                        row.RelativeItem(0.8f).AlignCenter().Text(item.QuantitySold.ToString("N2")).Style(EstiloArticulo);

                                        row.RelativeItem(1.2f).AlignRight().Text(item.SalePrice.ToString("'$' #,##0.00")).Style(EstiloArticulo);
                                        row.RelativeItem(1.2f).AlignRight().Text(item.SupplierPrice.ToString("'$' #,##0.00")).Style(EstiloArticulo);
                                        row.RelativeItem(1.4f).AlignRight().Text(item.TotalInvestment.ToString("'$' #,##0.00")).Style(EstiloArticulo);
                                        row.RelativeItem(1.4f).AlignRight().Text(item.TotalSale.ToString("'$' #,##0.00")).Style(EstiloArticulo);
                                        row.RelativeItem(1.4f).AlignRight().Text(item.Profit.ToString("'$' #,##0.00")).Style(EstiloArticulo);
                                    });
                                    itemCol.Item().PaddingTop(3).Height(1).Background(Colors.Grey.Lighten2);
                                });
                            }

                            // Fila de Totales Generales
                            listCol.Item()
                            .PaddingTop(10) 
                            .BorderTop(1).BorderColor(Colors.Black) 
                            .PaddingTop(5) 
                            .Row(row =>
                            {
                                row.RelativeItem(7.3f).AlignRight().Text("TOTALES GENERALES:").Style(EstiloArticulo).SemiBold();
                                row.RelativeItem(0.8f).AlignCenter().Text(sumaUnidades.ToString("N2")).Style(EstiloArticulo).SemiBold();
                                row.RelativeItem(2.4f).AlignRight().Text("").Style(EstiloArticulo);

                                row.RelativeItem(1.4f).AlignRight().Text(sumaInversion.ToString("'$' #,##0.00")).Style(EstiloArticulo).SemiBold();
                                row.RelativeItem(1.4f).AlignRight().Text(sumaVenta.ToString("'$' #,##0.00")).Style(EstiloArticulo).SemiBold();
                                row.RelativeItem(1.4f).AlignRight().Text(sumaGanancia.ToString("'$' #,##0.00")).Style(EstiloArticulo).SemiBold();
                            });
                            listCol.Item().PaddingTop(3).Row(row =>
                            {
                                //Venta por envio 
                                row.RelativeItem(11.9f).AlignRight().Text("TOTAL ENVÍOS COBRADOS:").Style(EstiloArticulo).SemiBold();
                                row.RelativeItem(1.4f).AlignRight().Text(envioTotal.ToString("'$' #,##0.00")).Style(EstiloArticulo).SemiBold();
                                row.RelativeItem(1.4f).AlignRight().Text("").Style(EstiloArticulo);
                            });
                            listCol.Item().PaddingTop(3).Row(row =>
                            {
                                decimal granTotalFinal = sumaVenta + envioTotal;
                                row.RelativeItem(11.9f).AlignRight().Text("GRAN TOTAL (Ventas + Envíos):").Style(EstiloArticulo).SemiBold().FontSize(9);
                                row.RelativeItem(1.4f).AlignRight().Text(granTotalFinal.ToString("'$' #,##0.00")).Style(EstiloArticulo).SemiBold().FontSize(9);
                                row.RelativeItem(1.4f).AlignRight().Text("").Style(EstiloArticulo);
                            });
                        });

                        page.Footer().AlignCenter().Text(x =>
                        {
                            x.Span("Página ");
                            x.CurrentPageNumber();
                        });
                    });
                })
                .GeneratePdf(rutaCompleta);

                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(rutaCompleta) { UseShellExecute = true });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar el PDF del reporte: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Aca acaba lo de imprimir ventas -----------------------


        //Inicia Imprimir Gastos Extras -------------
        public void ImpresionReporteGastosExtras(List<ExpenseReportModel> ListGastos, DateTime desde, DateTime hasta)
        {
            try
            {
                AppRepository obj = new AppRepository();
           
                ConfigBox = obj.GetConfigBox().Result;

                ConfigImpressions = obj.GetConfigImpressions("Reporte de Gastos").Result ?? obj.GetConfigImpressions("Lista de articulos agotados").Result;

                QuestPDF.Settings.License = LicenseType.Community;
                string nombreArchivo = $"Reporte de Movimientos Extras {DateTime.Now:dd-MM-yyyy HH-mm}.pdf";
                string rutaCompleta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory + "\\Impresiones", nombreArchivo);

                Document.Create(container =>
                {
                    container.Page(page =>
                    {
                        // Configuración de la hoja
                        if (ConfigBox.Page == "A4")
                        {
                            page.Size(PageSizes.Letter);
                            page.Margin(1, Unit.Centimetre);
                        }
                        else
                        {
                            const float MM = 2.8346f;
                            page.Size((float)ConfigBox.WidthPage * MM, (float)ConfigBox.HightPage * MM);
                            page.Margin(2f * MM);
                        }
                        page.PageColor(Colors.White);

                        //  Estilos de Letra
                        int TituloFontsize = ConfigImpressions.Find(x => x.Name == "Titulo") != null ? Convert.ToInt32(ConfigImpressions.Find(x => x.Name == "Titulo").FontSize) : 16;
                        string TituloColor = ConfigImpressions.Find(x => x.Name == "Titulo") != null ? ConfigImpressions.Find(x => x.Name == "Titulo").FontColor : "#000000";
                        TituloColor = CodigodeColor(TituloColor);
                        var EstiloTitulo = ObtenerEstiloPersonalizado("SemiBold", TituloFontsize, TituloColor);

                        int FechaFontsize = ConfigImpressions.Find(x => x.Name == "Fecha") != null ? Convert.ToInt32(ConfigImpressions.Find(x => x.Name == "Fecha").FontSize) : 10;
                        string FechaColor = ConfigImpressions.Find(x => x.Name == "Fecha") != null ? ConfigImpressions.Find(x => x.Name == "Fecha").FontColor : "#000000";
                        FechaColor = CodigodeColor(FechaColor);
                        var EstiloFecha = ObtenerEstiloPersonalizado("Normal", FechaFontsize, FechaColor);

                        var EstiloArticulo = ObtenerEstiloPersonalizado("Normal", 9, "#000000"); // Tamaño 9 para que quepa bien el texto

                        // Encabezado del PDF
                        page.Header().Row(row =>
                        {
                            row.RelativeItem().Column(col =>
                            {
                                col.Item().Text("REPORTE DE MOVIMIENTOS EXTRAS").Style(EstiloTitulo);
                                col.Item().Text($"Periodo: {desde:dd/MM/yyyy HH:mm} al {hasta:dd/MM/yyyy HH:mm}").Style(EstiloFecha);
                                col.Item().Text("Generado el: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm")).Style(EstiloFecha);
                            });
                        });

                        // Cuerpo de la tabla
                        page.Content().PaddingVertical(10).Column(listCol =>
                        {
                            listCol.Spacing((float)ConfigBox.Spacing);

                            // Encabezados de Columnas
                            listCol.Item().Column(headerCol =>
                            {
                                headerCol.Item().Row(row =>
                                {
                                    row.RelativeItem(1.5f).AlignLeft().Text("Fecha y Hora").Style(EstiloArticulo).SemiBold();
                                    row.RelativeItem(1.5f).AlignLeft().Text("Usuario/Caja").Style(EstiloArticulo).SemiBold();
                                    row.RelativeItem(4.0f).AlignLeft().Text("Concepto o Motivo").Style(EstiloArticulo).SemiBold();
                                    row.RelativeItem(1.5f).AlignCenter().Text("Tipo").Style(EstiloArticulo).SemiBold();
                                    row.RelativeItem(1.5f).AlignRight().Text("Monto").Style(EstiloArticulo).SemiBold();
                                });
                                headerCol.Item().PaddingTop(5).Height(1.5f).Background(Colors.Grey.Darken1);
                            });

                            // Separar sumatorias
                            decimal totalEntradas = ListGastos.Where(x => x.IsExpense == false).Sum(x => x.Amount);
                            decimal totalGastos = ListGastos.Where(x => x.IsExpense == true).Sum(x => x.Amount);
                            decimal balance = totalEntradas - totalGastos;

                            // Filas de Datos
                            foreach (var item in ListGastos)
                            {
                                listCol.Item().Column(itemCol =>
                                {
                                    itemCol.Item().Row(row =>
                                    {
                                        row.RelativeItem(1.5f).AlignLeft().Text(item.DateRecord.ToString("dd/MM/yy HH:mm")).Style(EstiloArticulo);
                                        row.RelativeItem(1.5f).AlignLeft().Text(item.UserName).Style(EstiloArticulo);
                                        row.RelativeItem(4.0f).AlignLeft().Text(item.Concept).Style(EstiloArticulo);
                                        row.RelativeItem(1.5f).AlignCenter().Text(item.TypeMovement).Style(EstiloArticulo);
                                        row.RelativeItem(1.5f).AlignRight().Text(item.Amount.ToString("'$' #,##0.00")).Style(EstiloArticulo);
                                    });
                                    itemCol.Item().PaddingTop(3).Height(1).Background(Colors.Grey.Lighten2);
                                });
                            }

                            //  Totales Generales 
                            listCol.Item()
                            .PaddingTop(10)
                            .BorderTop(1).BorderColor(Colors.Black)
                            .PaddingTop(5)
                            .Column(totCol =>
                            {
                                totCol.Item().AlignRight().Text($"Total Entradas: {totalEntradas.ToString("'$' #,##0.00")}").Style(EstiloArticulo).SemiBold();
                                totCol.Item().AlignRight().Text($"Total Gastos: {totalGastos.ToString("'$' #,##0.00")}").Style(EstiloArticulo).SemiBold();
                                
                            });
                        });

                        // 5. Pie de página
                        page.Footer().AlignCenter().Text(x =>
                        {
                            x.Span("Página ");
                            x.CurrentPageNumber();
                            x.Span(" de ");
                            x.TotalPages();
                        });
                    });
                })
                .GeneratePdf(rutaCompleta);

                // Abrimos el PDF automático
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(rutaCompleta) { UseShellExecute = true });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar el PDF del reporte: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //Termina Imprimir Gastos Extras ------------


        //Empieza Imprimir Corte de Caja 
        public void ImpresionReporteCortes(List<ListCashFundModel> ListCortes, DateTime desde, DateTime hasta)
        {
            try
            {
                AppRepository obj = new AppRepository();
                var ConfigBox = obj.GetConfigBox().Result;

                // Puedes cambiar "Reporte de ventas" por el nombre de configuración que uses para colores si tienes otro
                var ConfigImpressions = obj.GetConfigImpressions("Reporte de ventas").Result;

                QuestPDF.Settings.License = LicenseType.Community;
                string nombreArchivo = $"Reporte de Cortes {DateTime.Now:dd-MM-yyyy HH-mm}.pdf";
                string rutaCompleta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory + "\\Impresiones", nombreArchivo);

                Document.Create(container =>
                {
                    container.Page(page =>
                    {
                        if (ConfigBox.Page == "A4")
                        {
                            page.Size(PageSizes.Letter);
                            page.Margin(1, Unit.Centimetre);
                        }
                        else
                        {
                            const float MM = 2.8346f;
                            page.Size((float)ConfigBox.WidthPage * MM, (float)ConfigBox.HightPage * MM);
                            page.Margin(2f * MM);
                        }
                        page.PageColor(Colors.White);

                        // Reutilizamos tu lógica de estilos de fuente
                        var EstiloTitulo = ObtenerEstiloPersonalizado("SemiBold", 16, "#000000");
                        var EstiloFecha = ObtenerEstiloPersonalizado("Normal", 10, "#000000");
                        var EstiloArticulo = ObtenerEstiloPersonalizado("Normal", 8, "#000000");

                        page.Header().Row(row =>
                        {
                            row.RelativeItem().Column(col =>
                            {
                                col.Item().Text("REPORTE HISTÓRICO DE CORTES DE CAJA").Style(EstiloTitulo);
                                col.Item().Text($"Periodo: {desde:dd/MM/yyyy} al {hasta:dd/MM/yyyy}").Style(EstiloFecha);
                                col.Item().Text("Generado el: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm")).Style(EstiloFecha);
                            });
                        });

                        page.Content().PaddingVertical(10).Column(listCol =>
                        {
                            listCol.Spacing((float)ConfigBox.Spacing);

                            // 1. Fila de Encabezados
                            listCol.Item().Column(headerCol =>
                            {
                                headerCol.Item().Row(row =>
                                {
                                    row.RelativeItem(1.2f).AlignLeft().Text("Caja").Style(EstiloArticulo).SemiBold();
                                    row.RelativeItem(1.6f).AlignCenter().Text("Apertura").Style(EstiloArticulo).SemiBold();
                                    row.RelativeItem(1.6f).AlignCenter().Text("Cierre").Style(EstiloArticulo).SemiBold();
                                    row.RelativeItem(1.2f).AlignRight().Text("Ventas").Style(EstiloArticulo).SemiBold();
                                    row.RelativeItem(1.2f).AlignRight().Text("Entradas").Style(EstiloArticulo).SemiBold();
                                    row.RelativeItem(1.2f).AlignRight().Text("Gastos").Style(EstiloArticulo).SemiBold();
                                });
                                headerCol.Item().PaddingTop(5).Height(1.5f).Background(Colors.Grey.Darken1);
                            });

                            // Variables para los totales
                            decimal sumaVentas = 0;
                            decimal sumaEntradas = 0;
                            decimal sumaGastos = 0;

                            // 2. Filas de Datos
                            foreach (var item in ListCortes)
                            {
                                sumaVentas += item.TotalVentas;
                                sumaEntradas += item.TotalEntradas;
                                sumaGastos += item.TotalGastos;

                                listCol.Item().Column(itemCol =>
                                {
                                    itemCol.Item().Row(row =>
                                    {
                                        row.RelativeItem(1.2f).AlignLeft().Text(item.Caja).Style(EstiloArticulo);
                                        row.RelativeItem(1.6f).AlignCenter().Text(item.Apertura.ToString("dd/MM/yy HH:mm")).Style(EstiloArticulo);

                                        string cierre = item.Cierre > DateTime.MinValue ? item.Cierre.ToString("dd/MM/yy HH:mm") : "Abierta";
                                        row.RelativeItem(1.6f).AlignCenter().Text(cierre).Style(EstiloArticulo);

                                        row.RelativeItem(1.2f).AlignRight().Text(item.TotalVentas.ToString("'$' #,##0.00")).Style(EstiloArticulo);
                                        row.RelativeItem(1.2f).AlignRight().Text(item.TotalEntradas.ToString("'$' #,##0.00")).Style(EstiloArticulo);
                                        row.RelativeItem(1.2f).AlignRight().Text(item.TotalGastos.ToString("'$' #,##0.00")).Style(EstiloArticulo);
                                        row.RelativeItem(1.3f).AlignRight().Text(item.Diferencia.ToString("'$' #,##0.00")).Style(EstiloArticulo);
                                    });
                                    itemCol.Item().PaddingTop(3).Height(1).Background(Colors.Grey.Lighten2);
                                });
                            }

                            // 3. Fila de Totales Generales
                            listCol.Item()
                            .PaddingTop(10)
                            .BorderTop(1).BorderColor(Colors.Black)
                            .PaddingTop(5)
                            .Row(row =>
                            {
                                row.RelativeItem(6.2f).AlignRight().Text("TOTALES GENERALES:").Style(EstiloArticulo).SemiBold();
                                row.RelativeItem(1.2f).AlignRight().Text(sumaVentas.ToString("'$' #,##0.00")).Style(EstiloArticulo).SemiBold();
                                row.RelativeItem(1.2f).AlignRight().Text(sumaEntradas.ToString("'$' #,##0.00")).Style(EstiloArticulo).SemiBold();
                                row.RelativeItem(1.2f).AlignRight().Text(sumaGastos.ToString("'$' #,##0.00")).Style(EstiloArticulo).SemiBold();
                            });
                        });

                        page.Footer().AlignCenter().Text(x =>
                        {
                            x.Span("Página ");
                            x.CurrentPageNumber();
                        });
                    });
                })
                .GeneratePdf(rutaCompleta);

                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(rutaCompleta) { UseShellExecute = true });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar el PDF del reporte: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Termina Imprimir Corte de Caja --------

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
                    // 1. Nombre del artículo (Sin Height fijo)
                    col.Item().Row(row =>
                    {
                        row.RelativeItem()
                           .AlignCenter()
                           .Text(nombre)
                           .Style(EstiloArticulo);
                    });

                    // 2. Línea divisoria
                    col.Item()
                       .PaddingVertical(2)
                       .LineHorizontal((float)ConfigBox.HightLine)
                       .LineColor(Cod);

                    // 3. Precio (Abajo)
                    col.Item()
                       .AlignCenter()
                       .Text(precio.ToString("C2"))
                       .Style(EstiloPrecio);
                });
        }
        public void GenerarTicket(VentaModel venta)
        {
            QuestPDF.Settings.License = LicenseType.Community;

            try
            {
                string nombreArchivo = $"Ticket_{venta.IdTicket}.pdf";
                string carpeta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Impresiones");
                if (!Directory.Exists(carpeta)) Directory.CreateDirectory(carpeta);
                string rutaCompleta = Path.Combine(carpeta, nombreArchivo);

                AppRepository obj = new AppRepository();
                ConfigBox = obj.GetConfigPage().Result;
                ConfigImpressions = obj.GetConfigImpressions("Ticket").Result;

                float mmToPt = 2.83465f;
                float anchoTicketMm = (float)ConfigBox.WidthPage; // Ej. 58f u 80f
                float anchoFinal = anchoTicketMm * mmToPt;

                // Generar QR
                byte[] qrBytes = null;
                using (QRCodeGenerator qrGenerator = new QRCodeGenerator())
                {
                    string datosQr = $"https://facturacion.tiendasmino.com";///facturar?ticket={venta.Title}\n&total={venta.Total.ToString()}";

                    using (QRCodeData qrCodeData = qrGenerator.CreateQrCode(datosQr, QRCodeGenerator.ECCLevel.Q))
                    using (PngByteQRCode qrCode = new PngByteQRCode(qrCodeData))
                    {
                        qrBytes = qrCode.GetGraphic(10);
                    }
                }

                var documento = Document.Create(container =>
                {
                    container.Page(page =>
                    {
                        // CORRECCIÓN: Método oficial de QuestPDF para ancho fijo y alto variable
                        page.ContinuousSize(anchoFinal);

                        page.Margin(2, Unit.Millimetre);
                        page.PageColor(Colors.White);
                        page.DefaultTextStyle(x => x.FontSize(8).FontFamily(Fonts.Arial));

                        // Carga de estilos desde tu configuración
                        int TituloFontsize = ConfigImpressions.Find(x => x.Name == "Titulo") != null ? Convert.ToInt32(ConfigImpressions.Find(x => x.Name == "Titulo").FontSize) : 10;
                        string TituloColor = ConfigImpressions.Find(x => x.Name == "Titulo") != null ? ConfigImpressions.Find(x => x.Name == "Titulo").FontColor : "Black";
                        TituloColor = CodigodeColor(TituloColor);
                        string TituloFontStyle = ConfigImpressions.Find(x => x.Name == "Titulo") != null ? ConfigImpressions.Find(x => x.Name == "Titulo").FontStyle : "SemiBold";
                        var EstiloTitulo = ObtenerEstiloPersonalizado(TituloFontStyle, TituloFontsize, TituloColor);

                        int CompanyFontsize = ConfigImpressions.Find(x => x.Name == "Company") != null ? Convert.ToInt32(ConfigImpressions.Find(x => x.Name == "Company").FontSize) : 10;
                        string CompanyColor = ConfigImpressions.Find(x => x.Name == "Company") != null ? ConfigImpressions.Find(x => x.Name == "Company").FontColor : "Black";
                        CompanyColor = CodigodeColor(CompanyColor);
                        string CompanyFontStyle = ConfigImpressions.Find(x => x.Name == "Company") != null ? ConfigImpressions.Find(x => x.Name == "Company").FontStyle : "SemiBold";
                        var EstiloCompany = ObtenerEstiloPersonalizado(CompanyFontStyle, CompanyFontsize, CompanyColor);

                        int RFCFontsize = ConfigImpressions.Find(x => x.Name == "RFC") != null ? Convert.ToInt32(ConfigImpressions.Find(x => x.Name == "RFC").FontSize) : 8;
                        string RFCColor = ConfigImpressions.Find(x => x.Name == "RFC") != null ? ConfigImpressions.Find(x => x.Name == "RFC").FontColor : "Black";
                        RFCColor = CodigodeColor(RFCColor);
                        string RFCFontStyle = ConfigImpressions.Find(x => x.Name == "RFC") != null ? ConfigImpressions.Find(x => x.Name == "RFC").FontStyle : "Normal";
                        var EstiloRFC = ObtenerEstiloPersonalizado(RFCFontStyle, RFCFontsize, RFCColor);

                        int FechaFontsize = ConfigImpressions.Find(x => x.Name == "Fecha") != null ? Convert.ToInt32(ConfigImpressions.Find(x => x.Name == "Fecha").FontSize) : 8;
                        string FechaColor = ConfigImpressions.Find(x => x.Name == "Fecha") != null ? ConfigImpressions.Find(x => x.Name == "Fecha").FontColor : "Black";
                        FechaColor = CodigodeColor(FechaColor);
                        string FechaFontStyle = ConfigImpressions.Find(x => x.Name == "Fecha") != null ? ConfigImpressions.Find(x => x.Name == "Fecha").FontStyle : "Normal";
                        var EstiloFecha = ObtenerEstiloPersonalizado(FechaFontStyle, FechaFontsize, FechaColor);

                        int TablaFontsize = ConfigImpressions.Find(x => x.Name == "Tabla") != null ? Convert.ToInt32(ConfigImpressions.Find(x => x.Name == "Tabla").FontSize) : 8;
                        string TablaColor = ConfigImpressions.Find(x => x.Name == "Tabla") != null ? ConfigImpressions.Find(x => x.Name == "Tabla").FontColor : "Black";
                        TablaColor = CodigodeColor(TablaColor);
                        string TablaFontStyle = ConfigImpressions.Find(x => x.Name == "Tabla") != null ? ConfigImpressions.Find(x => x.Name == "Tabla").FontStyle : "Normal";
                        var EstiloTabla = ObtenerEstiloPersonalizado(TablaFontStyle, TablaFontsize, TablaColor);

                        // Encabezado del Ticket
                        page.Header().Column(col =>
                        {
                            col.Item().AlignCenter().Text("TICKET " + venta.IdTicket.ToString()).Style(EstiloTitulo);
                            col.Item().AlignCenter().Text("VENTA EN LA CAJA " + venta.BoxName).Style(EstiloTitulo);
                            col.Item().AlignCenter().Text(venta.Company.Name).Style(EstiloCompany);
                            col.Item().AlignCenter().Text(venta.Company.RFC).Style(EstiloRFC);
                            col.Item().AlignCenter().Text(venta.Company.Address).Style(EstiloRFC);
                            col.Item().AlignCenter().Text(venta.Cliente).Style(EstiloRFC);
                            col.Item().AlignCenter().Text(DateTime.Now.ToString("dd/MM/yyyy HH:mm")).Style(EstiloFecha);
                            col.Item().PaddingVertical(2).LineHorizontal(1);
                        });

                        // Contenido Principal
                        page.Content().PaddingVertical(2).Column(mainCol =>
                        {
                            // 1. La Tabla
                            mainCol.Item().Table(table =>
                            {
                                table.ColumnsDefinition(columns =>
                                {
                                    columns.RelativeColumn(2.2f); // Código espaciado de forma elástica
                                    columns.RelativeColumn(4f);    // Descripción
                                    columns.RelativeColumn(1f);    // Cantidad
                                    columns.RelativeColumn(1.8f);  // Total
                                });

                                // Encabezados
                                table.Header(header =>
                                {
                                    header.Cell().AlignLeft().Text("Código").Style(EstiloTabla).Bold();
                                    header.Cell().AlignLeft().Text("Descripción").Style(EstiloTabla).Bold();
                                    header.Cell().AlignCenter().Text("Cant").Style(EstiloTabla).Bold();
                                    header.Cell().AlignRight().Text("Total").Style(EstiloTabla).Bold();
                                    header.Cell().ColumnSpan(4).PaddingVertical(2).LineHorizontal(0.5f);
                                });

                                // Artículos
                                foreach (var item in venta.Articles)
                                {
                                    table.Cell().PaddingVertical(1).AlignLeft().Text(item.Code).Style(EstiloTabla);
                                    table.Cell().PaddingVertical(1).AlignLeft().Text(item.Name).Style(EstiloTabla);
                                    table.Cell().PaddingVertical(1).AlignCenter().Text(item.Stock.ToString(item.Decimals > 0 ? "N3" : "N0")).Style(EstiloTabla);
                                    table.Cell().PaddingVertical(1).AlignRight().Text(item.Total.ToString("C2")).Style(EstiloTabla);
                                }
                            });

                            // Totales
                            int TotalFontsize = ConfigImpressions.Find(x => x.Name == "Total") != null ? Convert.ToInt32(ConfigImpressions.Find(x => x.Name == "Total").FontSize) : 9;
                            string TotalColor = ConfigImpressions.Find(x => x.Name == "Total") != null ? ConfigImpressions.Find(x => x.Name == "Total").FontColor : "Black";
                            TotalColor = CodigodeColor(TotalColor);
                            string TotalFontStyle = ConfigImpressions.Find(x => x.Name == "Total") != null ? ConfigImpressions.Find(x => x.Name == "Total").FontStyle : "SemiBold";
                            var EstiloTotal = ObtenerEstiloPersonalizado(TotalFontStyle, TotalFontsize, TotalColor);

                            // 2. Bloque de Cierre
                            mainCol.Item().PaddingTop(3).Column(totalCol =>
                            {
                                totalCol.Item().LineHorizontal(1);

                                decimal subTotal = venta.Articles.Sum(x => x.Total);
                                totalCol.Item().PaddingTop(2).AlignRight().Text($"SUBTOTAL: {subTotal:C2}").Style(EstiloTotal);
                                //Si hay costo de envio mete un nuevo renglon 
                                if (venta.CostoEnvio > 0)
                                {
                                    totalCol.Item().AlignRight().Text($"ENVÍO: {venta.CostoEnvio:C2}").Style(EstiloTotal);
                                }

                                //totalCol.Item().PaddingTop(2).AlignRight().Text($"RECIBIDO: {venta.Recibido:C2}").Style(EstiloTotal);
                                //totalCol.Item().AlignRight().Text($"TOTAL: {granTotal:C2}").Style(EstiloTotal);
                                totalCol.Item().AlignRight().Text($"TOTAL: {venta.Total:C2}").Style(EstiloTotal);
                                totalCol.Item().AlignRight().Text($"RECIBIDO: {venta.Recibido:C2}").Style(EstiloTotal);


                                //decimal cambio = venta.Recibido - granTotal;
                                decimal cambio = venta.Recibido - venta.Total;
                                totalCol.Item().AlignRight().Text($"CAMBIO: {cambio:C2}").Style(EstiloTotal);

                                totalCol.Item().PaddingTop(8).AlignCenter().Text("¡Gracias por su compra!").Style(EstiloTabla);

                                // Control estricto de tamaño del QR
                                if (qrBytes != null)
                                {
                                    totalCol.Item()
                                            .PaddingTop(8)
                                            .AlignCenter()
                                            .Width(55)
                                            .Image(qrBytes);
                                }
                            });
                        });
                    });
                });

                // Guardado y Ejecución
                documento.GeneratePdf(rutaCompleta);

                if (venta.Imprimir)
                {
                    for (int i = 0; i <= venta.Copias; i++)
                        ImprimirSilencioso(rutaCompleta);
                }
                else
                {
                    System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(rutaCompleta) { UseShellExecute = true });
                }
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
            pdf.Print();
        }
    }
}
