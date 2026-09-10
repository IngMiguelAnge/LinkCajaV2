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
    public partial class InputForm : Form
    {
        public string Folio { get;  set; }
        public InputForm()
        {
            InitializeComponent();
        }

        private void InputForm_Load(object sender, EventArgs e)
        {
            txtFolio.Text = Folio;
        }

        private void btnCancelar_Click(object sender, EventArgs e) => this.Close();

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFolio.Text))
            {
                MessageBox.Show("El Folio no puede estar vacío.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Folio = txtFolio.Text;
            DialogResult = DialogResult.OK;
        }
    }
}
