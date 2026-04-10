using LinkCajaV2.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinkCajaV2
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            AppRepository obj = new AppRepository();
            var usuario = obj.GetUserbyNameAndPassword(txtUser.Text, txtPassword.Text).Result;
            if (usuario is null)
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(usuario.Status == false)
                {
                    MessageBox.Show("Usuario desabilitado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Menu m = new Menu();
                m.IdUsuario = usuario.Id;
                m.IdTypeUser = usuario.IdTypeUser;
                m.NameUser = usuario.Name;
                m.Show();
                this.Hide();
            }
        }
    }
}