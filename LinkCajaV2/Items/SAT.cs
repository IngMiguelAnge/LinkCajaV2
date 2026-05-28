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
    public partial class SAT : System.Windows.Forms.Form
    {
        public string Clave { get; set; }
        public SAT()
        {
            InitializeComponent();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtClave.Text))
            {
                MessageBox.Show("La Clave no puede estar vacía.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Clave = txtClave.Text;
            DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e) => this.Close();
    }
}
