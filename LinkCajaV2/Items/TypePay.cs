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
    public partial class TypePay : Form
    {

        public string MetodoSeleccionado { get; private set; } //Que selecciona el cajero 
        public TypePay()
        {
            InitializeComponent();
        }

        private void TypePay_Load(object sender, EventArgs e)
        {
            cmbMetodoPago.Items.Clear();
            cmbMetodoPago.Items.Add("Seleccione");
            cmbMetodoPago.Items.Add("Efectivo");    //01 segun sat          
            cmbMetodoPago.Items.Add("Tarjeta");     //04  segun sat
            cmbMetodoPago.Items.Add("Transferencia Bancaria"); //03 segun sat 

            cmbMetodoPago.SelectedIndex = 1;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(cmbMetodoPago.SelectedIndex <= 0)
            {
                MessageBox.Show("Por favor, seleccione un método de pago.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            switch (cmbMetodoPago.SelectedIndex)
            {
                case 1:
                    MetodoSeleccionado = "01";
                    break;
                case 2:
                    MetodoSeleccionado = "04";
                    break;
                case 3:
                    MetodoSeleccionado = "03";
                    break;
                default:
                    MessageBox.Show("Por favor, seleccione un método de pago.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
