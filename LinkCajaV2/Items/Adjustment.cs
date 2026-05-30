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
    public partial class Adjustment : System.Windows.Forms.Form
    {
        public bool Entrada { get; set; }
        public decimal Existencias { get; set; }
        public decimal Cantidad { get; set; }
        public string Concepto { get; set; }
        public int DecimalPlaces { get; set; }
        public decimal Increment {  get; set; }
        public decimal Maximum { get; set; }
        public Adjustment()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void Adjustment_Load(object sender, EventArgs e)
        {
            nudExistencias.DecimalPlaces = DecimalPlaces;
            nudExistencias.Increment = Increment;
            nudExistencias.Maximum = Maximum;
            if(Entrada == false)
            {
                RBPerdida.Enabled = true;
                RBOtro.Enabled = true;                
            }
        }

        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            if (nudExistencias.Value == 0)
            {
                MessageBox.Show("Se requiere una cantidad.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (Entrada == false && Existencias < nudExistencias.Value)
            {
                MessageBox.Show("No se pueden retirar más existencias de las que hay disponibles.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Concepto = string.Empty;
            if (RBPerdida.Checked == true && Entrada == false)
            {
                Concepto = "Pérdida";
            }
            if (RBPerdida.Checked == false && Entrada == false)
            {
                Concepto = txtMotivo.Text;
            }
            
            Cantidad = nudExistencias.Value;
            this.DialogResult = DialogResult.OK;
        }

        private void RBPerdida_CheckedChanged(object sender, EventArgs e)
        {
            if(RBPerdida.Checked)
            {
                txtMotivo.Text = string.Empty;
                txtMotivo.Enabled = false;
            }    
        }

        private void RBOtro_CheckedChanged(object sender, EventArgs e)
        {
            if (RBOtro.Checked)
                txtMotivo.Enabled = true;
        }
    }
}
