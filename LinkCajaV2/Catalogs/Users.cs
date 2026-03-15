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

namespace LinkCajaV2.Catalogs
{
    public partial class Users : Form
    {
        public int Id { get; set; }
        public Users()
        {
            InitializeComponent();
        }

        private void Users_Load(object sender, EventArgs e)
        {
            AppRepository obj = new AppRepository();
            var ListType = obj.GetTypesUsers().Result;
            // Insertamos un objeto "fantasma" al inicio para el placeholder
            ListType.Insert(0, new TypesUsersModel { Id = 0, Name = "Seleccione" });

            // Configuramos el ComboBox
            CBTipo.DisplayMember = "Nombre"; // Lo que el usuario VE
            CBTipo.ValueMember = "Id";      // El dato que procesas por DETRÁS
            CBTipo.DataSource = ListType;
            CBTipo.SelectedIndex = 0;
        }

        private async void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Trim() == "" || txtNombre.Text.Trim() == "" ||
                CBTipo.SelectedIndex == 0)
            {
                DialogResult resultado = MessageBox.Show("Ha dejado campos vacios para buscar ¿Quiere continuar?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.No)
                {
                    return;
                }
                progressBar1.Style = ProgressBarStyle.Marquee; // La barra empieza a moverse sola
                progressBar1.MarqueeAnimationSpeed = 30; // Velocidad de la animación
                BtnBuscar.Enabled = false; // Deshabilitar el botón para evitar múltiples clics
                dgvUsuarios.DataSource = null;
                dgvUsuarios.Columns.Clear();
                try
                {
                    AppRepository obj = new AppRepository();
                    UserModel user = new UserModel
                    {
                        User = txtUsuario.Text.Trim(),
                        Name = txtNombre.Text.Trim(),
                        Id_TypeUser = CBTipo.SelectedIndex > 0 ? (int)CBTipo.SelectedValue : 0
                    };
                    var lista = await Task.Run(() => obj.GetUsers(user));
                    dgvUsuarios.DataSource = lista != null && lista.Count > 0 ? lista : null;
                    if (lista == null || lista.Count == 0)
                    {
                        MessageBox.Show("No se encontraron clientes.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    BtnBuscar.Enabled = true;
                }
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
            dgvUsuarios.Columns.Add(btnEditar);
        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Evitar errores si hacen click en el encabezado
            if (e.RowIndex < 0) return;
            var Id = dgvUsuarios.Rows[e.RowIndex].Cells["Id"].Value;

            switch (dgvUsuarios.Columns[e.ColumnIndex].Name)
            {
                case "btnEditar":
                    User m = new User();
                    m.Id = Convert.ToInt32(Id);
                    m.Show();
                    break;
            }
        }
    }
}
