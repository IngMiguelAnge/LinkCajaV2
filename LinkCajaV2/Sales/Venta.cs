using LinkCajaV2.Catalogs;
using LinkCajaV2.Configuraciones;
using LinkCajaV2.Data;
using LinkCajaV2.Items;
using LinkCajaV2.Model;
using LinkCajaV2.Reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Net.Http;
using System.Net.Http.Json;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using Color = System.Drawing.Color;

namespace LinkCajaV2.Sales
{
    public partial class Venta : System.Windows.Forms.Form
    {
        private SoundPlayer lectorSonido;
        public int IdUsuario { get; set; }
        public string NameUser { get; set; }
        public int IdTypeUser { get; set; }
        private CompanyModel Empresa { get; set; }
        private int IdBox { get; set; }
        private string BoxName { get; set; }
        public Venta()
        {
            InitializeComponent();
        }
        private void btnPanelVentas_Click(object sender, EventArgs e)
        {
            NuevaVenta();
        }
        private void btnPanelArticulos_Click(object sender, EventArgs e)
        {
            Articles a = new Articles();
            a.IdUsuario = IdUsuario;
            a.NameUser = NameUser;
            a.IsVenta = false;
            a.Show();
            this.Hide();
        }

        private void btnPanelEmpresa_Click(object sender, EventArgs e)
        {
            Company m = new Company();
            m.Show();
        }

        private void btnPanelCorte_Click(object sender, EventArgs e)
        {
            CashDrop c = new CashDrop();
            c.Show();
        }
        private void BtnPanelSalir_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
        private void btnPanelMenu_Click(object sender, EventArgs e)
        {
            Menu m = new Menu();
            m.IdUsuario = IdUsuario;
            m.NameUser = NameUser;
            m.Show();
            this.Hide();
        }

