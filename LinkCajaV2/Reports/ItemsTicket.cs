using LinkCajaV2.Data;
using LinkCajaV2.Items;
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

namespace LinkCajaV2.Reports
{
    public partial class ItemsTicket : Form
    {
        public int IdTicket { get; set; }
        public ItemsTicket()
        {
            InitializeComponent();
        }
        public async void CargarDatos()
        {
            AppRepository obj = new AppRepository();
            try
            {
                var articulos = await obj.GetDetailsTicket(IdTicket);
                var listaFinal = articulos?.ToList() ?? new List<ListDetailsTicketModel>();
                dgvArticulos.DataSource = new BindingList<ListDetailsTicketModel>(listaFinal);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los articulos: {ex.Message}", "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ItemsTicket_Load(object sender, EventArgs e)
        {
            CrearGridView();
            CargarDatos();
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
            DataGridViewButtonColumn btnCancelar = new DataGridViewButtonColumn
            {
                Name = "Cancelar",
                HeaderText = "Acción",
                Text = "Devolver",
                UseColumnTextForButtonValue = true,
                Width = 90
            };
            dgvArticulos.Columns.Add(btnCancelar);
            dgvArticulos.AllowUserToAddRows = false;
        }

        private async void dgvArticulos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            switch (dgvArticulos.Columns[e.ColumnIndex].Name)
            {
                case "Cancelar":
                    DateTime Created = Convert.ToDateTime(dgvArticulos.Rows[e.RowIndex].Cells["CreateDate"].Value);
                    string Status = Convert.ToString(dgvArticulos.Rows[e.RowIndex].Cells["Status"].Value);
                    if (Status == "Cancelado")
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
                    Note n = new Note();
                    n.ShowDialog();
                    int IdDetalle = Convert.ToInt32(dgvArticulos.Rows[e.RowIndex].Cells["Id"].Value);
                    decimal Total = Convert.ToDecimal(dgvArticulos.Rows[e.RowIndex].Cells["TotalSold"].Value);
                    string Name = Convert.ToString(dgvArticulos.Rows[e.RowIndex].Cells["Name"].Value);
                    AppRepository obj = new AppRepository();
                    try
                    {
                        if (await obj.ReturnArticle(IdDetalle, n.NoteText) == false)
                        {
                            MessageBox.Show($"Error al devolver el articulo {Name}.", "Error de Devolución", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }

                        MessageBox.Show($"Articulo devuelto exitosamente. Total ha devolver: {Total:C2}", "Cancelación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarDatos();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al cargar los articulos: {ex.Message}", "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
            }
        }
    }
}