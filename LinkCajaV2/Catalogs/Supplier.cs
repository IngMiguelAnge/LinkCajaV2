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

namespace LinkCajaV2.Catalogs
{
    public partial class Supplier : Form
    {
        public int Id { get; set; }
        public Supplier()
        {
            InitializeComponent();
        }

        private void Supplier_Load(object sender, EventArgs e)
        {
            AppRepository obj = new AppRepository();
            var Supplier = obj.GetSuppliersbyId(Id).Result;
            txtNombre.Text = Supplier.Name;
            txtDireccion.Text = Supplier.Address;
            txtTelefono1.Text = Supplier.Phone1;
            txtTelefono2.Text = Supplier.Phone2;
            txtEmail.Text = Supplier.Email;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtDireccion.Text) ||
                string.IsNullOrEmpty(txtTelefono1.Text) || string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Datos incompletos revise la información", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            AppRepository obj = new AppRepository();
            SuppliersModel Supplier = new SuppliersModel
            {
                Id = Id,
                Name = txtNombre.Text,
                Address = txtDireccion.Text,
                Phone1 = txtTelefono1.Text,
                Phone2 = txtTelefono2.Text,
                Email = txtEmail.Text
            };
            if (obj.SaveSupplier(Supplier).Result)
            {
                MessageBox.Show("Proveedor guardado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else MessageBox.Show("Error al guardar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}
