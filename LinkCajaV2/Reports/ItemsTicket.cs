using LinkCajaV2.Data;
using LinkCajaV2.Items;
using LinkCajaV2.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LinkCajaV2.Reports
{
    public partial class ItemsTicket : System.Windows.Forms.Form
    {
        public int IdTicket { get; set; }
        public int Year { get; set; }
        public string Send {  get; set; }
        private bool _procesandoAccion = false;
        private bool permitircancelar = true;
        private List<concepts> ListConceptos = new List<concepts>();
        public ItemsTicket()
        {
            InitializeComponent();
        }
        public async Task CargarDatos()
        {
            AppRepository obj = new AppRepository();
            try
            {
                var articulos = await obj.GetDetailsTicket(IdTicket);
                var listaFinal = articulos?.ToList() ?? new List<ListDetailsTicketModel>();
                dgvArticulos.DataSource = new BindingList<ListDetailsTicketModel>(listaFinal);
                if (listaFinal.Where(x => x.Status != "DEVUELTO").Count() == 0)
                {
                        BillingMethods Facturacion = new BillingMethods();
                        string MensajeFacturacion = string.Empty;
                        RespuestaFactureModel CancelarFactura = await Facturacion.CancelarFactura("TKT-TEST-MINO-" + Year.ToString() + "-" + IdTicket.ToString());
                        MensajeFacturacion = "Portal de facturación:" + CancelarFactura.Data.message;
                        MessageBox.Show("Todos los artículos del ticket han sido devueltos, por lo que el ticket se encuentra cancelado." + MensajeFacturacion, "Ticket Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los articulos: {ex.Message}", "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async void ItemsTicket_Load(object sender, EventArgs e)
        {
            if (Send == "Enviado")
            {
                BillingDetails Facture = new BillingDetails();
                BillingMethods Facturacion = new BillingMethods();
                Facture.pos_ticket_id = "TKT-TEST-MINO-" + Year.ToString() + "-" + IdTicket.ToString();
                RespuestaFactureModel RStatusF = await Facturacion.EstatusFactura(Facture.pos_ticket_id);
                ListConceptos = new List<concepts>();
                if (RStatusF.Exito == false && RStatusF.Data.message != "No existe un ticket con ese identificador.")
                {
                    MessageBox.Show($"Error en el servidor,{RStatusF.Data.message}, consultar con soporte técnico.", "Modificación no permitida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Close();
                }
                else
                {
                    if (RStatusF.Data.facturado == true)
                    {
                        MessageBox.Show("No se puede cancelar los articulos de este ticket por que que ya se encuentra facturado.", "Modificación no permitida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        permitircancelar = false;
                    }
                    ListConceptos.AddRange(RStatusF.Data.concepts);
                }
            }
            else permitircancelar = true;

                CrearGridView();
            await CargarDatos();
        }
        public void CrearGridView()
        {
            dgvArticulos.Columns.Clear();
            dgvArticulos.AutoGenerateColumns = false;
            dgvArticulos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Id",
                HeaderText = "Id",
                DataPropertyName = "Id",
                ReadOnly = true,
                Visible = false,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            });
            dgvArticulos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "SendBack",
                HeaderText = "SendBack",
                DataPropertyName = "SendBack",
                ReadOnly = true,
                Visible = false,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            });
            dgvArticulos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "IdArticle",
                HeaderText = "IdArticle",
                DataPropertyName = "IdArticle",
                ReadOnly = true,
                Visible = false,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            });
            dgvArticulos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Code",
                HeaderText = "Código",
                DataPropertyName = "Code",
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            });
            dgvArticulos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Name",
                HeaderText = "Nombre",
                DataPropertyName = "Name",
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            });
            dgvArticulos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Stock",
                HeaderText = "Cantidad",
                DataPropertyName = "Stock",
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            });
            dgvArticulos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "PriceSold",
                HeaderText = "Precio unitario",
                DataPropertyName = "PriceSold",
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells//Width = 80
            });
            dgvArticulos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "TotalSold",
                HeaderText = "Total",
                DataPropertyName = "TotalSold",
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            });
            dgvArticulos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "CreateDate",
                HeaderText = "Fecha de creación",
                DataPropertyName = "CreateDate",
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            });
            dgvArticulos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Status",
                HeaderText = "Estatus",
                DataPropertyName = "Status",
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            });
            if(permitircancelar == true)
            {
                DataGridViewButtonColumn btnCancelar = new DataGridViewButtonColumn
                {
                    Name = "Cancelar",
                    HeaderText = "Acción",
                    Text = "Devolver",
                    UseColumnTextForButtonValue = true,
                    Width = 90,
                    FlatStyle = FlatStyle.Flat,
                };
                btnCancelar.DefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);
                btnCancelar.DefaultCellStyle.ForeColor = Color.FromArgb(108, 117, 125);
                dgvArticulos.Columns.Add(btnCancelar);
            }
               
            dgvArticulos.AllowUserToAddRows = false;
        }

        private async void dgvArticulos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (_procesandoAccion) return;
            if (dgvArticulos.Columns[e.ColumnIndex].Name != "Cancelar") return;
            try
            {
                _procesandoAccion = true;
                this.Cursor = Cursors.WaitCursor; // Cambia el cursor a la "redondita" de carga
                dgvArticulos.Enabled = false;

                switch (dgvArticulos.Columns[e.ColumnIndex].Name)
                {
                    case "Cancelar":
                        DateTime Created = Convert.ToDateTime(dgvArticulos.Rows[e.RowIndex].Cells["CreateDate"].Value);
                        string Status = Convert.ToString(dgvArticulos.Rows[e.RowIndex].Cells["Status"].Value);
                        if (Status == "DEVUELTO")
                        {
                            MessageBox.Show("El producto ya se encuentra cancelado.", "Modificación no permitida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        if (Created.AddDays(2) < DateTime.Now)
                        {
                            MessageBox.Show("No se puede cancelar un ticket creado hace más de 48 hrs.", "Modificación no permitida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        bool SendBack = Convert.ToBoolean(dgvArticulos.Rows[e.RowIndex].Cells["SendBack"].Value);
                        if (SendBack == false)
                        {
                            MessageBox.Show("Este producto no acepta devoluciones", "Modificación no permitida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        if (Send != "Enviado")
                        {
                            DialogResult continuar = MessageBox.Show("El ticket no se encuentra en el portal.¿Quiere continuar?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (continuar == DialogResult.No)
                            {
                                return;
                            }
                        }
                        Note n = new Note();
                        if (n.ShowDialog() != DialogResult.OK)
                        {
                            MessageBox.Show("Devolución cancelada por el usuario.", "Devolución Cancelada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }

                        int IdDetalle = Convert.ToInt32(dgvArticulos.Rows[e.RowIndex].Cells["Id"].Value);
                        int IdArticle = Convert.ToInt32(dgvArticulos.Rows[e.RowIndex].Cells["IdArticle"].Value);
                        decimal Total = Convert.ToDecimal(dgvArticulos.Rows[e.RowIndex].Cells["TotalSold"].Value);
                        string Name = Convert.ToString(dgvArticulos.Rows[e.RowIndex].Cells["Name"].Value);
                        AppRepository obj = new AppRepository();
                        try
                        {
                            if (Send == "Enviado")
                            {

                                if (ListConceptos.Where(x => x.no_identificacion == IdArticle.ToString()).Count() > 0)
                                {
                                    BillingDetails Facture = new BillingDetails();
                                    BillingMethods Facturacion = new BillingMethods();
                                    Facture.pos_ticket_id = "TKT-TEST-MINO-" + Year.ToString() + "-" + IdTicket.ToString();
                                    RespuestaFactureModel CancelarFactura = await Facturacion.CancelarUnArticulo(Facture.pos_ticket_id, IdArticle.ToString());
                                    if (CancelarFactura.Data.message != "Artículo devuelto correctamente.")
                                    {
                                        MessageBox.Show($"Error al devolver el articulo. Portal: {CancelarFactura.Data.message}.", "Error de Devolución", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        break;
                                    }
                                }
                            }
                            if (await obj.ReturnArticle(IdDetalle, n.NoteText) == false)
                            {
                                MessageBox.Show($"Error al devolver el articulo {Name}.", "Error de Devolución", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;
                            }
                            MessageBox.Show($"Articulo devuelto exitosamente. Total ha devolver: {Total:C2}", "Cancelación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                         await CargarDatos();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error al cargar los articulos: {ex.Message}", "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
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
                dgvArticulos.Enabled = true;
            }
        }

        private void dgvArticulos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var item = (ListDetailsTicketModel)dgvArticulos.Rows[e.RowIndex].DataBoundItem;
            if (item != null)
                txtMotivo.Text = item.Note;
        }
    }
}