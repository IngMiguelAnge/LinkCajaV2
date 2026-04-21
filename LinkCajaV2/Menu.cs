using LinkCajaV2.Catalogs;
using LinkCajaV2.Configuraciones;
using LinkCajaV2.Items;
using LinkCajaV2.Sales;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinkCajaV2
{
    public partial class Menu : Form
    {
        public int IdUsuario { get; set; }
        public int IdTypeUser { get; set; }
        public string NameUser { get; set; }
        public Menu()
        {
            InitializeComponent();
        }


        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            if(IdTypeUser != 1)
            {
                GBConfiguraciones.Visible = false;
                gbCatalogos.Visible = false;
            }
        }

        private void licenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Licenses l = new Licenses();
            l.Show();
        }

        private void btnEmpresa_Click(object sender, EventArgs e)
        {
            Company m = new Company();
            m.Show();
            //this.Hide();
        }

        private void BtnCajas_Click(object sender, EventArgs e)
        {
            Boxs b = new Boxs();
            b.Show();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            Users u = new Users();
            u.Show();
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            Suppliers m = new Suppliers();
            m.Show();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            Clients c = new Clients();
            c.Show();
        }

        private void BtnArticulos_Click(object sender, EventArgs e)
        {
            Articles a = new Articles();
            a.IsVenta = false;
            a.Show();
        }

        private void BtnRecetas_Click(object sender, EventArgs e)
        {
            Recipes r = new Recipes();
            r.Show();
        }

        private void BtnVenta_Click(object sender, EventArgs e)
        {
            Venta s = new Venta();
            s.IdUsuario = IdUsuario;
            s.NameUser = NameUser;
            s.Show();
        }
    }
}