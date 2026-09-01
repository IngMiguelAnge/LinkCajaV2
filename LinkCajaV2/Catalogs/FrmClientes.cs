using LinkCajaV2.Data;
using LinkCajaV2.Model;
using System;
using System.Windows.Forms;

namespace LinkCajaV2.Catalogs
{
    public partial class Cliente : Form
    {
        public int IdCliente = 0;
        public bool EstatusActual = true;
        public Cliente()
        {
            InitializeComponent();
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtTelefono1.Text))
            {
                MessageBox.Show("El Nombre y al menos el Teléfono 1 son obligatorios.", "Faltan Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Datos a ocupar
            ClienteModel datosCliente = new ClienteModel
            {
                Id = this.IdCliente,
                Nombre = txtNombre.Text.Trim(),
                Correo = txtCorreo.Text.Trim(),
                Telefono1 = txtTelefono1.Text.Trim(),
                Telefono2 = txtTelefono2.Text.Trim(),
                Estatus = this.EstatusActual
            };

            AppRepository app = new AppRepository();

           
            bool exito = await app.SaveCliente(datosCliente);

            // Que paso 
            if (exito)
            {
                MessageBox.Show("¡Datos del cliente guardados correctamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Hubo un problema al guardar en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




    }

        
}

