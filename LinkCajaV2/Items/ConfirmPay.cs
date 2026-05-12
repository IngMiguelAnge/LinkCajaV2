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
    public partial class ConfirmPay : Form
    {
        public decimal Total { get; set; }
        public decimal Recibido { get; set; }
        public ConfirmPay()
        {
            InitializeComponent();
        }

        private void ConfirmPay_Load(object sender, EventArgs e)
        {
            lblTotal.Text = "TOTAL: " + Total.ToString("C");
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Confirmacion();
        }
        public void Confirmacion()
        {
            Recibido = nudRecibido.Value;
            if (Recibido < Total)
            {
                MessageBox.Show("El monto recibido es menor al total a pagar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult = DialogResult.OK;
        }
        private void nudRecibido_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                Confirmacion();
            }
        }

        private void nudRecibido_ValueChanged(object sender, EventArgs e)
        {
            Cambio();
        }

        private void nudRecibido_KeyUp(object sender, KeyEventArgs e)
        {
            Cambio();
        }
        public void Cambio()
        {
            if (nudRecibido.Value >= Total)
                lblCambio.Text = "CAMBIO: " + (nudRecibido.Value - Total).ToString("C");
            else
                lblCambio.Text = "CAMBIO: " + (0).ToString("C");
        }
    }
}
