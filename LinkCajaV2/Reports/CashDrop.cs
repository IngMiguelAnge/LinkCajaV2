using LinkCajaV2.Catalogs;
using LinkCajaV2.Configuraciones;
using LinkCajaV2.Data;
using LinkCajaV2.Graphs;
using LinkCajaV2.Items;
using LinkCajaV2.Model;
using LinkCajaV2.Sales;
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
        public int IdUsuario { get; set; }
        public string NameUser { get; set; }
        public int IdTypeUser { get; set; }
        public CashDrop()
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
            AppRepository obj = new AppRepository();
            var ListPresentation = obj.GetPresentations().Result;
            ListPresentation.Insert(0, new ListPresentationsModel { Id = 0, Name = "Seleccione", Presentation = string.Empty, Decimals = 0 });
            ListPresentation.Add(new ListPresentationsModel
            {
                Id = ListPresentation.Count, // El ID dinámico basado en el tamaño actual
                Name = "Ventas",
                Presentation = string.Empty,
                Decimals = 0
            });
            cbGraficas.DataSource = null;
            // Configuramos el ComboBox
            cbGraficas.DisplayMember = "Name";
            cbGraficas.ValueMember = "Id";
            cbGraficas.DataSource = ListPresentation;
            cbGraficas.SelectedIndex = 0;
            var ListProveedores = obj.GetSuppliersActives().Result.OrderBy(x => x.Name).ToList();
            // Insertamos un objeto "fantasma" al inicio para el placeholder
            ListProveedores.Insert(0, new ListSuppliersActivesModel { Id = 0, Name = "Seleccione" });
            cbProveedor.Items.Clear();
            cbProveedor.DisplayMember = "Name";
            cbProveedor.ValueMember = "Id";
            cbProveedor.DataSource = ListProveedores;
            cbProveedor.SelectedIndex = 0;
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
           
            if(CBResumen.Text != "Ver Resumen")
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

        private async void BtnGrafica_Click(object sender, EventArgs e)
        {
            if(cbGraficas.SelectedIndex <= 0)
            {
                MessageBox.Show("Seleccione una opción válida para la gráfica.", "Selección Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            AppRepository obj = new AppRepository();
            switch (cbGraficas.Text)
            {
                case "Ventas":
                    try
                    {
                        var detalles = await obj.GetSolds(dtDesde.Value, dtHasta.Value);
                        if (detalles != null && detalles.Any())
                        {
                            var listaFinal = detalles.ToList();
                            Graph1 g = new Graph1()
                            {
                                Datos = listaFinal,
                                Titulo = "VENTAS REALIZADAS",
                                TituloProductos = "FECHAS",
                                TituloCantidad = "VENTA TOTAL DEL " + dtDesde.Value.ToString("dd/MM/yyyy") + " AL " + dtHasta.Value.ToString("dd/MM/yyyy")
                            };
                            g.Show();
                        }
                        else
                        {
                            MessageBox.Show("No se encontraron datos para el rango seleccionado.", "Sin Datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al cargar los articulos: {ex.Message}", "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                default:
      
                    try
                    {
                        int IdProveedor = cbProveedor.SelectedIndex > 0 ? (int)cbProveedor.SelectedValue : 0;
                        var detalles = await obj.GetArticlesSolds(dtDesde.Value, dtHasta.Value, (int)cbGraficas.SelectedValue, IdProveedor);
                        if(detalles != null && detalles.Any())
                        {
                            var listaFinal = detalles.ToList();
                            Graph1 g = new Graph1()
                            {
                                Datos = listaFinal,
                                Titulo = "PRODUCTOS MÁS VENDIDOS",
                                TituloProductos = "PRODUCTOS",
                                TituloCantidad = "CANTIDAD VENDIDA DEL " + dtDesde.Value.ToString("dd/MM/yyyy") + " AL " + dtHasta.Value.ToString("dd/MM/yyyy")
                            };
                            g.Show();
                        }
                        else
                        {
                            MessageBox.Show("No se encontraron datos para el rango seleccionado.", "Sin Datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al cargar los articulos: {ex.Message}", "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                break;
            }
        }

        private void CashDrop_FormClosed(object sender, FormClosedEventArgs e)
        {
            Menu m = new Menu();
            m.IdUsuario = IdUsuario;
            m.NameUser = NameUser;
            m.IdTypeUser = IdTypeUser;
            m.Show();
            this.Hide();
        }

        private void cbGraficas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbGraficas.Text != "Seleccione" && cbGraficas.Text != "Ventas")
            {
                cbProveedor.Enabled = true;
            }
            else {
                if(cbProveedor.Items.Count > 0)
                cbProveedor.SelectedIndex = 0;
                cbProveedor.Enabled = false;
            }
        }
    }
}
