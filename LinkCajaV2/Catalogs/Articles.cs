using LinkCajaV2.Data;
using LinkCajaV2.Model;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using static QuestPDF.Helpers.Colors;

namespace LinkCajaV2.Catalogs
{
    public partial class Articles : Form
    {
        public int Id { get; set; }
        public bool IsVenta { get; set; } = false;
        public bool IsReceta { get; set; } = false;
        public int IdSeleccionado { get; set; }
        private List<ListArticlesModel> ListaImprimir { get; set; }
        public bool Impresion = false;
        ConfigBoxModel ConfigBox;
        List<ListConfigImpressionsModel> ConfigImpressions;
        public Articles()
        {
            InitializeComponent();
        }

        private async void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Trim() == "" && txtCodigo.Text.Trim() == "")
            {
                DialogResult resultado = MessageBox.Show("Ha dejado el campo vacio, esto buscara a todos los articulos pero puede demorar ¿Quiere continuar?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.No)
                {
                    return;
                }       
            }
            Impresion = false;
           await BuscarArticulos();
        }
        public async Task BuscarArticulos()
        {
            progressBar1.Style = ProgressBarStyle.Marquee; // La barra empieza a moverse sola
            progressBar1.MarqueeAnimationSpeed = 30; // Velocidad de la animación
            btnNuevo.Enabled = false;
            BtnBuscar.Enabled = false;
            BtnImpresion2.Enabled = false;
            if (Impresion == false)
            {
                dgvArticulos.DataSource = null;
                dgvArticulos.Columns.Clear();
            }
         
            try
            {
                AppRepository obj = new AppRepository();
                var lista = await Task.Run(() => IsVenta == false ?
                obj.GetArticles(txtCodigo.Text, txtNombre.Text, IsReceta) :
                obj.GetArticlesActives(txtCodigo.Text, txtNombre.Text)
                );
                if (Impresion == false)
                    dgvArticulos.DataSource = lista != null && lista.Count > 0 ? lista : null;
                else
                    ListaImprimir = lista;
                if (lista == null || lista.Count == 0)
                {
                    MessageBox.Show("No se encontraron articulos.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    if (Impresion == false)
                    {
                        AgregarBotones();
                        MessageBox.Show("Carga completa", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }                  
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                progressBar1.Style = ProgressBarStyle.Blocks;
                progressBar1.Value = 0;
                btnNuevo.Enabled = true;
                BtnBuscar.Enabled = true;
                BtnImpresion2.Enabled = true;
            }
        }

        private async void btnNuevo_Click(object sender, EventArgs e)
        {
            Article m = new Article();
            m.Id = 0;
            m.ShowDialog();
            await BuscarArticulos();
        }

        private async void dgvArticulos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Evitar errores si hacen click en el encabezado
            if (e.RowIndex < 0) return;
            var Id = dgvArticulos.Rows[e.RowIndex].Cells["Id"].Value;

            switch (dgvArticulos.Columns[e.ColumnIndex].Name)
            {
                case "btnEditar":
                    Article m = new Article();
                    m.Id = Convert.ToInt32(Id);
                    m.ShowDialog();
                    await BuscarArticulos();
                    break;
                case "btnAsignar":
                    this.IdSeleccionado = Convert.ToInt32(Id);
                    // 2. Indicamos que la operación fue exitosa
                    this.DialogResult = DialogResult.OK;
                    break;
                case "btnCambiar":
                    AppRepository obj = new AppRepository();
                    await obj.UpdateStatusArticle(Convert.ToInt32(Id));
                    await BuscarArticulos();
                    break;
                case "btnStock":
                    Stock s = new Stock();
                    s.IdArticle = Convert.ToInt32(Id);
                    s.Nombre = dgvArticulos.Rows[e.RowIndex].Cells["Articulo"].Value.ToString();
                    s.ShowDialog();
                    await BuscarArticulos();
                    break;
                case "btnProveedores":
                    PricesSuppliers pr = new PricesSuppliers();
                    pr.IdArticle = Convert.ToInt32(Id);
                    pr.ShowDialog();
                    await BuscarArticulos();
                    break;
            }
        }
        private void AgregarBotones()
        {
            if (IsVenta || IsReceta)
            {
                DataGridViewButtonColumn btnAsignar = new DataGridViewButtonColumn();
                btnAsignar.Name = "btnAsignar";
                btnAsignar.HeaderText = "Acción";
                btnAsignar.Text = "Asignar";
                btnAsignar.UseColumnTextForButtonValue = true;
                dgvArticulos.Columns.Add(btnAsignar);
                return;
            }
            DataGridViewButtonColumn btnEditar = new DataGridViewButtonColumn();
            btnEditar.Name = "btnEditar";
            btnEditar.HeaderText = "Acción";
            btnEditar.Text = "Editar";
            btnEditar.UseColumnTextForButtonValue = true;
            dgvArticulos.Columns.Add(btnEditar);
            DataGridViewButtonColumn btnCambiar = new DataGridViewButtonColumn();
            btnCambiar.Name = "btnCambiar";
            btnCambiar.HeaderText = "Acción";
            btnCambiar.Text = "Cambiar Estatus";
            btnCambiar.UseColumnTextForButtonValue = true;
            dgvArticulos.Columns.Add(btnCambiar);
            DataGridViewButtonColumn btnProveedores = new DataGridViewButtonColumn();
            btnProveedores.Name = "btnProveedores";
            btnProveedores.HeaderText = "Acción";
            btnProveedores.Text = "Proveedores";
            btnProveedores.UseColumnTextForButtonValue = true;
            dgvArticulos.Columns.Add(btnProveedores);
            DataGridViewButtonColumn btnStock = new DataGridViewButtonColumn();
            btnStock.Name = "btnStock";
            btnStock.HeaderText = "Acción";
            btnStock.Text = "Stock";
            btnStock.UseColumnTextForButtonValue = true;
            dgvArticulos.Columns.Add(btnStock);
        }

        private void Articles_Load(object sender, EventArgs e)
        {
            if (IsVenta || IsReceta)
            {
                btnNuevo.Visible = false;
                btnImprimir.Visible = false;
            }
        }

        private async void btnImprimir_Click(object sender, EventArgs e)
        {
            AppRepository obj = new AppRepository();
            var lista = await Task.Run(() =>
              obj.GetArticles(txtCodigo.Text, txtNombre.Text, IsReceta)
              );
            try
            {
                QuestPDF.Settings.License = LicenseType.Community;

                // 1. Definimos una ruta clara (en la carpeta del programa)
                string nombreArchivo = "Lista de precios.pdf";
                string rutaCompleta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory + "\\Impresiones", nombreArchivo);

                // 2. Crear el documento
                var documento = Document.Create(container =>
                {
                    container.Page(page =>
                    {
                        page.Size(PageSizes.A4);
                        page.Margin(1, Unit.Centimetre);
                        page.PageColor(Colors.White);

                        page.Content().Table(table =>
                        {
                            table.ColumnsDefinition(columns =>
                            {
                                columns.RelativeColumn(); //Ancho fijo ConstantColumn(80) o relativo RelativeColumn()
                                columns.RelativeColumn();
                                columns.RelativeColumn();
                                columns.RelativeColumn();
                            });

                            table.Header(header =>
                            {
                                header.Cell().Element(CellStyle).Text("Código");
                                header.Cell().Element(CellStyle).Text("Nombre");
                                header.Cell().Element(CellStyle).Text("Por cada");
                                header.Cell().Element(CellStyle).Text("Precio");
                            });

                            foreach (var item in lista)
                            {
                                table.Cell().Element(ContentStyle).Text(item.Codigo);
                                table.Cell().Element(ContentStyle).Text(item.Articulo);
                                table.Cell().Element(ContentStyle).Text(item.PorCada);
                                table.Cell().Element(PriceCellStyle).Text(item.Precio.ToString("C"));

                            }
                        });
                    });
                });

                // 3. ¡IMPORTANTE! Guardar el archivo
                documento.GeneratePdf(rutaCompleta);

                // 4. Mostrar mensaje de éxito y abrir archivo
                //MessageBox.Show("PDF Generado con éxito en: " + rutaCompleta);
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(rutaCompleta) { UseShellExecute = true });
            }
            catch (Exception ex)
            {
                // Esto te dirá si el error es por permisos, si el archivo está abierto, etc.
                MessageBox.Show("Error al crear PDF: " + ex.Message);
            }
        }

