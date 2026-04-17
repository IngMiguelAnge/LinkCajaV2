using LinkCajaV2.Data;
using LinkCajaV2.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinkCajaV2.Catalogs
{
    public partial class Box : Form
    {
        public int Id { get; set; }
        int CantidadCajas = 0;
        public Box()
        {
            InitializeComponent();
        }

        private void Box_Load(object sender, EventArgs e)
        {
            AppRepository obj = new AppRepository();
            KeysModel ListKeys = obj.GetKeysActive().Result;
            if (ListKeys == null)
            {
                MessageBox.Show("No se encontraron licencia activa. Contacta al soporte.", "Licencia no encontrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            EncrypDesencryp objEncryp = new EncrypDesencryp();
            string Key = objEncryp.Desencriptar(ListKeys.Key);
            string[] partes = Key.Split(new string[] { "Box", "box" }, StringSplitOptions.None);
            CantidadCajas = int.Parse(partes[1]);
            if (Id == 0)
            {
                txtHard.Text = ObtenerHardwareID();
                return;
            }
            var model = obj.GetBoxsbyId(Id).Result;
            txtHard.Text = model.HardwareID;
            txtNombre.Text = model.Name;
        }
        public string ObtenerHardwareID()
        {
            string idCombinado = "";
            try
            {
                // 1. Obtener ID del Procesador
                using (ManagementObjectSearcher mbs = new ManagementObjectSearcher("Select ProcessorId From Win32_Processor"))
                {
                    foreach (ManagementObject mo in mbs.Get())
                    {
                        idCombinado += mo["ProcessorId"].ToString();
                        break;
                    }
                }

                // 2. Obtener Número de Serie de la Placa Base
                using (ManagementObjectSearcher mbs = new ManagementObjectSearcher("Select SerialNumber From Win32_BaseBoard"))
                {
                    foreach (ManagementObject mo in mbs.Get())
                    {
                        idCombinado += mo["SerialNumber"].ToString();
                        break;
                    }
                }
            }
            catch { idCombinado = "ID_GENERICO_ERROR"; }

            // Convertimos la cadena larga en un Hash corto y limpio (ej: A1B2-C3D4-E5F6)
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(idCombinado));
                string hash = BitConverter.ToString(bytes).Replace("-", "");
                return hash.Substring(0, 16); // Retornamos solo los primeros 16 caracteres
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            try
            {
                AppRepository obj = new AppRepository();
                BoxModel model = new BoxModel
                {
                    HardwareID = txtHard.Text,
                    Name = txtNombre.Text,
                };

                if (Id == 0)
                {
                    var exit = obj.GetBoxsbyHardwareID(txtHard.Text).Result;
                    if (exit == null)
                    {
                        int list = obj.GetBoxsActives().Result.Count();
                        if (list >= CantidadCajas)
                        {
                            MessageBox.Show("Has alcanzado el limite de cajas permitidas por tu licencia. Contacta al soporte para adquirir más cajas.", "Limite de cajas alcanzado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                    else
                    {
                        if(Id != exit.Id)
                        {
                            MessageBox.Show("Ya existe una caja registrada con este hardware ID. Verifica que no estés registrando la misma caja nuevamente.", "Caja duplicada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                }
                var res = obj.SaveBox(model).Result;
                if(res)
                {
                    MessageBox.Show("Caja guardada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al guardar la caja. Intenta nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se encontraron licencia activa. Contacta al soporte.", "Licencia no encontrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
        }
    }
}
