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
    public partial class CashDrop : Form
    {
        public CashDrop()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CrearGridView();
            CargarDatos();
        }
        public async void CargarDatos()
        {
            AppRepository obj = new AppRepository();
            try
            {
                var detalles = await obj.GetCashDrop(dtDesde.Value, dtHasta.Value);
                var listaFinal = detalles?.ToList() ?? new List<CashDropModel>();
                dgvCorte.DataSource = new BindingList<CashDropModel>(listaFinal);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los articulos: {ex.Message}", "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CashDrop_Load(object sender, EventArgs e)
        {
           
        }
        public void CrearGridView()
        {
            dgvCorte.Columns.Clear();
            dgvCorte.AutoGenerateColumns = false;
            dgvCorte.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Concepto",
                HeaderText = "Concepto",
                DataPropertyName = "Concepto",
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            });
            dgvCorte.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Monto",
                HeaderText = "Monto",
                DataPropertyName = "Monto",
                ReadOnly = true,
                DefaultCellStyle = { Format = "C2" },
                Width = 300
            });
            //DataGridViewButtonColumn btnDetalles = new DataGridViewButtonColumn
            //{
            //    Name = "Detalles",
            //    HeaderText = "Acción",
            //    Text = "Detalles",
            //    UseColumnTextForButtonValue = true, // Para que todos los botones digan "Quitar"
            //    Width = 80
            //};
            //dgvCorte.Columns.Add(btnDetalles);
            dgvCorte.AllowUserToAddRows = false;
        }
    }
}
