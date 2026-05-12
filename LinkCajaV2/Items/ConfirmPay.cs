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
        bool primerIngreso = true; 
        public ConfirmPay()
        {
            InitializeComponent();
        }

        private void ConfirmPay_Load(object sender, EventArgs e)
        {
            lblTotal.Text = "TOTAL: " + Total.ToString("C");
            // Aseguramos que empiece con el foco para que primerIngreso funcione
            nudRecibido.Focus();
        }

        private void nudRecibido_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 1. Permitir teclas de control
            if (char.IsControl(e.KeyChar)) return;

            // 2. Obtener el TextBox interno
            TextBox tb = null;
            foreach (Control c in nudRecibido.Controls) { if (c is TextBox) { tb = (TextBox)c; break; } }
            if (tb == null) return;

            // 3. LIMPIEZA AL EMPEZAR A ESCRIBIR 
            if (primerIngreso)
            {
                tb.Text = "";
                primerIngreso = false;
            }

            // 4. VALIDACIÓN DE PUNTO ÚNICO
            if (e.KeyChar == '.')
            {
                if (tb.Text.Contains(".") || tb.Text.Length == 0)
                {
                    e.Handled = true;
                }
                return;
            }

            // 5. VALIDACIÓN DE DÍGITOS
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                return;
            }

            // 6. LÍMITE DE 2 DECIMALES (Ajustado para dinero)
            int puntoIndex = tb.Text.IndexOf('.');
            if (puntoIndex != -1 && tb.SelectionStart > puntoIndex)
            {
                string[] partes = tb.Text.Split('.');
                if (partes.Length > 1 && partes[1].Length >= 2 && tb.SelectionLength == 0)
                {
                    e.Handled = true;
                }
            }
        }

        private void nudRecibido_KeyUp(object sender, KeyEventArgs e)
        {
            // Solo calculamos el cambio si NO estamos en el primer ingreso
            // y si el texto no está vacío
            if (!primerIngreso)
            {
                Cambio();
            }
        }

        public void Cambio()
        {
            if (decimal.TryParse(nudRecibido.Text, out decimal valorActual))
            {
                if (valorActual >= Total)
                    lblCambio.Text = "CAMBIO: " + (valorActual - Total).ToString("C");
                else
                    lblCambio.Text = "CAMBIO: " + (0).ToString("C2");
            }
            else
            {
                // Si el usuario borró todo o el texto no es válido, reseteamos el label
                lblCambio.Text = "CAMBIO: " + (0).ToString("C2");
            }
        }

        private void nudRecibido_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                Confirmacion();
            }
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

        private void btnConfirmar_Click(object sender, EventArgs e) => Confirmacion();
        private void btnCancelar_Click(object sender, EventArgs e) => this.Close();
    }
}