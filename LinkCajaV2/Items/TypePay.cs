using LinkCajaV2.Data;
using LinkCajaV2.Model;
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
            AppRepository obj = new AppRepository();

         
            var ListaPagos = obj.GetTypePays().Result;

            //Objeto fantasma
            ListaPagos.Insert(0, new TypePayModel { IdTypePay = "00", Name = "Seleccione" });

            //Combo Box
            cmbMetodoPago.DataSource = null;
            cmbMetodoPago.Items.Clear();

        
            cmbMetodoPago.DisplayMember = "Name";      // Muestra: Efectivo, Tarjeta
            cmbMetodoPago.ValueMember = "IdTypePay";   // Guarda: 01, 04, 03

            // Llenamos los datos
            cmbMetodoPago.DataSource = ListaPagos;

            // Efectivo por defecto 
            if (cmbMetodoPago.Items.Count > 1)
            {
                cmbMetodoPago.SelectedIndex = 1;
            }

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
           
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
