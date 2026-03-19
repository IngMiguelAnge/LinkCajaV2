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
    public partial class User : Form
    {
        public int Id { get; set; }
        public User()
        {
            InitializeComponent();
        }

        private void User_Load(object sender, EventArgs e)
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
            if (Id == 0) return;
            var User = obj.GetUserbyId(Id).Result;
            txtNombre.Text = User.Name;
            txtDireccion.Text = User.Address;
            txtPassword.Text = User.Password;
            txtUsuario.Text = User.User;
            CBTipo.SelectedValue = User.IdTypeUser;

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtDireccion.Text) ||
               string.IsNullOrEmpty(txtUsuario.Text) || string.IsNullOrEmpty(txtPassword.Text) ||
               CBTipo.SelectedIndex == 0)
            {
                MessageBox.Show("Datos incompletos revise la información", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            AppRepository obj = new AppRepository();
            UserModel Users = new UserModel
            {
                Id = Id,
                Name = txtNombre.Text,
                Address = txtDireccion.Text,
                User = txtUsuario.Text,
                Password = txtPassword.Text,
                IdTypeUser = CBTipo.SelectedIndex > 0 ? (int)CBTipo.SelectedValue : 0
            };
            if (obj.SaveUser(Users).Result)
            {
                MessageBox.Show("Usuario guardado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else MessageBox.Show("Error al guardar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}
