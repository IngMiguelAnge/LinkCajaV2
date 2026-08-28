using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkCajaV2.Model
{
    public class ClienteModel
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; } 
        public string Telefono1 { get; set; } 
        public string Telefono2 { get; set; }

        public string Direccion { get; set; }
        public string Latitud { get; set; }
        public string Longitud { get; set; }
        public decimal CostoEnvio { get; set; }

        public bool Estatus { get; set; }

        public string EstatusTexto
        {
            get { return this.Estatus ? "Activo" : "Inactivo"; }
        }
    }
}
