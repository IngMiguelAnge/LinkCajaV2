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

namespace LinkCajaV2.Items
{
    public partial class SAT : System.Windows.Forms.Form
    {
        public string Clave { get; set; }
        public SAT()
        {
            InitializeComponent();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (CBClaves.SelectedIndex == 0)
            {
                MessageBox.Show("Seleccione una clave", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Clave = (string)CBClaves.SelectedValue;
            DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e) => this.Close();

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            SearchSAT ss = new SearchSAT();
            var sugerenciasFuzzy = ss.BuscarSugerenciasFuzzy(txtDescripcion.Text);
            CBClaves.DataSource = null;
            if (sugerenciasFuzzy.Count > 0)
            {
                sugerenciasFuzzy.Insert(0, new CodeSatModel { Id = "0", Descripcion = "Seleccione", Similares = "" });
                CBClaves.Items.Clear();
                CBClaves.DisplayMember = "Descripcion";
                CBClaves.ValueMember = "Id";
                CBClaves.DataSource = sugerenciasFuzzy;
                CBClaves.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("No hay clave valida para este articulo.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CBClaves_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtDescripcionSat.Text = string.Empty;
            if (CBClaves.SelectedItem is CodeSatModel seleccion && seleccion.Id != "0")
            {
                // Agregamos saltos de línea (\r\n) para que el ToolTip se vea ordenado y legible
                string mensaje = $"Descripción: {seleccion.Descripcion}\r\n" +
                                 $"Similares: {seleccion.Similares}";

                // Muestra el texto completo al pasar el mouse por encima del ComboBox
                txtDescripcionSat.Text = mensaje;
            }
        }
    }
}
