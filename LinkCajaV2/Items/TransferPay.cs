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
    public partial class TransferPay : Form
    {
        public decimal TotalCobrar { get; set; }
        public string Folio { get; private set; }
        public TransferPay()
        {
            InitializeComponent();
        }

        private void TransferPay_Load(object sender, EventArgs e)
        {
            lblTotal.Text = $"TOTAL: {TotalCobrar:C2}";
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Folio = txtFolio.Text.Trim();

            // Validacion 
            if (string.IsNullOrEmpty(Folio))
            {
                MessageBox.Show("Debe ingresar el folio o referencia de la transferencia para continuar.", "Dato Requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFolio.Focus();
                return;
            }

            // 2. Validacion de longitud minima 
            if (Folio.Length < 6)
            {
                MessageBox.Show("El folio ingresado es demasiado corto. Por favor, ingrese un número de autorización o clave de rastreo válido (mínimo 6 caracteres).", "Referencia Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFolio.Focus();
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