        // 2. Métodos privados fuera del método anterior pero dentro de la misma clase
        private IContainer CellStyle(IContainer container)
        {
            return container.DefaultTextStyle(x => x.SemiBold())
                            .PaddingVertical(5)
                            .BorderBottom(1)
                            .BorderColor(Colors.Black);
        }

        private IContainer ContentStyle(IContainer container)
        {
            return container.PaddingVertical(5)
                            .BorderBottom(0.5f)
                            .BorderColor(Colors.Grey.Lighten2);
        }
        private IContainer PriceCellStyle(IContainer container)
        {
            return container
                .Border(0.5f)                    // Dibuja el recuadro
                .BorderColor(Colors.Grey.Medium) // Color de la línea
                .PaddingHorizontal(5)            // Margen interno para que el texto no toque la línea
                .AlignRight()                    // Alinea el número a la derecha
                .AlignMiddle();                  // Centra verticalmente
        }

        private async void BtnImpresion2_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Trim() == "" && txtCodigo.Text.Trim() == "")
            {
                DialogResult resultado = MessageBox.Show("Ha dejado el campo vacio, esto buscara a todos los articulos pero puede demorar ¿Quiere continuar?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.No)
                {
                    return;
                }
            }
            Impresion = true;
            await BuscarArticulos();
            try
            {
                if (ListaImprimir == null || ListaImprimir.Count == 0)
                {
                    MessageBox.Show("No hay artículos para mostrar en el PDF.");
                    return;
                }

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
                            page.Size((float)ConfigBox.WidthPage * MM, (float)ConfigBox.HitghtPage * MM);//88mm X 250mm
                            page.Margin(2f * MM);
                        }                                              

                        page.PageColor(Colors.White);

                        int TituloFontsize = ConfigImpressions.Find(x => x.Name == "Titulo") != null ? Convert.ToInt32(ConfigImpressions.Find(x => x.Name == "Titulo").FontSize) : 16;
                        string TituloColor = ConfigImpressions.Find(x => x.Name == "Titulo") != null ? ConfigImpressions.Find(x => x.Name == "Titulo").FontColor : "Black";
                        TituloColor = CodigodeColor(TituloColor);
                        string TituloFontStyle = ConfigImpressions.Find(x => x.Name == "Titulo") != null ? ConfigImpressions.Find(x => x.Name == "Titulo").FontStyle : "SemiBold";
                        var EstiloTitulo = ObtenerEstiloPersonalizado(TituloFontStyle,TituloFontsize,TituloColor);
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

                            foreach (var item in ListaImprimir)
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
        private void DibujarCuadroArticulo(IContainer container, string nombre, decimal precio, TextStyle EstiloArticulo, TextStyle EstiloPrecio)
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
    }
}
