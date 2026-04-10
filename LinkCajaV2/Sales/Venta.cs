using LinkCajaV2.Catalogs;
using LinkCajaV2.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using static System.Runtime.CompilerServices.RuntimeHelpers;
namespace LinkCajaV2.Sales
{
    public partial class Venta : Form
    {
        private SoundPlayer lectorSonido;
        public int IdUsuario { get; set; }
        public string NameUser { get; set; }
        public Venta()
        {
            InitializeComponent();
        }

        private void Venta_Load(object sender, EventArgs e)
        {
            string ruta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Sounds", "beep.wav");
            lectorSonido = new SoundPlayer(ruta);
            lblUsuario.Text = "Bien venido "+ NameUser;
            
            AppRepository obj = new AppRepository();
            var Empresa = obj.GetCompany().Result;
            if (Empresa != null)
            {
                lblNombreEmpresa.Text = Empresa.Name;
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

        private void txtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                lectorSonido.Play(); // Reproducción instantánea sin lag
                e.SuppressKeyPress = true;
                txtCodigo.Clear();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Articles article = new Articles();
            article.IsVenta = true;
            if (article.ShowDialog() == DialogResult.OK)
            {
                int elid = article.IdSeleccionado;
            }
    
        }

        private void Venta_Shown(object sender, EventArgs e)
        {
            txtCodigo.Focus();
        }
    }
}
