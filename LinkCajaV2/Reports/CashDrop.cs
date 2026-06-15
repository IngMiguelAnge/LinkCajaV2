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
    public partial class CashDrop : System.Windows.Forms.Form
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
                bool Entradas = CBResumen.Text == "Ver Resumen" ? false : true;
                var detalles = await obj.GetCashDrop(dtDesde.Value, dtHasta.Value, Entradas);
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
            CBResumen.SelectedIndex = 0;
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
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
                Width = 300
            });
           
            if(CBResumen.Text == "Ver Resumen")
            {
                dgvCorte.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "VerConcepto",
                    HeaderText = "Ver Concepto",
                    DataPropertyName = "VerConcepto",
                    ReadOnly = true,
                    Visible = false,
                    Width = 300
                });
                DataGridViewButtonColumn btnVer = new DataGridViewButtonColumn
                {
                    Name = "Ver",
                    HeaderText = "Acción",
                    Text = "Ver motivo",
                    UseColumnTextForButtonValue = true,                
                    Width = 90,
                    FlatStyle = FlatStyle.Flat
                };

                btnVer.DefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);
                btnVer.DefaultCellStyle.ForeColor = Color.FromArgb(108, 117, 125);

                dgvCorte.Columns.Add(btnVer);
                dgvCorte.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "Articulo",
                    HeaderText = "Articulo",
                    DataPropertyName = "Articulo",
                    ReadOnly = true,
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                });
                dgvCorte.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "Fecha",
                    HeaderText = "Fecha",
                    DataPropertyName = "Fecha",
                    ReadOnly = true,
                    Width = 300
                });
            }
            dgvCorte.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Monto",
                HeaderText = "Monto",
                DataPropertyName = "Monto",
                ReadOnly = true,
                Width = 300
            });
            dgvCorte.AllowUserToAddRows = false;
        }

        private void dgvCorte_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            switch (dgvCorte.Columns[e.ColumnIndex].Name)
            {
                case "Ver":
                    string c = Convert.ToString(dgvCorte.Rows[e.RowIndex].Cells["VerConcepto"].Value);
                    MessageBox.Show(c, "Concepto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                default:
                    break;
            }

        }
    }
}
