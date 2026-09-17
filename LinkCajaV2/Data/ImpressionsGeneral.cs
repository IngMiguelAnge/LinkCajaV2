using LinkCajaV2.Model;
using LinkCajaV2.Sales;
using QRCoder;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using Spire.Pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static QuestPDF.Helpers.Colors;
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
                ConfigBox = obj.GetConfigBox("Lista de precios").Result;
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

                            int ArticuloFontsize = ConfigImpressions.Find(x => x.Name == "Articulos") != null ? Convert.ToInt32(ConfigImpressions.Find(x => x.Name == "Articulos").FontSize) : 16;
                            string ArticuloColor = ConfigImpressions.Find(x => x.Name == "Articulos") != null ? ConfigImpressions.Find(x => x.Name == "Articulos").FontColor : "Black";
                            ArticuloColor = CodigodeColor(ArticuloColor);
                            string ArticuloFontStyle = ConfigImpressions.Find(x => x.Name == "Articulos") != null ? ConfigImpressions.Find(x => x.Name == "Articulos").FontStyle : "SemiBold";
                            var EstiloArticulo = ObtenerEstiloPersonalizado(ArticuloFontStyle, ArticuloFontsize, ArticuloColor);

                            int PrecioFontsize = ConfigImpressions.Find(x => x.Name == "Precios") != null ? Convert.ToInt32(ConfigImpressions.Find(x => x.Name == "Precios").FontSize) : 16;
                            string PrecioColor = ConfigImpressions.Find(x => x.Name == "Precios") != null ? ConfigImpressions.Find(x => x.Name == "Precios").FontColor : "Black";
                            PrecioColor = CodigodeColor(PrecioColor);
                            string PrecioFontStyle = ConfigImpressions.Find(x => x.Name == "Precios") != null ? ConfigImpressions.Find(x => x.Name == "Precios").FontStyle : "SemiBold";
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
                ConfigBox = obj.GetConfigBox("Lista de precios").Result;
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

                            int ArticuloFontsize = ConfigImpressions.Find(x => x.Name == "Articulos") != null ? Convert.ToInt32(ConfigImpressions.Find(x => x.Name == "Articulos").FontSize) : 16;
                            string ArticuloColor = ConfigImpressions.Find(x => x.Name == "Articulos") != null ? ConfigImpressions.Find(x => x.Name == "Articulos").FontColor : "Black";
                            ArticuloColor = CodigodeColor(ArticuloColor);
                            string ArticuloFontStyle = ConfigImpressions.Find(x => x.Name == "Articulos") != null ? ConfigImpressions.Find(x => x.Name == "Articulos").FontStyle : "SemiBold";
                            var EstiloArticulo = ObtenerEstiloPersonalizado(ArticuloFontStyle, ArticuloFontsize, ArticuloColor);

                            int PrecioFontsize = ConfigImpressions.Find(x => x.Name == "Precios") != null ? Convert.ToInt32(ConfigImpressions.Find(x => x.Name == "Precios").FontSize) : 16;
                            string PrecioColor = ConfigImpressions.Find(x => x.Name == "Precios") != null ? ConfigImpressions.Find(x => x.Name == "Precios").FontColor : "Black";
                            PrecioColor = CodigodeColor(PrecioColor);
                            string PrecioFontStyle = ConfigImpressions.Find(x => x.Name == "Precios") != null ? ConfigImpressions.Find(x => x.Name == "Precios").FontStyle : "SemiBold";
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
                                listCol.Item().Column(itemCol =>
                                {
                                    itemCol.Item().Row(row =>
                                    {
                                        row.RelativeItem().AlignCenter().Text(item.Codigo).Style(EstiloArticulo);
                                        row.RelativeItem().AlignLeft().Text(item.Articulo).Style(EstiloArticulo);
                                        row.RelativeItem().AlignCenter().Text(item.Categoria).Style(EstiloArticulo);
                                        row.ConstantItem(80).AlignRight().Text(item.Precio.ToString("C2")).Style(EstiloPrecio);
                                    });

                                    // Línea divisoria
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
                ConfigBox = obj.GetConfigBox("Etiquetas").Result;
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
                        bool esA4 = ConfigBox.Page == "A4";

                        if (esA4)
                        {
                            page.Size(PageSizes.A4);
                            page.Margin(1, Unit.Centimetre);
                        }
                        else
                        {
                            const float MM = 2.8346f;
                            page.Size((float)ConfigBox.WidthPage * MM, (float)ConfigBox.HightPage * MM);//88mm X 250mm
                                                                                                        // Reducimos el margen a 0 o al mínimo para evitar conflictos de espacio en etiquetas pequeñas
                            page.Margin(0);
                        }
                        //if (ConfigBox.Page == "A4")
                        //{
                        //    page.Size(PageSizes.A4);
                        //    page.Margin(1, Unit.Centimetre);
                        //}
                        //else
                        //{
                        //    const float MM = 2.8346f;
                        //    page.Size((float)ConfigBox.WidthPage * MM, (float)ConfigBox.HightPage * MM);//88mm X 250mm
                        //    page.Margin(0);
                        //    //page.Margin(2f * MM);
                        //}

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
                       if (esA4)
                        {
                            page.Header().Row(row =>
                        {
                            row.RelativeItem().Column(col =>
                            {
                                col.Item().Text("ETIQUETAS").Style(EstiloTitulo);
                                col.Item().Text("Generado el: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm")).Style(EstiloFecha);
                            });
                        });
                        }

                        var areaContenido = page.Content();
                        if (esA4)
                        {
                            areaContenido = areaContenido.PaddingVertical(10);
                        }

                        // Contenido en Cuadrícula (Fluye de izquierda a derecha)
                        areaContenido.Inlined(inlined =>
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

                            int ArticuloFontsize = ConfigImpressions.Find(x => x.Name == "Articulos") != null ? Convert.ToInt32(ConfigImpressions.Find(x => x.Name == "Articulos").FontSize) : 16;
                            string ArticuloColor = ConfigImpressions.Find(x => x.Name == "Articulos") != null ? ConfigImpressions.Find(x => x.Name == "Articulos").FontColor : "Black";
                            ArticuloColor = CodigodeColor(ArticuloColor);
                            int ArticuloCaracter = ConfigImpressions.Find(x => x.Name == "Articulos") != null ? Convert.ToInt32(ConfigImpressions.Find(x => x.Name == "Articulos").Caracters) : 500;

                            string ArticuloFontStyle = ConfigImpressions.Find(x => x.Name == "Articulos") != null ? ConfigImpressions.Find(x => x.Name == "Articulos").FontStyle : "SemiBold";
                            var EstiloArticulo = ObtenerEstiloPersonalizado(ArticuloFontStyle, ArticuloFontsize, ArticuloColor);

                            int PrecioFontsize = ConfigImpressions.Find(x => x.Name == "Precios") != null ? Convert.ToInt32(ConfigImpressions.Find(x => x.Name == "Precios").FontSize) : 16;
                            string PrecioColor = ConfigImpressions.Find(x => x.Name == "Precios") != null ? ConfigImpressions.Find(x => x.Name == "Precios").FontColor : "Black";
                            PrecioColor = CodigodeColor(PrecioColor);
                            string PrecioFontStyle = ConfigImpressions.Find(x => x.Name == "Precios") != null ? ConfigImpressions.Find(x => x.Name == "Precios").FontStyle : "SemiBold";
                            var EstiloPrecio = ObtenerEstiloPersonalizado(PrecioFontStyle, PrecioFontsize, PrecioColor);

                            foreach (var item in ListArticulos)
                            {
                                string Articulo = item.Articulo.Length > ArticuloCaracter ? item.Articulo.Substring(0, ArticuloCaracter) + "..." : item.Articulo;
                                inlined.Item().Element(c => DibujarCuadroArticulo(c, Articulo, item.Precio, EstiloArticulo, EstiloPrecio));
                            }
                        });

                        // Pie de página
                        if (esA4)
                        {
                            page.Footer().AlignCenter().Text(x =>
                        {
                            x.Span("Página ");
                            x.CurrentPageNumber();
                        });
                        }
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
                ConfigBox = obj.GetConfigBox("Lista de precios").Result;
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
                                    row.RelativeItem(0.8f).AlignCenter().Text("Stock").Style(EstiloArticulo).SemiBold();
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
                                        row.RelativeItem(0.8f).AlignCenter().Text(item.Stock.ToString()).Style(EstiloArticulo);
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
           
                ConfigBox = obj.GetConfigBox("Lista de precios").Result;

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
                var ConfigBox = obj.GetConfigBox("Lista de precios").Result;

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
                //      .Width((float)ConfigBox.Width, Unit.Millimetre)
                //.Height((float)ConfigBox.HightPage, Unit.Millimetre)
            float padding = (ConfigBox.Page == "A4") ? 5f : 1f;
            string Cod = CodigodeColor(ConfigBox.ColorLine);
            container
                .Width((float)ConfigBox.Width, Unit.Millimetre)
                .Height((float)ConfigBox.Higth, Unit.Millimetre)
                .Border(0.5f)
                .BorderColor(Colors.Black)
                .Padding(padding)
                .Column(col =>
                {

                    // Si NO es Abajo (es decir, es Arriba)
                    if (!ConfigBox.Abajo)
                    {
                        //  Precio (Arriba)
                        col.Item()
                           .AlignCenter()
                           .Text(precio.ToString("C2"))
                           .Style(EstiloPrecio);

                        //  Línea divisoria
                        col.Item()
                           .PaddingVertical(2)
                           .LineHorizontal((float)ConfigBox.HightLine)
                           .LineColor(Cod);

                        //  Nombre del artículo (Abajo)
                        col.Item().Row(row =>
                        {
                            row.RelativeItem()
                               .AlignCenter()
                               .Text(nombre)
                               .Style(EstiloArticulo);
                        });
                    }
                    else
                    {
                        // Este es el original 

                        // 1. Nombre del artículo (Arriba)
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
                    }
                    //////////////////////////////
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

                // 1. CÁLCULO DINÁMICO DE ALTURA PARA POS-58
                float anchoTicketMm = ConfigBox != null && ConfigBox.WidthPage > 0 ? (float)ConfigBox.WidthPage : 58f;

                // Base fija: Encabezado, totales, textos y QR (~85mm) + 6mm por cada producto
                float altoEstimadoMm = 85f + (venta.Articles.Count * 6f);
               

                float mmToPt = 2.83465f;
                float anchoPuntos = anchoTicketMm * mmToPt;
                float altoPuntos = altoEstimadoMm * mmToPt;

                // Generación del código QR
                byte[] qrBytes = null;
                using (QRCodeGenerator qrGenerator = new QRCodeGenerator())
                {
                    string datosQr = $"https://facturacion.tiendasmino.com";

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
                        // Se define Page.Size exacto para obligar al driver a cortar justo al finalizar
                        page.Size(anchoPuntos, altoPuntos);

                        page.Margin(1, Unit.Millimetre);
                        page.PageColor(Colors.White);
                        page.DefaultTextStyle(x => x.FontSize(7).FontFamily(Fonts.Arial));

                        // Estilos
                        int TituloFontsize = ConfigImpressions.Find(x => x.Name == "Titulo") != null ? Convert.ToInt32(ConfigImpressions.Find(x => x.Name == "Titulo").FontSize) : 9;
                        string TituloColor = CodigodeColor(ConfigImpressions.Find(x => x.Name == "Titulo")?.FontColor ?? "Black");
                        string TituloFontStyle = ConfigImpressions.Find(x => x.Name == "Titulo")?.FontStyle ?? "SemiBold";
                        var EstiloTitulo = ObtenerEstiloPersonalizado(TituloFontStyle, TituloFontsize, TituloColor);

                        int CompanyFontsize = ConfigImpressions.Find(x => x.Name == "Company") != null ? Convert.ToInt32(ConfigImpressions.Find(x => x.Name == "Company").FontSize) : 8;
                        string CompanyColor = CodigodeColor(ConfigImpressions.Find(x => x.Name == "Company")?.FontColor ?? "Black");
                        string CompanyFontStyle = ConfigImpressions.Find(x => x.Name == "Company")?.FontStyle ?? "Normal";
                        var EstiloCompany = ObtenerEstiloPersonalizado(CompanyFontStyle, CompanyFontsize, CompanyColor);

                        int RFCFontsize = ConfigImpressions.Find(x => x.Name == "RFC") != null ? Convert.ToInt32(ConfigImpressions.Find(x => x.Name == "RFC").FontSize) : 8;
                        string RFCColor = CodigodeColor(ConfigImpressions.Find(x => x.Name == "RFC")?.FontColor ?? "Black");
                        string RFCFontStyle = ConfigImpressions.Find(x => x.Name == "RFC")?.FontStyle ?? "Normal";
                        var EstiloRFC = ObtenerEstiloPersonalizado(RFCFontStyle, RFCFontsize, RFCColor);

                        int FechaFontsize = ConfigImpressions.Find(x => x.Name == "Fecha") != null ? Convert.ToInt32(ConfigImpressions.Find(x => x.Name == "Fecha").FontSize) : 8;
                        string FechaColor = CodigodeColor(ConfigImpressions.Find(x => x.Name == "Fecha")?.FontColor ?? "Black");
                        string FechaFontStyle = ConfigImpressions.Find(x => x.Name == "Fecha")?.FontStyle ?? "Normal";
                        var EstiloFecha = ObtenerEstiloPersonalizado(FechaFontStyle, FechaFontsize, FechaColor);

                        int TablaFontsize = ConfigImpressions.Find(x => x.Name == "Tabla") != null ? Convert.ToInt32(ConfigImpressions.Find(x => x.Name == "Tabla").FontSize) : 7;
                        string TablaColor = CodigodeColor(ConfigImpressions.Find(x => x.Name == "Tabla")?.FontColor ?? "Black");
                        string TablaFontStyle = ConfigImpressions.Find(x => x.Name == "Tabla")?.FontStyle ?? "Normal";
                        var EstiloTabla = ObtenerEstiloPersonalizado(TablaFontStyle, TablaFontsize, TablaColor);

                        // Encabezado
                        page.Header().Column(col =>
                        {
                            col.Item().AlignCenter().Text("TICKET " + venta.IdTicket.ToString()).Style(EstiloTitulo);
                            col.Item().AlignCenter().Text("VENTA EN LA CAJA " + venta.BoxName).Style(EstiloTitulo);
                            col.Item().AlignCenter().Text(venta.Company.Name).Style(EstiloCompany);
                            col.Item().AlignCenter().Text(venta.Company.RFC).Style(EstiloRFC);
                            col.Item().AlignCenter().Text(venta.Company.Address).Style(EstiloRFC);
                            col.Item().AlignCenter().Text(venta.Cliente).Style(EstiloRFC);
                            col.Item().AlignCenter().Text(DateTime.Now.ToString("dd/MM/yyyy HH:mm")).Style(EstiloFecha);
                            col.Item().PaddingVertical(1).LineHorizontal(0.5f);
                        });

                        // Contenido
                        page.Content().PaddingVertical(1).Column(mainCol =>
                        {
                            mainCol.Item().Table(table =>
                            {
                                table.ColumnsDefinition(columns =>
                                {
                                    columns.RelativeColumn(1.8f);
                                    columns.RelativeColumn(3.5f);
                                    columns.RelativeColumn(0.9f);
                                    columns.RelativeColumn(1.8f);
                                });

                                table.Header(header =>
                                {
                                    header.Cell().AlignLeft().Text("Código").Style(EstiloTabla).Bold();
                                    header.Cell().AlignLeft().Text("Descripción").Style(EstiloTabla).Bold();
                                    header.Cell().AlignCenter().Text("Cant").Style(EstiloTabla).Bold();
                                    header.Cell().AlignRight().Text("Total").Style(EstiloTabla).Bold();
                                    header.Cell().ColumnSpan(4).PaddingVertical(1).LineHorizontal(0.5f);
                                });

                                foreach (var item in venta.Articles)
                                {
                                    table.Cell().PaddingVertical(1).AlignLeft().Text(item.Code).Style(EstiloTabla);
                                    table.Cell().PaddingVertical(1).AlignLeft().Text(item.Name).Style(EstiloTabla);
                                    table.Cell().PaddingVertical(1).AlignCenter().Text(item.Stock.ToString(item.Decimals > 0 ? "N3" : "N0")).Style(EstiloTabla);
                                    table.Cell().PaddingVertical(1).AlignRight().Text(item.Total.ToString("C2")).Style(EstiloTabla);
                                }
                            });

                            // Totales y QR
                            int TotalFontsize = ConfigImpressions.Find(x => x.Name == "Total") != null ? Convert.ToInt32(ConfigImpressions.Find(x => x.Name == "Total").FontSize) : 8;
                            string TotalColor = CodigodeColor(ConfigImpressions.Find(x => x.Name == "Total")?.FontColor ?? "Black");
                            string TotalFontStyle = ConfigImpressions.Find(x => x.Name == "Total")?.FontStyle ?? "SemiBold";
                            var EstiloTotal = ObtenerEstiloPersonalizado(TotalFontStyle, TotalFontsize, TotalColor);

                            mainCol.Item().PaddingTop(2).Column(totalCol =>
                            {
                                totalCol.Item().LineHorizontal(0.5f);

                                decimal subTotal = 0;
                                if (venta.CostoEnvio > 0)
                                {
                                    subTotal = venta.Articles.Sum(x => x.Total) + venta.CostoEnvio;
                                    totalCol.Item().PaddingTop(2).AlignRight().Text($"TOTAL: {venta.Articles.Sum(x => x.Total):C2}").Style(EstiloTotal);
                                    totalCol.Item().AlignRight().Text($"ENVÍO: {venta.CostoEnvio:C2}").Style(EstiloTotal);
                                    totalCol.Item().AlignRight().Text($"TOTAL A PAGAR: {subTotal:C2}").Style(EstiloTotal);
                                }
                                else
                                {
                                    subTotal = venta.Articles.Sum(x => x.Total);
                                    totalCol.Item().PaddingTop(2).AlignRight().Text($"TOTAL: {subTotal:C2}").Style(EstiloTotal);
                                }

                                totalCol.Item().AlignRight().Text($"RECIBIDO: {venta.Recibido:C2}").Style(EstiloTotal);

                                decimal cambio = venta.Recibido - subTotal < 0 ? 0 : venta.Recibido - subTotal;
                                totalCol.Item().AlignRight().Text($"CAMBIO: {cambio:C2}").Style(EstiloTotal);

                                totalCol.Item().PaddingTop(4).AlignCenter().Text("¡Gracias por su compra!").Style(EstiloTabla);

                                if (qrBytes != null)
                                {
                                    totalCol.Item()
                                            .PaddingTop(4)
                                            .AlignCenter()
                                            .Width(45)
                                            .Image(qrBytes);
                                }
                            });
                        });
                    });
                });

                documento.GeneratePdf(rutaCompleta);

          
                System.Diagnostics.Process.Start(
                    new System.Diagnostics.ProcessStartInfo
                    {
                        FileName = rutaCompleta,
                        UseShellExecute = true
                    });

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
        //Este es para el checkBox
        public void ProcesarTicket(VentaModel venta)
        {
            if (venta.Imprimir)
            {
                // Ticket automático activado
                GenerarTicketEscPos(venta);
            }
          
        }

        public void GenerarTicketEscPos(VentaModel venta)
        {
           
            try
            {
                PrinterSettings settings = new PrinterSettings();
                string nombreImpresora = settings.PrinterName;
                using (MemoryStream ms = new MemoryStream())
                {
                    // Comandos ESC/POS Básicos
                    byte[] init = new byte[] { 0x1B, 0x40 };             // Inicializar impresora
                    byte[] alignCenter = new byte[] { 0x1B, 0x61, 0x01 }; // Alineación Centrada
                    byte[] alignLeft = new byte[] { 0x1B, 0x61, 0x00 };   // Alineación Izquierda
                    byte[] alignRight = new byte[] { 0x1B, 0x61, 0x02 };  // Alineación Derecha
                    byte[] fontBoldOn = new byte[] { 0x1B, 0x45, 0x01 };  // Negrita ON
                    byte[] fontBoldOff = new byte[] { 0x1B, 0x45, 0x00 }; // Negrita OFF
                    byte[] cutPaper = new byte[] { 0x1D, 0x56, 0x42, 0x00 }; // Comando de corte parcial

                    Encoding encoding = Encoding.GetEncoding(850); // CP850 para acentos y caracteres de español

                    // 1. Encabezado
                    ms.Write(init, 0, init.Length);
                    ms.Write(alignCenter, 0, alignCenter.Length);

                    EscribirTexto(ms, $"TICKET #{venta.IdTicket}\n", encoding);
                    EscribirTexto(ms, $"CAJA: {venta.BoxName}\n", encoding);

                    ms.Write(fontBoldOn, 0, fontBoldOn.Length);
                    EscribirTexto(ms, $"{venta.Company.Name}\n", encoding);
                    ms.Write(fontBoldOff, 0, fontBoldOff.Length);

                    EscribirTexto(ms, $"RFC: {venta.Company.RFC}\n", encoding);
                    EscribirTexto(ms, $"{venta.Company.Address}\n", encoding);
                    EscribirTexto(ms, $"CLIENTE: {venta.Cliente}\n", encoding);
                    //EscribirTexto(ms, $"{DateTime.Now:dd/MM/yyyy HH:mm}\n", encoding);
                    DateTime fechaTicket = venta.FechaVenta != default(DateTime)? venta.FechaVenta: DateTime.Now;
                    EscribirTexto( ms,  $"{fechaTicket:dd/MM/yyyy HH:mm}\n", encoding);
                    EscribirTexto(ms, "--------------------------------\n", encoding); // 32 guiones

                    // 2. Encabezado de la Tabla
                    ms.Write(alignLeft, 0, alignLeft.Length);
                    ms.Write(fontBoldOn, 0, fontBoldOn.Length);
                    // Formato de columnas para 32 caracteres totales: Cant(4) Desc(18) Total(10)
                    EscribirTexto(ms, "Cant Descripcion          Total\n", encoding);
                    ms.Write(fontBoldOff, 0, fontBoldOff.Length);
                    EscribirTexto(ms, "--------------------------------\n", encoding);

                    // 3. Artículos
                    foreach (var item in venta.Articles)
                    {
                        string cantidad = item.Stock.ToString(item.Decimals > 0 ? "N1" : "N0").PadRight(4);

                        string nombre = item.Name.Length > 18 ? item.Name.Substring(0, 18) : item.Name.PadRight(18);
                        string total = item.Total.ToString("C2").PadLeft(10);

                        EscribirTexto(ms, $"{cantidad}{nombre}{total}\n", encoding);
                    }

                    EscribirTexto(ms, "--------------------------------\n", encoding);

                    // 4. Totales
                    ms.Write(alignRight, 0, alignRight.Length);

                    decimal subTotal = venta.Articles.Sum(x => x.Total);
                    if (venta.CostoEnvio > 0)
                    {
                        EscribirTexto(ms, $"SUBTOTAL: {subTotal:C2}\n", encoding);
                        EscribirTexto(ms, $"ENVIO: {venta.CostoEnvio:C2}\n", encoding);
                        subTotal += venta.CostoEnvio;
                    }

                    ms.Write(fontBoldOn, 0, fontBoldOn.Length);
                    EscribirTexto(ms, $"TOTAL: {subTotal:C2}\n", encoding);
                    ms.Write(fontBoldOff, 0, fontBoldOff.Length);

                    EscribirTexto(ms, $"RECIBIDO: {venta.Recibido:C2}\n", encoding);
                    decimal cambio = venta.Recibido - subTotal < 0 ? 0 : venta.Recibido - subTotal;
                    EscribirTexto(ms, $"CAMBIO: {cambio:C2}\n", encoding);

                    // 5. Pie y Código QR en ESC/POS
                    ms.Write(alignCenter, 0, alignCenter.Length);
                    if (venta.EsReimpresion)
                    {
                        ms.Write(fontBoldOn, 0, fontBoldOn.Length);

                        EscribirTexto( ms,"\n*** REIMPRESION ***\n",encoding);ms.Write(fontBoldOff, 0, fontBoldOff.Length);
                        EscribirTexto(ms, $"Reimpreso: {venta.FechaReimpresion:dd/MM/yyyy HH:mm}\n",encoding);
                    }
                    EscribirTexto(ms, "\n¡Gracias por su compra!\n\n", encoding);

                    // Imprimir Código QR mediante comandos ESC/POS nativos (Soportado en POS-58)
                    byte[] qrImagenBytes = GenerarBitmapQrEscPos("https://facturacion.tiendasmino.com");
                    ms.Write(qrImagenBytes, 0, qrImagenBytes.Length);

                    // 6. Avance mínimo de papel justo para ver la impresión y cortar
                    EscribirTexto(ms, "\n\n\n", encoding);
                    ms.Write(cutPaper, 0, cutPaper.Length);

                    // Enviar impresión directa al spooler de Windows
                    byte[] buffer = ms.ToArray();
                    bool imprimio = true;
                    //for (int i = 0; i < (venta.Imprimir ? venta.Copias + 1 : 0); i++)
                    for (int i = 0; i < venta.Copias; i++)
                    {
                       if(RawPrinterHelper.SendBytesToPrinter(nombreImpresora, buffer))
                        {
                            imprimio = false;
                            break;                         
                        }
                    }
                    if (imprimio == false)
                    {
                        MessageBox.Show("Error al imprimir ticket revisar que tenga como predeterminada una impresora POS", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Impreso satisfactoriamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al imprimir ticket ESC/POS: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Métodos Auxiliares
        private void EscribirTexto(MemoryStream ms, string texto, Encoding encoding)
        {
            byte[] bytes = encoding.GetBytes(texto);
            ms.Write(bytes, 0, bytes.Length);
        }

        private byte[] GenerarBitmapQrEscPos(string data)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                // 1. Generar la imagen del QR en memoria usando QRCoder
                byte[] qrBytes = null;
                using (QRCodeGenerator qrGenerator = new QRCodeGenerator())
                using (QRCodeData qrCodeData = qrGenerator.CreateQrCode(data, QRCodeGenerator.ECCLevel.Q))
                using (PngByteQRCode qrCode = new PngByteQRCode(qrCodeData))
                {
                    // Un tamaño de módulo 4 a 5 es ideal para impresoras de 58mm
                    qrBytes = qrCode.GetGraphic(4);
                }

                // 2. Convertir la imagen a mapa de bits monocromático para ESC/POS (Comando GS v 0)
                using (Bitmap bitmap = new Bitmap(new MemoryStream(qrBytes)))
                {
                    int width = bitmap.Width;
                    int height = bitmap.Height;

                    // Comando ESC/POS Raster: GS v 0 0
                    byte[] command = new byte[] { 0x1D, 0x76, 0x30, 0x00 };
                    ms.Write(command, 0, command.Length);

                    // Ancho en bytes (ancho en píxeles / 8)
                    int xL = (width + 7) / 8;
                    byte[] xSize = BitConverter.GetBytes((short)xL);
                    byte[] ySize = BitConverter.GetBytes((short)height);

                    ms.WriteByte(xSize[0]);
                    ms.WriteByte(xSize[1]);
                    ms.WriteByte(ySize[0]);
                    ms.WriteByte(ySize[1]);

                    // Transformar píxeles oscuros en bits 1s y claros en 0s
                    for (int y = 0; y < height; y++)
                    {
                        for (int x = 0; x < xL; x++)
                        {
                            byte b = 0;
                            for (int bit = 0; bit < 8; bit++)
                            {
                                int xPos = x * 8 + bit;
                                if (xPos < width)
                                {
                                    System.Drawing.Color pixel = bitmap.GetPixel(xPos, y);
                                    if (pixel.R < 128 || pixel.G < 128 || pixel.B < 128)
                                    {
                                        b |= (byte)(0x80 >> bit);
                                    }
                                }
                            }
                            ms.WriteByte(b);
                        }
                    }
                }
                return ms.ToArray();
            }
        }
    }
}
