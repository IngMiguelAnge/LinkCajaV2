using System;
using System.Windows.Forms;

namespace LinkCajaV2.Items
{
    public partial class Decimals : System.Windows.Forms.Form
    {
        public decimal Kilos { get; set; }
        public int Decimales { get; set; }
        public string Presentation { get; set; }
        public string Nombre { get; set; }
        bool primerIngreso = true;
        public decimal MaximoPremios { get; set; }
        public decimal CantidadPorGiro { get; set; }
        public bool EsConfiguracionPremio { get; set; }
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
            if (EsConfiguracionPremio)
            {
                if (NUDKilos.Value <= 0)
                {
                    MessageBox.Show(
                        "El máximo disponible para regalar debe ser mayor a 0.",
                        "Información",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    return;
                }

                if (NUDCantidadGiro.Value <= 0)
                {
                    MessageBox.Show(
                        "La cantidad por giro debe ser mayor a 0.",
                        "Información",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    return;
                }

                if (NUDCantidadGiro.Value > NUDKilos.Value)
                {
                    MessageBox.Show(
                        "La cantidad por giro no puede ser mayor al máximo disponible.",
                        "Información",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    return;
                }

                Kilos = NUDKilos.Value;
                CantidadPorGiro = NUDCantidadGiro.Value;
            }
            else
            {
                Kilos = NUDKilos.Value;
            }

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

        private void Decimals_Load(object sender, EventArgs e)
        {
            if (EsConfiguracionPremio)
            {
                lblMensaje1.Text = "Configure el premio";
                lblMensaje2.Text = "Máximo disponible a regalar:";

                lblCantidadGiro.Visible = true;
                NUDCantidadGiro.Visible = true;

                NUDKilos.DecimalPlaces = 0;
                NUDKilos.Increment = 1M;
                NUDKilos.Maximum = 1000000;

                NUDCantidadGiro.DecimalPlaces = 0;
                NUDCantidadGiro.Increment = 1M;
                NUDCantidadGiro.Minimum = 1;
                NUDCantidadGiro.Maximum = 1000000;

                return;
            }

            lblCantidadGiro.Visible = false;
            NUDCantidadGiro.Visible = false;

            lblMensaje1.Text = "Este articulo se vende por " + Nombre;
            lblMensaje2.Text = Presentation;

            if (Decimales < 3)
            {
                NUDKilos.DecimalPlaces = 0;
                NUDKilos.Increment = 1M;
                NUDKilos.Maximum = 1000000;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
