using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static QuestPDF.Helpers.Colors;

namespace LinkCajaV2.Items
{
    public partial class ConfirmPayTarjet : Form
    {
        public decimal Total { get; set; }
        public string Folio { get; set; }
        public string TipoPago { get; set; }
        public ConfirmPayTarjet()
        {
            InitializeComponent();
        }

        private void ConfirmPayTarjet_Load(object sender, EventArgs e)
        {
            lblTotal.Text = "TOTAL: " + Total.ToString("C");
            TXTFOLIO.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e) => this.Close();

        private void btnConfirmar_Click(object sender, EventArgs e) => Confirmacion();
        public void Confirmacion()
        {
            Folio = TXTFOLIO.Text;
            if (TXTFOLIO.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Se requiere un folio para continuar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (rbCredito.Checked)
                TipoPago = "04";
            else
                TipoPago = "28";
            DialogResult = DialogResult.OK;
        }

    }
}
