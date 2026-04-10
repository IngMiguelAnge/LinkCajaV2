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
    public partial class Client : Form
    {
        public int Id { get; set; }
        public Client()
        {
            InitializeComponent();
        }

        private void Client_Load(object sender, EventArgs e)
        {
            if (Id == 0) return;
            AppRepository obj = new AppRepository();         
            var Client = obj.GetClientsbyId(Id).Result;         
            txtNombre.Text = Client.Name;
            txtDireccion.Text = Client.Address;
            txtTelefono1.Text = Client.Phone1;
            txtTelefono2.Text = Client.Phone2;
            txtEmail.Text = Client.Email;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtDireccion.Text) ||
               string.IsNullOrEmpty(txtTelefono1.Text))
            {
                MessageBox.Show("Datos incompletos revise la información", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            AppRepository obj = new AppRepository();
            ClientsModel Client = new ClientsModel
            {
                Id = Id,
                Name = txtNombre.Text,
                Address = txtDireccion.Text,
                Phone1 = txtTelefono1.Text,
                Phone2 = txtTelefono2.Text,
                Email = txtEmail.Text
            };
            if (obj.SaveClient(Client).Result)
            {
                MessageBox.Show("Cliente guardado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else MessageBox.Show("Error al guardar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}
