using LinkCajaV2.Data;
using LinkCajaV2.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace LinkCajaV2.Configuraciones
{
    public partial class Company : System.Windows.Forms.Form
    {
        public Company()
        {
            InitializeComponent();
        }

        private void btnLogo_Click(object sender, EventArgs e)
        {
            OpenFileDialog selector = new OpenFileDialog();
            selector.Filter = "Imagenes|*.jpg;*.jpeg;*.png;*.bmp";

            if (selector.ShowDialog() == DialogResult.OK)
            {
                PBLogo.Image = Image.FromFile(selector.FileName);
                // Ajustamos la imagen al tamaño del PictureBox
                PBLogo.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(txtNombre.Text.Trim() == string.Empty || txtDireccion.Text.Trim() == string.Empty
                || txtEncargado.Text.Trim() == string.Empty || NUDCP.Value <=4
                || txtRFC.Text.Trim() == string.Empty || txtCorreo.Text.Trim() == string.Empty
                || txtTelefono1.Text.Trim() == string.Empty
                || CBRegimen.SelectedIndex == 0)
            {
                MessageBox.Show("Faltan llenar campos obligatorios", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            CompanyModel Empresa = new CompanyModel()
            {
                Name = txtNombre.Text.TrimEnd().TrimStart(),
                Address = txtDireccion.Text,
                CP = (int)NUDCP.Value,
                RFC = txtRFC.Text,  
                Regimen = (string)CBRegimen.SelectedValue,
                Manager = txtEncargado.Text,
                Phone1 = txtTelefono1.Text,
                Phone2 = txtTelefono2.Text,
                Email = txtCorreo.Text,
                BillingName = lblNombreF.Text,
                Logo = PBLogo.Image != null ? ImageToByteArray() : null
            };
            AppRepository obj = new AppRepository();
            if (obj.SaveCompany(Empresa).Result)
            {
                MessageBox.Show("Guardado satisfactoriamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }            
            else
                MessageBox.Show("Error al guardar la información", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        public byte[] ImageToByteArray()
        {
            if (PBLogo.Image == null) return null;

            // Creamos una copia de la imagen para evitar bloqueos de GDI+
            using (Bitmap tempImage = new Bitmap(PBLogo.Image))
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    // Forzamos el guardado en un formato específico (ej. Png o Jpeg)
                    // Esto es mucho más seguro que usar RawFormat
                    tempImage.Save(ms, System.Drawing.Imaging.ImageFormat.Png);

                    return ms.ToArray();
                }
            }
        }

        private void Empresa_Load(object sender, EventArgs e)
        {
            List<RegimenModel> ListRegimen = new List<RegimenModel>();
            ListRegimen.Insert(0, new RegimenModel { Code = "0", Description = "Seleccione" });
            ListRegimen.Insert(1, new RegimenModel { Code = "601", Description = "General de Ley Personas Morales" });
            ListRegimen.Insert(2, new RegimenModel { Code = "603", Description = "Personas Morales con Fines no Lucrativos" });
            ListRegimen.Insert(3, new RegimenModel { Code = "605", Description = "Sueldos y Salarios e Ingresos Asimilados a Salarios" });
            CBRegimen.Items.Clear();
            // Configuramos el ComboBox
            CBRegimen.DisplayMember = "Description";
            CBRegimen.ValueMember = "Code";
            CBRegimen.DataSource = ListRegimen;
            CBRegimen.SelectedIndex = 0;

            AppRepository obj = new AppRepository();
            var Empresa = obj.GetCompany().Result;
            if (Empresa != null)
            {
                txtNombre.Text = Empresa.Name;
                txtDireccion.Text = Empresa.Address;
                NUDCP.Value = Empresa.CP;
                txtRFC.Text = Empresa.RFC;
                CBRegimen.SelectedValue = Empresa.Regimen;
                txtEncargado.Text = Empresa.Manager;
                txtTelefono1.Text = Empresa.Phone1;
                txtTelefono2.Text = Empresa.Phone2;
                txtCorreo.Text = Empresa.Email;
                lblNombreF.Text = Empresa.BillingName;
                if (Empresa.Logo != null)
                {
                    using (MemoryStream ms = new MemoryStream(Empresa.Logo))
                    {
                        PBLogo.Image = Image.FromStream(ms);
                        PBLogo.SizeMode = PictureBoxSizeMode.Zoom;
                    }
                }
            }
        }

        private void txtNombre_KeyUp(object sender, KeyEventArgs e)
        {
            LimpiarRegimenCapital(txtNombre.Text.TrimEnd().TrimStart());
        }
        public void LimpiarRegimenCapital(string nombreEmpresa)
        {
            if (string.IsNullOrWhiteSpace(nombreEmpresa))
                lblNombreF.Text = "_";

            // Esta expresión busca las siglas más comunes al final del texto,
            // ignorando puntos, comas, espacios y mayúsculas/minúsculas.
            string patron = @"[,\s]+(" +
           @"s\.?\s*a\.?\s*p\.?\s*i\.?\s*d\.?\s*e\.?\s*c\.?\s*v\.?|" + // S.A.P.I. de C.V.
           @"s\.?\s*d\.?\s*e\.?\s*r\.?\s*l\.?\s*d\.?\s*e\.?\s*c\.?\s*v\.?|" + // S. de R.L. de C.V.
           @"s\.?\s*c\.?\s*d\.?\s*e\.?\s*r\.?\s*l\.?|" + // S.C. de R.L. (Sociedad Cooperativa)
           @"s\.?\s*a\.?\s*d\.?\s*e\.?\s*c\.?\s*v\.?|" + // S.A. de C.V.
           @"s\.?\s*r\.?\s*l\.?\s*d\.?\s*e\.?\s*c\.?\s*v\.?|" + // S.R.L. de C.V.
           @"s\.?\s*a\.?\s*s\.?|" + // S.A.S. (Simplificada)
           @"s\.?\s*a\.?|" + // S.A.
           @"s\.?\s*c\.?|" + // S.C. (Sociedad Civil)
           @"a\.?\s*c\.?|" + // A.C. (Asociación Civil)
           @"c\.?\s*v\.?" + // C.V. (por si ponen solo de C.V.)
           ")$";
            // Reemplazamos el régimen encontrado por nada
            string textoLimpio = Regex.Replace(nombreEmpresa, patron, "", RegexOptions.IgnoreCase);

            // Quitamos espacios dobles o espacios extras al inicio/final
            lblNombreF.Text = textoLimpio.Trim();
        }
    }
}
