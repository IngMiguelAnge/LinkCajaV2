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
    public partial class Box : System.Windows.Forms.Form
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
            KeysModel ListKeys = obj.GetKeys().Result.FirstOrDefault();
            if (ListKeys == null)
            {
                MessageBox.Show("No se encontraron licencia activa. Contacta al soporte.", "Licencia no encontrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            CBRuleta.SelectedIndex = 0;
            EncrypDesencryp objEncryp = new EncrypDesencryp();
            string Key = objEncryp.Desencriptar(ListKeys.Key);
            string[] partes = Key.Split(new string[] { "Box", "box" }, StringSplitOptions.None);
            CantidadCajas = int.Parse(partes[1]);
            if (CantidadCajas > 1)
            {
                CBPublicidad.Enabled = true;
            }
            else CBPublicidad.SelectedIndex = 2;
            if (Id == 0)
            {
                HardwareID h = new HardwareID();
                txtHard.Text = h.ObtenerHardwareID();
                return;
            }

            var model = obj.GetBoxsbyId(Id).Result;
            if (model.Publicity == true)
                CBPublicidad.SelectedIndex = 2;
            else
                CBPublicidad.SelectedIndex = 1;
            txtHard.Text = model.HardwareID;
            txtNombre.Text = model.Name;
            if (model.Rulet == true)
                CBPublicidad.SelectedIndex = 1;
            else
                CBPublicidad.SelectedIndex = 2;
            nudCantidad.Value = model.Amount;

        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (CBPublicidad.SelectedIndex == 0)
                {
                    MessageBox.Show("Se requiere información sobre la publicidad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if(CBRuleta.SelectedIndex == 0)
                {
                    MessageBox.Show("Se requiere información sobre la ruleta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (CBRuleta.SelectedIndex == 1 && nudCantidad.Value <= 0)
                {
                    MessageBox.Show("Se requiere una cantidad minima, para la ruleta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                AppRepository obj = new AppRepository();
                BoxModel model = new BoxModel
                {
                    HardwareID = txtHard.Text,
                    Name = txtNombre.Text,
                    Publicity = CBPublicidad.SelectedIndex == 1 ? false : true,
                    Rulet = CBPublicidad.SelectedIndex == 1 ? true : false,
                    Amount = nudCantidad.Value
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
                        if (Id != exit.Id)
                        {
                            MessageBox.Show("Ya existe una caja registrada con este hardware ID. Verifica que no estés registrando la misma caja nuevamente.", "Caja duplicada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                }
                
                var res = obj.SaveBox(model).Result;
                if (res)
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

        private void CBRuleta_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBRuleta.SelectedIndex == 1)
            {
                nudCantidad.Enabled = true;
            }
            else
            {
                nudCantidad.Enabled = false;
            }
        }
    }
}
