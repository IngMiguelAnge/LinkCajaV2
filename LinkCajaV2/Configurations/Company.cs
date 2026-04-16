using LinkCajaV2.Data;
using LinkCajaV2.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinkCajaV2.Configuraciones
{
    public partial class Company : Form
    {
        public Company()
        {
            InitializeComponent();
        }

        private void btnLogo_Click(object sender, EventArgs e)
        {
            OpenFileDialog selector = new OpenFileDialog();
            selector.Filter = "Imagenes|*.jpg;*.jpeg;*.png;*.bmp";

            if (selector.ShowDialog() == DialogResult.OK)
            {
                PBLogo.Image = Image.FromFile(selector.FileName);
                // Ajustamos la imagen al tamaño del PictureBox
                PBLogo.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(txtNombre.Text.Trim() == string.Empty || txtDireccion.Text.Trim() == string.Empty
                || txtEncargado.Text.Trim() == string.Empty || NUDCP.Value <=4
                || txtRFC.Text.Trim() == string.Empty || txtCorreo.Text.Trim() == string.Empty
                || txtTelefono1.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Faltan llenar campos obligatorios", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            CompanyModel Empresa = new CompanyModel()
            {
                Name = txtNombre.Text,
                Address = txtDireccion.Text,
                CP = (int)NUDCP.Value,
                RFC = txtRFC.Text,  
                Regimen = txtRegimen.Text,
                Manager = txtEncargado.Text,
                Phone1 = txtTelefono1.Text,
                Phone2 = txtTelefono2.Text,
                Email = txtCorreo.Text,
                Logo = PBLogo.Image != null ? ImageToByteArray() : null
            };
            AppRepository obj = new AppRepository();
            if(obj.SaveCompany(Empresa).Result)
                MessageBox.Show("Guardado satisfactoriamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Erro al guardar la información", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        public byte[] ImageToByteArray()
        {
            if (PBLogo.Image == null) return null;

            // Creamos una copia de la imagen para evitar bloqueos de GDI+
            using (Bitmap tempImage = new Bitmap(PBLogo.Image))
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    // Forzamos el guardado en un formato específico (ej. Png o Jpeg)
                    // Esto es mucho más seguro que usar RawFormat
                    tempImage.Save(ms, System.Drawing.Imaging.ImageFormat.Png);

                    return ms.ToArray();
                }
            }
        }

        private void Empresa_Load(object sender, EventArgs e)
        {
            AppRepository obj = new AppRepository();
            var Empresa = obj.GetCompany().Result;
            if (Empresa != null)
            {
                txtNombre.Text = Empresa.Name;
                txtDireccion.Text = Empresa.Address;
                NUDCP.Value = Empresa.CP;
                txtRFC.Text = Empresa.RFC;
                txtRegimen.Text = Empresa.Regimen;
                txtEncargado.Text = Empresa.Manager;
                txtTelefono1.Text = Empresa.Phone1;
                txtTelefono2.Text = Empresa.Phone2;
                txtCorreo.Text = Empresa.Email;
                if (Empresa.Logo != null)
                {
                    using (MemoryStream ms = new MemoryStream(Empresa.Logo))
                    {
                        PBLogo.Image = Image.FromStream(ms);
                        PBLogo.SizeMode = PictureBoxSizeMode.Zoom;
                    }
                }
            }
        }
    }
}
