using LinkCajaV2.Data;
using System;
using System.Windows.Forms;

namespace LinkCajaV2.Items
{
    public partial class Licenses : Form
    {
          public Licenses()
        {
            InitializeComponent();
        }

        private void License_Load(object sender, EventArgs e)
        {
            AppRepository obj = new AppRepository();
           var licencia = obj.GetKeysActive().Result;
            if (licencia != null)
            {
                EncrypDesencryp des = new EncrypDesencryp();
                string texto= des.Desencriptar(licencia.Key);
                string[] partes = texto.Split(new string[] { "Box", "box" }, StringSplitOptions.None);
                string complement = partes[1]== "10000" ? "Cajas sin limite" : partes[1] + " caja(s)";
                lblMensaje1.Text = "Licencia activa: " + licencia.Name + " para " + complement;
            }
             else
            {
                lblMensaje1.Text = "No hay licencia activa";
            }
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            Instalador i = new Instalador();
            i.ShowDialog();
            if(i.NameLicense != string.Empty)
            {
                string complement = i.Box == "10000" ? "Cajas sin limite" : i.Box + " caja(s)";
                lblMensaje1.Text = "Licencia activa: " + i.NameLicense + " para " + complement;
            }
        }
    }
}
