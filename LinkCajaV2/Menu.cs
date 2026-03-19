using LinkCajaV2.Catalogs;
using LinkCajaV2.Configuraciones;
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
        public Menu()
        {
            InitializeComponent();
        }
        private void empresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Company m = new Company();
            m.Show();
            //this.Hide();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Suppliers m = new Suppliers();
            m.Show();
        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clients c = new Clients();
            c.Show();
        }

        private void articulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Articles a = new Articles();
            a.Show();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Users u = new Users();
            u.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            if(IdTypeUser != 1)
            {
                configuracionesToolStripMenuItem.Visible = false;
                catalogosToolStripMenuItem.Visible = false;
            }
        }
    }
}