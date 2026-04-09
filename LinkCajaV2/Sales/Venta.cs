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
        public Venta()
        {
            InitializeComponent();
        }

        private void Venta_Load(object sender, EventArgs e)
        {
            string ruta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Sounds", "beep.wav");
            lectorSonido = new SoundPlayer(ruta);
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
    }
}
