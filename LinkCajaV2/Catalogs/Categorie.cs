using ImageMagick;
using LinkCajaV2.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinkCajaV2.Catalogs
{
    public partial class Categorie : System.Windows.Forms.Form
    {
        public int Id { get; set; }
        public Categorie()
        {
            InitializeComponent();
        }

        private void Categorie_Load(object sender, EventArgs e)
        {
            if (Id == 0) return;
            AppRepository obj = new AppRepository();
            var Client = obj.GetCategoriebyId(Id).Result;
            txtNombre.Text = Client.Name;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("Datos incompletos revise la información", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            AppRepository obj = new AppRepository();
            if (obj.SaveCategorie(Id,txtNombre.Text).Result)
            {
                MessageBox.Show("Categoria guardada correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else MessageBox.Show("Error al guardar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}
