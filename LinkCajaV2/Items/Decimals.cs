using System;
using System.Windows.Forms;

namespace LinkCajaV2.Items
{
    public partial class Decimals : Form
    {
        public decimal Kilos { get; set; }
        bool primerIngreso = true;
        public Decimals()
        {
            InitializeComponent();
        }

        private void NUDKilos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                Kilos = NUDKilos.Value;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            Kilos = NUDKilos.Value;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void NUDKilos_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 1. Permitir teclas de control (como borrar) siempre
            if (char.IsControl(e.KeyChar)) return;

            // 2. Obtener el TextBox interno de forma segura
            TextBox tb = null;
            foreach (Control c in NUDKilos.Controls) { if (c is TextBox) { tb = (TextBox)c; break; } }
            if (tb == null) return;

            // 3. LIMPIEZA AL EMPEZAR A ESCRIBIR
            if (primerIngreso)
            {
                tb.Text = ""; // Borra el "0.000" o lo que esté por default
                primerIngreso = false; // Ya no volverá a borrar en este ingreso
            }

            // 4. VALIDACIÓN DE PUNTO ÚNICO
            if (e.KeyChar == '.')
            {
                if (tb.Text.Contains(".") || tb.Text.Length == 0)
                {
                    e.Handled = true; // Bloquea si ya hay punto o si el punto es el primer carácter
                }
                return;
            }

            // 5. VALIDACIÓN DE DÍGITOS
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                return;
            }

            // 6. LÍMITE VISUAL DE 3 DECIMALES
            int puntoIndex = tb.Text.IndexOf('.');
            if (puntoIndex != -1)
            {
                // Si el cursor está después del punto
                if (tb.SelectionStart > puntoIndex)
                {
                    string[] partes = tb.Text.Split('.');
                    // Si ya hay 3 decimales y no hay texto seleccionado para sobrescribir
                    if (partes.Length > 1 && partes[1].Length >= 3 && tb.SelectionLength == 0)
                    {
                        e.Handled = true; // No deja escribir el cuarto decimal
                    }
                }
            }
        }

    }
}
