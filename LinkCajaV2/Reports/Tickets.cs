using LinkCajaV2.Catalogs;
using LinkCajaV2.Configuraciones;
using LinkCajaV2.Data;
using LinkCajaV2.Items;
using LinkCajaV2.Model;
using LinkCajaV2.Sales;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Forms;
using static QuestPDF.Helpers.Colors;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace LinkCajaV2.Reports
{
    public partial class Tickets : System.Windows.Forms.Form
    {
        public int IdUsuario { get; set; }
        public string NameUser { get; set; }
        public int IdTypeUser { get; set; }
        private CompanyModel Empresa { get; set; }
        private bool _procesandoAccion = false;
        public Tickets()
        {
            InitializeComponent();
        }
        private void btnPanelVentas_Click(object sender, EventArgs e)
        {
            Venta s = new Venta();
            s.IdUsuario = IdUsuario;
            s.NameUser = NameUser;
            s.IdTypeUser = IdTypeUser;
            s.Show();
            this.Hide();
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
            m.IdTypeUser = IdTypeUser;
            m.Show();
            this.Hide();
        }

        public async void Buscar()
        {
            CrearGridView();
            bool fechaCreacion = RBCreacion.Checked;
            AppRepository obj = new AppRepository();

            try
            {
                var Tickets = await obj.GetTickets((int)NUDTicket.Value, dtDesde.Value, dtHasta.Value, fechaCreacion);
                var listaFinal = Tickets?.ToList() ?? new List<ListTicketModel>();
                dgvTickets.DataSource = new BindingList<ListTicketModel>(listaFinal);
                decimal totalGeneral = listaFinal.Sum(item => item.Total);
                decimal devoluciones = listaFinal.Sum(item => item.TotalReturn);
                decimal totalFinal = listaFinal.Sum(item => item.TotalEnd);
                lblVenta.Text = $"Venta total: {totalGeneral:C2}";
                lblTotalDevolucion.Text = $"Total devoluciones: {devoluciones:C2}";
                lblVentaFinal.Text = $"Total final: {totalFinal:C2}";
            }
            catch (Exception ex)
            {
                lblVenta.Text = "Venta total: $0.00";
                lblTotalDevolucion.Text = "Total devoluciones: $0.00";
                lblVentaFinal.Text = "Venta final: $0.00";
                MessageBox.Show($"Error al cargar tickets: {ex.Message}", "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }
        public void CrearGridView()
        {
            dgvTickets.Columns.Clear();
            dgvTickets.AutoGenerateColumns = false;
            dgvTickets.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Id",
                HeaderText = "N° Ticket",
                DataPropertyName = "Id",
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            });
            dgvTickets.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "User",
                HeaderText = "Creado Por Usuario",
                DataPropertyName = "User",
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            });
            dgvTickets.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Client",
                HeaderText = "Cliente",
                DataPropertyName = "Client",
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            });
            dgvTickets.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Total",
                HeaderText = "Total de Venta",
                DataPropertyName = "Total",
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            });
            dgvTickets.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "TotalReturn",
                HeaderText = "Total Devuelto",
                DataPropertyName = "TotalReturn",
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            });
            dgvTickets.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "TotalEnd",
                HeaderText = "Total Final",
                DataPropertyName = "TotalEnd",
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            });
            dgvTickets.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Created",
                HeaderText = "Fecha de creación",
                DataPropertyName = "Created",
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells//Width = 80
            });
            dgvTickets.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Modified",
                HeaderText = "Ulima modificación",
                DataPropertyName = "Modified",
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            });
            dgvTickets.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Status",
                HeaderText = "Estatus",
                DataPropertyName = "Status",
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            });
            dgvTickets.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Send",
                HeaderText = "Enviado",
                DataPropertyName = "Send",
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            });
            dgvTickets.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "TypePay",
                HeaderText = "Tipo de Pago",
                DataPropertyName = "TypePay",
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            });
            DataGridViewButtonColumn btnVer = new DataGridViewButtonColumn
            {
                Name = "Ver",
                HeaderText = "Acción",
                Text = "Ver Productos",
                UseColumnTextForButtonValue = true,
                Width = 90,
                FlatStyle = FlatStyle.Flat
            };
            btnVer.DefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);
            btnVer.DefaultCellStyle.ForeColor = Color.FromArgb(108, 117, 125);

            dgvTickets.Columns.Add(btnVer);
            DataGridViewButtonColumn btnCancelar = new DataGridViewButtonColumn
            {
                Name = "Cancelar",
                HeaderText = "Acción",
                Text = "Cancelar Ticket",
                UseColumnTextForButtonValue = true,
                Width = 90,
                FlatStyle = FlatStyle.Flat
            };
            btnCancelar.DefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);
            btnCancelar.DefaultCellStyle.ForeColor = Color.FromArgb(108, 117, 125);

            dgvTickets.Columns.Add(btnCancelar);
            DataGridViewButtonColumn btnEnviar = new DataGridViewButtonColumn
            {
                Name = "Enviar",
                HeaderText = "Acción",
                Text = "Enviar a Facturación",
                UseColumnTextForButtonValue = true,
                Width = 90,
                FlatStyle = FlatStyle.Flat
            };
            btnEnviar.DefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);
            btnEnviar.DefaultCellStyle.ForeColor = Color.FromArgb(108, 117, 125);

            dgvTickets.Columns.Add(btnEnviar);
            DataGridViewButtonColumn btnEstatusFactura = new DataGridViewButtonColumn
            {
                Name = "CheckFacture",
                HeaderText = "Acción",
                Text = "Checar Facturación",
                UseColumnTextForButtonValue = true,
                Width = 90,
                FlatStyle = FlatStyle.Flat
            };
            btnEstatusFactura.DefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);
            btnEstatusFactura.DefaultCellStyle.ForeColor = Color.FromArgb(108, 117, 125);

            dgvTickets.Columns.Add(btnEstatusFactura);

            dgvTickets.AllowUserToAddRows = false;
        }
        private void CBBuscar_CheckedChanged(object sender, EventArgs e)
        {
            if (CBFecha.Checked)
            {
                RBCreacion.Visible = true;
                RBModificacion.Visible = true;
                NUDTicket.Enabled = false;
                NUDTicket.Value = 0;
                dtHasta.Enabled = true;
                dtDesde.Enabled = true;
            }
            else
            {
                RBCreacion.Visible = false;
                RBModificacion.Visible = false;
                dtDesde.Enabled = false;
                dtHasta.Enabled = false;
                NUDTicket.Enabled = true;
            }
        }
        private void Tickets_Load(object sender, EventArgs e)
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
            RBCreacion.Checked = true;
            RBModificacion.Checked = false;
            AppRepository obj = new AppRepository();
            Empresa = obj.GetCompany().Result;
        }
        private async void dgvTickets_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (_procesandoAccion) return;
            if (dgvTickets.Columns[e.ColumnIndex].Name != "Ver" && dgvTickets.Columns[e.ColumnIndex].Name != "Cancelar"
                && dgvTickets.Columns[e.ColumnIndex].Name != "Enviar" && dgvTickets.Columns[e.ColumnIndex].Name != "CheckFacture") return;
            try
            {
                _procesandoAccion = true;
                this.Cursor = Cursors.WaitCursor; // Cambia el cursor a la "redondita" de carga
                dgvTickets.Enabled = false;

                int IdTicket = Convert.ToInt32(dgvTickets.Rows[e.RowIndex].Cells["Id"].Value);

                switch (dgvTickets.Columns[e.ColumnIndex].Name)
                {
                    case "Ver":
                        ItemsTicket itemsForm = new ItemsTicket();
                        itemsForm.IdTicket = IdTicket;
                        itemsForm.ShowDialog();
                        Buscar();
                        break;
                    case "Cancelar":
                        DateTime Created = Convert.ToDateTime(dgvTickets.Rows[e.RowIndex].Cells["Created"].Value);
                        string Status = Convert.ToString(dgvTickets.Rows[e.RowIndex].Cells["Status"].Value);
                        if (Status == "Cancelado")
                        {
                            MessageBox.Show("El ticket ya se encuentra cancelado.", "Modificación no permitida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        if (Created.AddDays(2) < DateTime.Now)
                        {
                            MessageBox.Show("No se puede cancelar un ticket creado hace más de 48 hrs.", "Modificación no permitida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        DialogResult resultado = MessageBox.Show("Si cancela el ticket se devolveran todos los articulos que tengan la opción de permitir devolver.¿Quiere continuar?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (resultado == DialogResult.No)
                        {
                            return;
                        }
                        Note n = new Note();
                        if (n.ShowDialog() != DialogResult.OK)
                        {
                            MessageBox.Show("Cancelación del ticket cancelada por el usuario.", "Cancelación Cancelada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        AppRepository obj = new AppRepository();
                        try
                        {
                            var Details = await obj.GetDetailsTicket(IdTicket);
                            bool nosend = false;
                            decimal sumaTotal = Details.Where(x => x.SendBack == true).Sum(d => d.TotalSold);
                            foreach (var detail in Details)
                            {
                                if (detail.SendBack)
                                {
                                    if (await obj.ReturnArticle(detail.Id, n.NoteText) == false)
                                    {
                                        MessageBox.Show($"Error al devolver el articulo {detail.Name}.", "Error de Devolución", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        break;
                                    }
                                }
                                else nosend = true;
                            }
                            if (nosend)
                            {
                                await obj.CancelTicket(IdTicket, "Se cancela ticket pero este producto no se devolvera a inventario es un producto que no acepta devoluciones, motivo de cancelación: " + n.NoteText);
                            }
                            MessageBox.Show($"Ticket cancelado exitosamente. Total ha devolver: {sumaTotal:C2}", "Cancelación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Buscar();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error al cargar los articulos: {ex.Message}", "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;
                    case "Enviar":
                        //MessageBox.Show("En mantenimiento espere información de soporte.", "Modificación no permitida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        //return;
                        string Send = Convert.ToString(dgvTickets.Rows[e.RowIndex].Cells["Send"].Value);
                        if (Send == "Enviado")
                        {
                            MessageBox.Show("El ticket ya se encuentra enviado a facturación.", "Modificación no permitida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        string Cancelado = Convert.ToString(dgvTickets.Rows[e.RowIndex].Cells["Status"].Value);
                        if (Cancelado == "Cancelado")
                        {
                            MessageBox.Show("El ticket ya se encuentra Cancelado.", "Modificación no permitida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        BillingMethods Facturacion = new BillingMethods();
                        AppRepository obj2 = new AppRepository();
                        var Venta = await obj2.GetTicketsbyId(IdTicket);
                        BillingDetails billing = new BillingDetails();
                        billing.pos_ticket_id = "TKT-TEST-MINO-" + Venta.CreateDate.Year.ToString() + "-" + IdTicket.ToString();
                        RespuestaFactureModel StatusFactura = await Facturacion.EstatusFactura(billing.pos_ticket_id);
                        if (StatusFactura.Exito == false && StatusFactura.Data.message != "No existe un ticket con ese identificador.")
                        {
                            MessageBox.Show("Error en el servidor, consultar con soporte técnico.", "Modificación no permitida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        var DetaillsVenta = await obj2.GetDetailsforFacture(IdTicket);
                        billing.form_payment = Venta.TypePay; // Ejemplo: 01 = Efectivo, 02= Cheque nominativo, 03 = transferencia electronica
                        billing.total = Venta.Total.ToString("F2");
                        billing.serie = "A";
                        billing.folio = Venta.Id.ToString();
                        billing.currency = "MXN";
                        billing.exchange_rate = null;
                        billing.exportacion = "01"; // Ejemplo: 01 = No exportación, 02 = Exportación definitiva, 03 = Exportación temporal
                        billing.payment_method = "PUE"; // Ejemplo: PUE = Pago en una sola exhibición, PPD = Pago en parcialidades o diferido
                        billing.payment_conditions = null;
                        billing.issuing_location = Empresa.CP.ToString();
                        billing.sold_at = Venta.CreateDate.ToString("yyyy-MM-ddTHH:mm:ss");
                        billing.concepts = new List<concepts>();
                        foreach (var item in DetaillsVenta)
                        {
                            List<taxes> listtaxes = new List<taxes>();
                            listtaxes.Add(new taxes
                            {
                                tax_type = "traslado",
                                @base = item.Total,
                                tax = "002",
                                type_factor = "Tasa",
                                rate = item.Rate,
                                amount = item.Amount
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
                                taxes = listtaxes
                            });
                        }

                        RespuestaFactureModel Enviado = await Facturacion.EnviarFactura(billing);
                        bool result = obj2.ConfirmSend(IdTicket, Enviado).Result;
                        if (Enviado.Exito == true)
                        {
                            MessageBox.Show("Envio con éxito.");
                            Buscar();
                        }
                        else MessageBox.Show("Fallo el envio consultar con soporte");
                        break;
                    case "CheckFacture":
                        AppRepository obj3 = new AppRepository();
                        var Ticket = await obj3.GetTicketsbyId(IdTicket);
                        BillingDetails Facture = new BillingDetails();
                        BillingMethods Facturacion2 = new BillingMethods();
                        Facture.pos_ticket_id = "TKT-TEST-MINO-" + Ticket.CreateDate.Year.ToString() + "-" + IdTicket.ToString();
                        RespuestaFactureModel StatusF = await Facturacion2.EstatusFactura(Facture.pos_ticket_id);
                        if (StatusF.Exito == false && StatusF.Data.message != "No existe un ticket con ese identificador.")
                        {
                            MessageBox.Show("Error en el servidor, consultar con soporte técnico.", "Modificación no permitida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            string Mensaje = StatusF.Data.facturado == true ? "Ya se encuentra facturado." : "Falta facturación.";
                            Mensaje += StatusF.Data.expires_at != null ? $" La fecha de expiración para facturar es: {StatusF.Data.expires_at}." : string.Empty;
                            Mensaje += StatusF.Data.message;
                            MessageBox.Show(Mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                            break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}");
            }
            finally
            {
                // 4. LIBERAR BLOQUEO: Pase lo que pase (éxito o error), volvemos a habilitar todo
                _procesandoAccion = false;
                this.Cursor = Cursors.Default;
                dgvTickets.Enabled = true;
            }
        }
        private void RBCreacion_CheckedChanged(object sender, EventArgs e)
        {
            if (RBCreacion.Checked)
                RBModificacion.Checked = false;
            else
                RBModificacion.Checked = true;
        }
        private void RBModificacion_CheckedChanged(object sender, EventArgs e)
        {
            if (RBModificacion.Checked)
                RBCreacion.Checked = false;
            else
                RBCreacion.Checked = true;
        }

        private void Tickets_FormClosed(object sender, FormClosedEventArgs e)
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
