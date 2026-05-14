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

namespace LinkCajaV2.Reports
{
    public partial class ItemsTicket : Form
    {
        public int IdTicket { get; set; }
        public ItemsTicket()
        {
            InitializeComponent();
        }

        private async void ItemsTicket_Load(object sender, EventArgs e)
        {
            CrearGridView();
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
            //DataGridViewButtonColumn btnVer = new DataGridViewButtonColumn
            //{
            //    Name = "Ver",
            //    HeaderText = "Acción",
            //    Text = "Ver Productos",
            //    UseColumnTextForButtonValue = true,
            //    Width = 80
            //};
            //dgvArticulos.Columns.Add(btnVer);
            dgvArticulos.AllowUserToAddRows = false;
        }
    }
}
