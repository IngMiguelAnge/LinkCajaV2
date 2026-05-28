using LinkCajaV2.Configuraciones;
using LinkCajaV2.Configurations;
using LinkCajaV2.Data;
using LinkCajaV2.Items;
using LinkCajaV2.Model;
using LinkCajaV2.Reports;
using LinkCajaV2.Sales;
using System;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace LinkCajaV2.Catalogs
{
    public partial class Boxs : System.Windows.Forms.Form
    {
        int CantidadCajas = 0;
        public int IdUsuario { get; set; }
        public string NameUser { get; set; }
        public int IdTypeUser { get; set; }
        public Boxs()
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
            m.Show();
            this.Hide();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            AppRepository obj = new AppRepository();
            int list = obj.GetBoxsActives().Result.Count();
            if (list >= CantidadCajas)
            {
                MessageBox.Show("Has alcanzado el limite de cajas permitidas por tu licencia. Contacta al soporte para adquirir más cajas.", "Limite de cajas alcanzado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Box b = new Box();
            b.ShowDialog();
            BuscarBoxs();
        }

        private void Boxs_Load(object sender, EventArgs e)
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
            EncrypDesencryp objEncryp = new EncrypDesencryp();
            string Key = objEncryp.Desencriptar(ListKeys.Key);
            string[] partes = Key.Split(new string[] { "Box", "box" }, StringSplitOptions.None);

            try
            {
                CantidadCajas = int.Parse(partes[1]);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se encontraron licencia activa. Contacta al soporte.", "Licencia no encontrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Trim() == "")
            {
                DialogResult resultado = MessageBox.Show("Ha dejado el campo vacio, esto buscara a todos los proveedores pero puede demorar ¿Quiere continuar?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.No)
                {
                    return;
                }
            }
            BuscarBoxs();
        }
        public async void BuscarBoxs()
        {
            progressBar1.Style = ProgressBarStyle.Marquee; // La barra empieza a moverse sola
            progressBar1.MarqueeAnimationSpeed = 30; // Velocidad de la animación
            btnBuscar.Enabled = false; // Deshabilitar el botón para evitar múltiples clics
            BtnNuevo.Enabled = false;
            dgvCajas.DataSource = null;
            dgvCajas.Columns.Clear();
            try
            {
                AppRepository obj = new AppRepository();
                var lista = await Task.Run(() => obj.GetBoxs(txtNombre.Text));
                dgvCajas.DataSource = lista != null && lista.Count > 0 ? lista : null;
                if (lista == null || lista.Count == 0)
                {
                    MessageBox.Show("No se encontraron cajas.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    AgregarBotones();
                    MessageBox.Show("Carga completa", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                progressBar1.MarqueeAnimationSpeed = 0;
                btnBuscar.Enabled = true;
                BtnNuevo.Enabled = true;
            }
        }
        private void AgregarBotones()
        {
            DataGridViewButtonColumn btnEditar = new DataGridViewButtonColumn();
            btnEditar.Name = "btnEditar";
            btnEditar.HeaderText = "Acción";
            btnEditar.Text = "Editar";
            btnEditar.UseColumnTextForButtonValue = true;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.DefaultCellStyle.BackColor = Color.FromArgb(240, 242, 245);
            btnEditar.DefaultCellStyle.ForeColor = Color.FromArgb(1, 110, 203);
            dgvCajas.Columns.Add(btnEditar);
            DataGridViewButtonColumn btnCambiar = new DataGridViewButtonColumn();
            btnCambiar.Name = "btnCambiar";
            btnCambiar.HeaderText = "Acción";
            btnCambiar.Text = "Cambio Estatus";
            btnCambiar.UseColumnTextForButtonValue = true;
            btnCambiar.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            btnCambiar.FlatStyle = FlatStyle.Flat;
            btnCambiar.DefaultCellStyle.BackColor = Color.FromArgb(240, 242, 245);
            btnCambiar.DefaultCellStyle.ForeColor = Color.FromArgb(1, 110, 203);

            dgvCajas.Columns.Add(btnCambiar);
            DataGridViewButtonColumn btnFondos = new DataGridViewButtonColumn();
            btnFondos.Name = "btnFondos";
            btnFondos.HeaderText = "Acción";
            btnFondos.Text = "Fondos";
            btnFondos.UseColumnTextForButtonValue = true;
            btnFondos.FlatStyle = FlatStyle.Flat;
            btnFondos.DefaultCellStyle.BackColor = Color.FromArgb(240, 242, 245);
            btnFondos.DefaultCellStyle.ForeColor = Color.FromArgb(1, 110, 203);

            dgvCajas.Columns.Add(btnFondos);
        }

        private void dgvCajas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            int Id = (int)dgvCajas.Rows[e.RowIndex].Cells["Id"].Value;

            switch (dgvCajas.Columns[e.ColumnIndex].Name)
            {
                case "btnEditar":
                    Box m = new Box();
                    m.Id = Convert.ToInt32(Id);
                    m.ShowDialog();
                    BuscarBoxs();
                    break;
                case "btnCambiar":
                    string Estatus = (string)dgvCajas.Rows[e.RowIndex].Cells["Estatus"].Value;
                    AppRepository obj = new AppRepository();
                    if (Estatus != "Activo")
                    {
                        int list = obj.GetBoxsActives().Result.Count();
                        if (list >= CantidadCajas)
                        {
                            MessageBox.Show("Has alcanzado el limite de cajas permitidas por tu licencia. Contacta al soporte para adquirir más cajas.", "Limite de cajas alcanzado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                    var resultado = obj.UpdateStatusBox(Id).Result;
                    if (resultado)
                    {
                        MessageBox.Show("Cambio de estado exitoso", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error al cambiar el estado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    BuscarBoxs();
                    break;
                case "btnFondos":
                    CashFund f = new CashFund();
                    f.IdBox = Convert.ToInt32(Id);
                    f.ShowDialog();
                    break;
            }
        }

        private void Boxs_FormClosed(object sender, FormClosedEventArgs e)
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
