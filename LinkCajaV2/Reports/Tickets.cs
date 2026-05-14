using LinkCajaV2.Data;
using LinkCajaV2.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static QuestPDF.Helpers.Colors;

namespace LinkCajaV2.Reports
{
    public partial class Tickets : Form
    {
        public Tickets()
        {
            InitializeComponent();
        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            bool fechaCreacion = RBCreacion.Checked;
            AppRepository obj = new AppRepository();

            try
            {
                var articulo = await obj.GetTickets((int)NUDTicket.Value, dtDesde.Value, dtHasta.Value, fechaCreacion);
                var listaFinal = articulo?.ToList() ?? new List<ListTicketModel>();
                dgvTickets.DataSource = new BindingList<ListTicketModel>(listaFinal);
                decimal totalGeneral = listaFinal.Sum(item => item.Total);
                lblVenta.Text = $"Venta total: {totalGeneral:C2}";
            }
            catch (Exception ex)
            {
                lblVenta.Text = "Venta total: $0.00";
                MessageBox.Show($"Error al cargar tickets: {ex.Message}", "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                HeaderText = "Total",
                DataPropertyName = "Total",
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
            DataGridViewButtonColumn btnVer = new DataGridViewButtonColumn
            {
                Name = "Ver",
                HeaderText = "Acción",
                Text = "Ver Productos",
                UseColumnTextForButtonValue = true,
                Width = 80
            };
            dgvTickets.Columns.Add(btnVer);
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
            RBCreacion.Checked = true;
            RBModificacion.Checked = false;
            CrearGridView();
        }
        private void dgvTickets_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            switch (dgvTickets.Columns[e.ColumnIndex].Name)
            {
                case "Ver":
                    ItemsTicket itemsForm = new ItemsTicket
                    {
                        IdTicket = Convert.ToInt32(dgvTickets.Rows[e.RowIndex].Cells["Id"].Value)
                    };
                    itemsForm.ShowDialog();
                    break;
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
    }
}
