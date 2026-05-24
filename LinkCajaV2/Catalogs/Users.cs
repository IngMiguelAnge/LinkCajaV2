using LinkCajaV2.Configuraciones;
using LinkCajaV2.Data;
using LinkCajaV2.Model;
using LinkCajaV2.Reports;
using LinkCajaV2.Sales;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinkCajaV2.Catalogs
{
    public partial class Users : Form
    {
        public int IdUsuario { get; set; }
        public string NameUser { get; set; }
        public int Id { get; set; }
        public Users()
        {
            InitializeComponent();
        }
        private void btnPanelVentas_Click(object sender, EventArgs e)
        {
            Venta s = new Venta();
            s.IdUsuario = IdUsuario;
            s.NameUser = NameUser;
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

        private void Users_Load(object sender, EventArgs e)
        {
            AppRepository obj = new AppRepository();
            var ListType = obj.GetTypesUsers().Result;
            // Insertamos un objeto "fantasma" al inicio para el placeholder
            ListType.Insert(0, new TypesUsersModel { Id = 0, Name = "Seleccione" });

            // Configuramos el ComboBox
            CBTipo.DisplayMember = "Name"; // Lo que el usuario VE
            CBTipo.ValueMember = "Id";      // El dato que procesas por DETRÁS
            CBTipo.DataSource = ListType;
            CBTipo.SelectedIndex = 0;
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Trim() == "" || txtNombre.Text.Trim() == "" ||
                CBTipo.SelectedIndex == 0)
            {
                DialogResult resultado = MessageBox.Show("Ha dejado campos vacios para buscar ¿Quiere continuar?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.No)
                {
                    return;
                }
            }
            BuscarUsuarios();
        }
        private async void BuscarUsuarios() 
        {
            progressBar1.Style = ProgressBarStyle.Marquee; // La barra empieza a moverse sola
            progressBar1.MarqueeAnimationSpeed = 30; // Velocidad de la animación
            BtnBuscar.Enabled = false;
            BtnNuevo.Enabled = false;
            dgvUsuarios.DataSource = null;
            dgvUsuarios.Columns.Clear();
            try
            {
                AppRepository obj = new AppRepository();
                UserModel user = new UserModel
                {
                    User = txtUsuario.Text.Trim(),
                    Name = txtNombre.Text.Trim(),
                    IdTypeUser = CBTipo.SelectedIndex > 0 ? (int)CBTipo.SelectedValue : 0
                };
                var lista = await Task.Run(() => obj.GetUsers(user));
                dgvUsuarios.DataSource = lista != null && lista.Count > 0 ? lista : null;
                if (lista == null || lista.Count == 0)
                {
                    MessageBox.Show("No se encontraron usuarios.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                BtnBuscar.Enabled = true;
                BtnNuevo.Enabled = true;
            }

        }
        private void AgregarBotones()
        {
            // Botón Checket
            DataGridViewButtonColumn btnEditar = new DataGridViewButtonColumn();
            btnEditar.Name = "btnEditar";
            btnEditar.HeaderText = "Acción";
            btnEditar.Text = "Editar";
            btnEditar.UseColumnTextForButtonValue = true;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.DefaultCellStyle.BackColor = Color.FromArgb(240, 242, 245);
            btnEditar.DefaultCellStyle.ForeColor = Color.FromArgb(1, 110, 203);
            dgvUsuarios.Columns.Add(btnEditar);
            DataGridViewButtonColumn btnCambiar = new DataGridViewButtonColumn();
            btnCambiar.Name = "btnCambiar";
            btnCambiar.HeaderText = "Acción";
            btnCambiar.Text = "Cambiar Estatus";
            btnCambiar.UseColumnTextForButtonValue = true;
            btnCambiar.FlatStyle = FlatStyle.Flat;
            btnCambiar.DefaultCellStyle.BackColor = Color.FromArgb(240, 242, 245);
            btnCambiar.DefaultCellStyle.ForeColor = Color.FromArgb(1, 110, 203);

            dgvUsuarios.Columns.Add(btnCambiar);
        }

        private async void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Evitar errores si hacen click en el encabezado
            if (e.RowIndex < 0) return;
            var Id = dgvUsuarios.Rows[e.RowIndex].Cells["Id"].Value;

            switch (dgvUsuarios.Columns[e.ColumnIndex].Name)
            {
                case "btnEditar":
                    User m = new User();
                    m.Id = Convert.ToInt32(Id);
                    m.ShowDialog();
                    BuscarUsuarios();
                    break;
                case "btnCambiar":
                    AppRepository obj = new AppRepository();
                    await obj.UpdateStatusUser(Convert.ToInt32(Id));
                    BuscarUsuarios();
                    break;
            }
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            User m = new User();
            m.Id = 0;
            m.ShowDialog();
            BuscarUsuarios();
        }

        private void Users_FormClosed(object sender, FormClosedEventArgs e)
        {
            Menu m = new Menu();
            m.IdUsuario = IdUsuario;
            m.NameUser = NameUser;
            m.Show();
            this.Hide();
        }
    }
}
