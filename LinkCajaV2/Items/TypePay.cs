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
        public TypePay()
        {
            InitializeComponent();
        }

        private void btbEfectivo_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void btnTarjeta_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.None;
        }
    }
}
