using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinkCajaV2.Items
{
    public partial class Resultado : Form
    {
        public string Premio {  get; set; }
        public Resultado()
        {
            InitializeComponent();
        }

        private void Resultado_Load(object sender, EventArgs e)
        {
            try
            {
                string imagen = string.Empty;
                if (Premio != "Sin premio")
                {
                    imagen = "Felicidades";
                    txtDescripcion.Text = "Felicidades a ganado: " + Premio;
                }                   
                else
                {
                    imagen = "Perdiste";
                    txtDescripcion.Text = "Suerte para la proxima";
                }
                  
             
                string rutaImagen = Path.Combine(Application.StartupPath, "Icons", imagen+".png");

                // Verificamos si el archivo realmente existe para que no truene el programa
                if (File.Exists(rutaImagen))
                {
                    pictureBox1.Image = Image.FromFile(rutaImagen);
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom; // Para que se adapte bien al tamaño
                }
                else
                {
                    MessageBox.Show("No se encontró la imagen en: " + rutaImagen, "Error de ruta");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la imagen: " + ex.Message);
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
