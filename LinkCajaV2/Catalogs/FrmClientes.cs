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
    public partial class Cliente : Form
    {
        public int IdCliente = 0;
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
            LinkCajaV2.Model.ClienteModel datosCliente = new LinkCajaV2.Model.ClienteModel
            {
                Id = this.IdCliente, 
                Nombre = txtNombre.Text.Trim(),
                Correo = txtCorreo.Text.Trim(),
                Telefono1 = txtTelefono1.Text.Trim(),
                Telefono2 = txtTelefono2.Text.Trim(),
                Estatus = (cmbEstatus.SelectedIndex == 0)
            };

            LinkCajaV2.Data.AppRepository app = new LinkCajaV2.Data.AppRepository();
            bool exito = false;

            //  Tomamos la decisión: ¿Nuevo o Actualizar?
            if (this.IdCliente == 0)
            {
                // Es un cliente nuevo
                exito = await app.SaveCliente(datosCliente);
            }
            else
            {
                // Es un cliente viejito 
                exito = await app.UpdateCliente(datosCliente);
            }

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

        private void Cliente_Load(object sender, EventArgs e)
        {
            if (this.IdCliente == 0)
            {
                cmbEstatus.SelectedIndex = 0;
            }
        }
    }

        
}

