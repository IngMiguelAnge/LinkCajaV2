using LinkCajaV2.Data;
using LinkCajaV2.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static QuestPDF.Helpers.Colors;

namespace LinkCajaV2.Items
{
    public partial class Instalador : System.Windows.Forms.Form
    {
        public Instalador()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            AppRepository obj = new AppRepository();
            EncrypDesencryp encry = new EncrypDesencryp();
            string Cantidad = "0";
            switch (txtContraseña.Text.Trim())
            {
                case "Gratis":
                    Cantidad = "1";
                    break;

                case "LinkCajaV2Emp":
                    Cantidad = "9999";
                    break;

                default:
                    MessageBox.Show("Contraseña incorrecta. Intente nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
            if (Cantidad == "0")
                return;
            KeysModel licencia = new KeysModel
            {
                Name = txtContraseña.Text.Trim(),
                Key = encry.Encriptar(Name + "Box"+ Cantidad)
            };
            if (obj.SaveKey(licencia).Result)
            {
                MessageBox.Show("Licencia guardada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al guardar. Intente nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Instalador_Load(object sender, EventArgs e)
        {
        }
    }
}
