using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinkCajaV2.Items
{
    public partial class Advertisement : Form
    {
        public Advertisement()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Advertisement_Load(object sender, EventArgs e)
        {
            string urlImagen = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT4qP0E3T-xiaZ2ZIINq0AGs94O8pkNGVuhLCKOSuC-O5XjVEtx7JFZOpQ&s=10";

            try
            {
                PBPublicidad.ImageLocation = urlImagen;
                PBPublicidad.Load();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al cargar la publicidad: " + ex.Message);
            }
        }
    }
}