        private void Venta_Load(object sender, EventArgs e)
        {
            if (IdTypeUser == 2)//Vendedor
            {
                //Menu lateral
                btnPanelEmpresa.Visible = false;
                btnPanelCorte.Visible = false;
            }
            if (IdTypeUser == 3)//Almacenista
            {
                //Menu lateral
                btnPanelEmpresa.Visible = false;
                btnPanelCorte.Visible = false;
                btnPanelVentas.Visible = false;
            }
            AppRepository obj = new AppRepository();
            KeysModel ListKeys = obj.GetKeys().Result.FirstOrDefault();
            if (ListKeys == null)
            {
                MessageBox.Show("No se encontraron licencia activa. Contacta al soporte.", "Licencia no encontrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            HardwareID hardwareID = new HardwareID();
            string Hard = hardwareID.ObtenerHardwareID();
            var box = obj.GetBoxsbyHardwareID(Hard).Result;
            if (box == null || box.Estatus == "Inactivo")
            {
                MessageBox.Show("Licencia no válida para esta máquina. Contacta al soporte.", "Licencia no válida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            var fund = obj.GetCashfundbyHardwareID(Hard).Result;
            if (fund == null)
            {
                MessageBox.Show("Fondo de caja no encontrado para esta máquina. Contacta al administrador.", "Fondo de caja no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            IdBox = box.Id;
            BoxName = box.Name;
            string ruta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Sounds", "beep.wav");
            lectorSonido = new SoundPlayer(ruta);
            lblUsuario.Text = "Bien venido " + NameUser;

            Empresa = obj.GetCompany().Result;
            if (Empresa != null)
            {
                lblNombreEmpresa.Text = Empresa.Name;
                if (Empresa.Logo != null)
                {
                    using (MemoryStream ms = new MemoryStream(Empresa.Logo))
                    {
                        PBLogo.Image = Image.FromStream(ms);
                        PBLogo.SizeMode = PictureBoxSizeMode.Zoom;
                    }
                }
            }
            else
            {
                MessageBox.Show("No se encontraron datos de la empresa.", "Datos de empresa no encontrados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            CrearGridView();
        }
        public void CrearGridView()
        {
            dgvArticulos.Columns.Clear();
            dgvArticulos.AutoGenerateColumns = false;
            dgvArticulos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Id",
                HeaderText = "Id",
                DataPropertyName = "IdArticle",
                ReadOnly = true,
                Visible = false,
                Width = 100
            });
            dgvArticulos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "CodeSAT",
                HeaderText = "CodeSAT",
                DataPropertyName = "CodeSAT",
                ReadOnly = true,
                Visible = false,
                Width = 100
            });
            dgvArticulos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "NamePresentation",
                HeaderText = "NamePresentation",
                DataPropertyName = "NamePresentation",
                ReadOnly = true,
                Visible = false,
                Width = 100
            });
            dgvArticulos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Decimals",
                HeaderText = "Decimals",
                DataPropertyName = "Decimals",
                ReadOnly = true,
                Visible = false,
                Width = 100
            });
            dgvArticulos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "UnitSAT",
                HeaderText = "UnitSAT",
                DataPropertyName = "UnitSAT",
                ReadOnly = true,
                Visible = false,
                Width = 100
            });
            dgvArticulos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Codigo",
                HeaderText = "Código",
                DataPropertyName = "Code",
                ReadOnly = true,
                Width = 100
            });
            dgvArticulos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Nombre",
                HeaderText = "Nombre",
                DataPropertyName = "Name",
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            });
            dgvArticulos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Cantidad",
                HeaderText = "Cantidad",
                DataPropertyName = "Stock",
                ReadOnly = false, // Aquí permites la edición
                Width = 80
            });
            dgvArticulos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Presentacion",
                HeaderText = "Presentación",
                DataPropertyName = "Presentation",
                ReadOnly = true, // Aquí permites la edición
                Width = 80
            });

            dgvArticulos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Precio",
                HeaderText = "Precio",
                DataPropertyName = "Price",
                DefaultCellStyle = { Format = "C4" },
                ReadOnly = true, // Aquí permites la edición
                Width = 80
            });
            dgvArticulos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Total",
                HeaderText = "Total",
                DataPropertyName = "Total",
                DefaultCellStyle = { Format = "C2" },
                ReadOnly = true, // Aquí permites la edición
                Width = 80
            });
            dgvArticulos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Medicine",
                HeaderText = "Medicine",
                DataPropertyName = "Medicine",
                ReadOnly = true,
                Visible = false,
                Width = 100
            });
            DataGridViewButtonColumn btnEliminar = new DataGridViewButtonColumn
            {
                Name = "Quitar",
                HeaderText = "Acción",
                Text = "Quitar",
                UseColumnTextForButtonValue = true, // Para que todos los botones digan "Quitar"
                Width = 90,
                FlatStyle = FlatStyle.Flat,
            };
            btnEliminar.DefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);
            btnEliminar.DefaultCellStyle.ForeColor = Color.FromArgb(108, 117, 125);

            dgvArticulos.Columns.Add(btnEliminar);
            dgvArticulos.AllowUserToAddRows = false;
        }
        private void txtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                lectorSonido.Play(); // Reproducción instantánea sin lag
                e.SuppressKeyPress = true;
                AgregarArticulo(0, txtCodigo.Text);
                txtCodigo.Clear();
            }
        }
        public async void AgregarArticulo(int id, string codigo)
        {
            AppRepository obj = new AppRepository();

            // Usamos await en lugar de .Result para evitar bloqueos
            var articulo = await obj.GetArticleActive(id, codigo);

            if (articulo == null)
            {
                MessageBox.Show("Código no válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (articulo.Status == false)
            {
                MessageBox.Show("El artículo no está activo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Manejo de Imagen
            if (articulo.Image != null)
            {
                using (MemoryStream ms = new MemoryStream(articulo.Image))
                {
                    PBProducto.Image = Image.FromStream(ms);
                    PBProducto.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
            var bindingList = (BindingList<ArticlesSalesModel>)dgvArticulos.DataSource;

            // Si la lista no existe (porque es el primer artículo), la inicializamos
            if (bindingList == null)
            {
                bindingList = new BindingList<ArticlesSalesModel>();
                dgvArticulos.DataSource = bindingList;
            }
            var presentacion = await obj.GetPresentationbyId(articulo.IdPresentation);
            decimal cantidadEntrante = NUDCantidad.Value;
            decimal precioCalculado = articulo.Price;

            // Lógica de decimales/granel
            if (presentacion.Decimals > 0)
            {
                Decimals d = new Decimals();
                d.Presentation = presentacion.Presentation;
                d.Name = presentacion.Name;
                if (d.ShowDialog() == DialogResult.OK) // Asumiendo que devuelve OK
                {
                    cantidadEntrante = d.Kilos;
                    if (articulo.SuggestedStock > 0)
                    {
                        precioCalculado = articulo.Price / (articulo.SuggestedStock * 1000);
                    }
                }
                else
                {
                    return; // Si el usuario cancela, no agregamos el artículo
                }
            }

            // BUSCAR SI YA EXISTE EN LA LISTA
            var articuloExistente = bindingList.FirstOrDefault(x => x.Code == articulo.Code);

            if (articuloExistente != null)
            {
                // Si existe, solo actualizamos la cantidad
                articuloExistente.Stock += cantidadEntrante;
                if (articulo.Stock < articuloExistente.Stock)
                {
                    MessageBox.Show($"Stock insuficiente.", "Error de stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                // La BindingList no avisa automáticamente si cambia una propiedad interna, 
                // así que refrescamos el item.
                bindingList.ResetBindings();
            }
            else
            {
                if (articulo.Stock < cantidadEntrante)
                {
                    MessageBox.Show($"Stock insuficiente.", "Error de stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                // Si no existe, agregamos uno nuevo
                bindingList.Add(new ArticlesSalesModel
                {
                    IdArticle = articulo.Id,
                    Code = articulo.Code,
                    Name = articulo.Name,
                    Stock = cantidadEntrante,
                    IdPresentation = articulo.IdPresentation,
                    NamePresentation = presentacion.Name,
                    Presentation = articulo.Presentation,
                    Price = precioCalculado,
                    Decimals = presentacion.Decimals,
                    Image = articulo.Image,
                    CodeSAT = articulo.CodeSAT,
                    UnitSAT = presentacion.UnitSAT,
                    Medicine = articulo.Medicine
                });
            }

            ActualizarTotalGeneral();
            foreach (DataGridViewRow row in dgvArticulos.Rows)
            {
                row.DefaultCellStyle.BackColor = Color.White;
            }

            var fila = dgvArticulos.Rows.Cast<DataGridViewRow>()
                        .FirstOrDefault(r => r.Cells["Codigo"].Value.ToString() == articulo.Code);

            if (fila != null)
            {
                fila.DefaultCellStyle.BackColor = Color.PaleGreen;
                dgvArticulos.ClearSelection(); // Quita el azul de selección para que se note el verde
                dgvArticulos.FirstDisplayedScrollingRowIndex = fila.Index;
            }
        }
        private void ActualizarTotalGeneral()
        {
            var bindingList = (BindingList<ArticlesSalesModel>)dgvArticulos.DataSource;
            if (bindingList != null)
            {
                decimal totalGeneral = bindingList.Sum(item => item.Total);
                lblTotal.Text = $"Total {totalGeneral:C2}";
            }
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Articles article = new Articles();
            article.IsVenta = true;
            if (article.ShowDialog() == DialogResult.OK)
            {
                AgregarArticulo(article.IdSeleccionado, string.Empty);
                txtCodigo.Clear();
            }

        }
        private void Venta_Shown(object sender, EventArgs e)
        {
            txtCodigo.Focus();
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            NuevaVenta();
        }
        public void NuevaVenta()
        {
            var bindingList = (BindingList<ArticlesSalesModel>)dgvArticulos.DataSource;
            bindingList?.Clear();
            ActualizarTotalGeneral();

            PBProducto.Image = null;
            NUDCantidad.Value = 1;
        }
        private void dgvArticulos_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            // 1. Solo validamos la columna "Cantidad"
            if (dgvArticulos.Columns[e.ColumnIndex].Name == "Cantidad")
            {
                string valor = e.FormattedValue.ToString();

                // 2. Si la celda está vacía, no hacemos nada (o podrías poner e.Cancel = true si es obligatorio)
                if (string.IsNullOrEmpty(valor)) return;

                // 3. Intentamos convertir a decimal
                if (!decimal.TryParse(valor, out decimal resultado))
                {
                    MessageBox.Show("Por favor, ingresa una cantidad válida", "Error de formato");
                    e.Cancel = true;
                    return;
                }

                // 4. VALIDACIÓN DE ORO: Miramos los decimales permitidos del OBJETO en esta fila
                var item = (ArticlesSalesModel)dgvArticulos.Rows[e.RowIndex].DataBoundItem;

                if (item != null && item.Decimals == 0) // Es modo piezas
                {
                    // Verificamos si el número ingresado tiene parte decimal
                    if (resultado % 1 != 0)
                    {
                        MessageBox.Show("Este artículo no permite decimales.", "Validación");
                        e.Cancel = true;
                    }
                }
            }
        }
        private void dgvArticulos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // 1. Validaciones iniciales
            if (e.RowIndex < 0 || dgvArticulos.Columns[e.ColumnIndex].Name != "Cantidad") return;

            // 2. Manejo del punto inicial (".5" -> "0.5")
            string valor = dgvArticulos.Rows[e.RowIndex].Cells["Cantidad"].Value?.ToString() ?? "0";
            if (valor.StartsWith("."))
            {
                dgvArticulos.CellValueChanged -= dgvArticulos_CellValueChanged;
                dgvArticulos.Rows[e.RowIndex].Cells["Cantidad"].Value = "0" + valor;
                dgvArticulos.CellValueChanged += dgvArticulos_CellValueChanged;
            }

            dgvArticulos.InvalidateRow(e.RowIndex);

            ActualizarTotalGeneral();
        }
        private void dgvArticulos_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex == dgvArticulos.Columns["Cantidad"].Index && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                // Dibujamos un borde gris oscuro simulando un TextBox
                using (System.Drawing.Pen p = new System.Drawing.Pen(System.Drawing.Color.Gray, 1))
                {
                    Rectangle rect = e.CellBounds;
                    rect.Width -= 2;
                    rect.Height -= 2;
                    e.Graphics.DrawRectangle(p, rect);
                }

                e.Handled = true;
            }
        }
        private void dgvArticulos_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dgvArticulos.CurrentCell.ColumnIndex == dgvArticulos.Columns["Cantidad"].Index)
            {
                TextBox txt = e.Control as TextBox;
                if (txt != null)
                {
                    txt.KeyPress -= Cantidad_KeyPress;
                    txt.KeyPress += Cantidad_KeyPress;
                }
            }
        }
        private void Cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txt = sender as TextBox;

            // Obtenemos el formato actual de la columna para saber si permitimos puntos
            string formato = dgvArticulos.Columns["Cantidad"].DefaultCellStyle.Format;

            // 1. Si el formato es "0" (Piezas), BLOQUEAMOS el punto decimal completamente
            if (formato == "0")
            {
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                    return;
                }
            }
            // 2. Si el formato permite decimales ("0.000")
            else
            {
                if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
                {
                    // Controlar que no meta más de 3 decimales
                    if (txt.Text.Contains(".") && !char.IsControl(e.KeyChar))
                    {
                        string[] partes = txt.Text.Split('.');
                        if (partes[1].Length >= 3 && txt.SelectionLength == 0)
                        {
                            e.Handled = true;
                        }
                    }
                }
                else if (e.KeyChar == '.')
                {
                    // Solo un punto permitido
                    e.Handled = txt.Text.Contains(".");
                }
                else
                {
                    e.Handled = true;
                }
            }
        }
        private void dgvArticulos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            switch (dgvArticulos.Columns[e.ColumnIndex].Name)
            {
                case "Quitar":
                    // 2. Obtener la lista que está enlazada al Grid
                    var bindingList = (BindingList<ArticlesSalesModel>)dgvArticulos.DataSource;

                    if (bindingList != null)
                    {
                        // 3. Borrar el objeto de la lista (el Grid se actualiza solo)
                        bindingList.RemoveAt(e.RowIndex);

                        // 4. Recalcular el total que muestras en el Label
                        ActualizarTotalGeneral();
                    }
                    break;
            }
        }
        private async void btnPagar_Click(object sender, EventArgs e)
        {
            var bindingList = (BindingList<ArticlesSalesModel>)dgvArticulos.DataSource;

            if (bindingList == null || bindingList.Count == 0)
            {
                MessageBox.Show("No hay artículos para vender.");
                return;
            }

            ConfirmPay c = new ConfirmPay();
            c.Total = bindingList.Sum(x => x.Total);
            if (c.ShowDialog() == DialogResult.OK)
            {
                decimal TotalReal = bindingList.Sum(x => x.Total);
                VentaModel venta = new VentaModel
                {
                    Articles = bindingList,
                    Copias = NUDCopias.Value,
                    Company = Empresa,
                    Imprimir = CBImprimir.Checked,
                    Recibido = c.Recibido,
                    IdTicket = 0,
                    Cliente = "Publico General",
                    BoxName = BoxName,
                    Total = TotalReal,
                    Title = string.Empty
                };
  
                TicketModel Ticket = new TicketModel
                {
                    Id = 0,
                    IdUser = IdUsuario,
                    IdClient = 1,//Clliente general por ahora                  
                    CreateDate = DateTime.Now,
                    Lastmodification = DateTime.Now,    
                    Status = true,
                    IdBox = IdBox,
                    Total = TotalReal,
                    TotalReturn = 0,
                    Send = false,
                };

                AppRepository obj = new AppRepository();
                Ticket.Id = obj.SaveTicket(Ticket).Result;
                if (Ticket.Id == 0)
                {
                    MessageBox.Show("Error al guardar la venta. Intenta de nuevo.");
                    return;
                }
                venta.IdTicket = Ticket.Id;
                DetailsTicketModel Details = new DetailsTicketModel();
                BillingDetails billing = new BillingDetails();
                venta.Title= "TKT" + Empresa.BillingName.Trim() + "-" + DateTime.Now.Year.ToString() + "-" + Ticket.Id.ToString();
                billing.pos_ticket_id = venta.Title;
                billing.form_payment = "01"; // Ejemplo: 01 = Efectivo, 02= Cheque nominativo, 03 = transferencia electronica
                billing.total = TotalReal.ToString();//venta.Articles.Sum(x => x.Total).ToString("F2");
                billing.serie = "A";
                billing.folio = Ticket.Id.ToString();
                billing.currency = "MXN";
                billing.exchange_rate = null;
                billing.exportacion = "01"; // Ejemplo: 01 = No exportación, 02 = Exportación definitiva, 03 = Exportación temporal
                billing.payment_method = "PUE"; // Ejemplo: PUE = Pago en una sola exhibición, PPD = Pago en parcialidades o diferido
                billing.payment_conditions = null;
                billing.issuing_location = Empresa.CP.ToString();
                billing.sold_at = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss");

                billing.concepts = new List<concepts>();
                foreach (var item in venta.Articles)
                {
                    Details.Id = 0;
                    Details.IdTicket = Ticket.Id;
                    Details.IdArticle = item.IdArticle;
                    Details.IdPresentation = item.IdPresentation;
                    Details.StockSold = item.Stock;//Cantidad vendida
                    Details.PriceSold = item.Price;//Valor unitario
                    Details.TotalSold = item.Total;
                    Details.Rate = item.Medicine == false ? "0.160000" : "0.000000";
                    Details.Amount = item.Medicine == false ? item.Total * 0.16m : 0m;
                    await obj.SaveDetailsTicket(Details);
                    List<taxes> Listtaxes = new List<taxes>();
                    Listtaxes.Add(new taxes
                    {
                        tax_type = "traslado",
                        @base = item.Total,
                        tax = "002",
                        type_factor = "Tasa",
                        rate = item.Medicine == false ? "0.160000" : "0.000000",
                        amount = item.Medicine == false ? item.Total * 0.16m : 0m   
                    });
                    billing.concepts.Add(
                    new concepts
                    {
                        clave_prod_serv = item.CodeSAT,
                        no_identificacion = item.Code,
                        quantity = item.Stock,
                        clave_unidad = item.UnitSAT,
                        unit = item.NamePresentation,
                        description = item.Name,
                        unit_value = item.Price,
                        amount = item.Total,
                        discount = null,
                        object_tax = "02",
                        taxes=Listtaxes
                    });
                }
                ImpressionsGeneral im = new ImpressionsGeneral();
                im.GenerarTicket(venta);

                BillingMethods Facturacion = new BillingMethods();
                string mensaje = string.Empty;
                RespuestaFactureModel Enviado = await Facturacion.EnviarFactura(billing);
                bool result = obj.ConfirmSend(Ticket.Id, Enviado).Result;
                if (Enviado.Exito == true)
                    MessageBox.Show("Venta realizada con éxito.");
                else MessageBox.Show("Venta realizada con éxito. Pero fallo el envio consultar con soporte");
                NuevaVenta();
            }
        }
     
        private void btnVerTickets_Click(object sender, EventArgs e)
        {
            Tickets t = new Tickets();
            t.IdUsuario = IdUsuario;
            t.NameUser = NameUser;
            t.IdTypeUser = IdTypeUser;
            t.ShowDialog();
        }
        private void dgvArticulos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var item = (ArticlesSalesModel)dgvArticulos.Rows[e.RowIndex].DataBoundItem;

            if (item != null)
            {
                if (item.Image != null)
                {
                    using (MemoryStream ms = new MemoryStream(item.Image))
                    {
                        PBProducto.Image = Image.FromStream(ms);
                        PBProducto.SizeMode = PictureBoxSizeMode.Zoom;
                    }
                }
                else
                {
                    // 4. Si no tiene imagen, poner una por defecto o limpiar
                    PBProducto.Image = null; // O poner una imagen de "Sin imagen"
                }
            }
        }

        private void Venta_FormClosed(object sender, FormClosedEventArgs e)
        {
            Menu m = new Menu();
            m.IdUsuario = IdUsuario;
            m.NameUser = NameUser;
            m.IdTypeUser = IdTypeUser;
            m.Show();
            this.Hide();
        }

        private void btnPanelMenu_Click_1(object sender, EventArgs e)
        {
            Menu m = new Menu();
            m.IdUsuario = IdUsuario;
            m.NameUser = NameUser;
            m.IdTypeUser = IdTypeUser;
            m.Show();
            this.Hide();
        }
    }
}
