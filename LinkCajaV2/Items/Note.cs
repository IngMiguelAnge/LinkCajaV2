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
    public partial class Note : Form
    {
        public string NoteText { get; set; }
        public Note()
        {
            InitializeComponent();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtMotive.Text))
            {
                MessageBox.Show("El motivo no puede estar vacío.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            NoteText = txtMotive.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
