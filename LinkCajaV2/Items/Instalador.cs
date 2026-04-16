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

namespace LinkCajaV2.Items
{
    public partial class Instalador : Form
    {
        public string NameLicense { get; set; }
        public string Box { get; set; }
        public Instalador()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (txtContraseña.Text.Trim() == "LinkCajaV2")
            {
                if(cbLicencias.Enabled == true && cbLicencias.SelectedIndex == 0)
                {
                    MessageBox.Show("Seleccione una licencia.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (cbLicencias.Enabled == true)
                {
                    NameLicense = cbLicencias.Text;
                    Box = cbLicencias.SelectedValue.ToString();
                    AppRepository obj = new AppRepository();
                    EncrypDesencryp encry = new EncrypDesencryp();
                    KeysModel licencia = new KeysModel
                    {
                        Name = NameLicense,
                        Key = encry.Encriptar(Name + "Box" + Box)
                    };
                    if (obj.SaveKey(licencia).Result)
                    { 
                       MessageBox.Show("Licencia guardada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                       this.Close();
                    }        
                }
                cbLicencias.Enabled = true;               
            }
            else
            {
                MessageBox.Show("Contraseña incorrecta. Intente nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Instalador_Load(object sender, EventArgs e)
        {
            List<KeysModel> ListKeys = new List<KeysModel>();
            if (ListKeys == null || ListKeys.Count == 0)
            {
                ListKeys = new List<KeysModel>();
                KeysModel defaultKey = new KeysModel
                {
                    Name = "Licencia prueba",
                    Key = "1",
                };
                ListKeys.Add(defaultKey);
                defaultKey = new KeysModel
                {
                    Name = "Licencia basica",
                    Key = "3",
                };
                ListKeys.Add(defaultKey);
                defaultKey = new KeysModel
                {
                    Name = "Licencia plus",
                    Key = "6",
                };
                ListKeys.Add(defaultKey);
                defaultKey = new KeysModel
                {
                    Name = "Licencia permanente",
                    Key = "10000",
                };
                ListKeys.Add(defaultKey);
            }
            // Insertamos un objeto "fantasma" al inicio para el placeholder
            ListKeys.Insert(0, new KeysModel { Id = 0, Name = "Seleccione" });

            // Configuramos el ComboBox
            cbLicencias.DisplayMember = "Name"; // Lo que el usuario VE
            cbLicencias.ValueMember = "Key";      // El dato que procesas por DETRÁS
            cbLicencias.DataSource = ListKeys;
            cbLicencias.SelectedIndex = 0;
        }
    }
}
