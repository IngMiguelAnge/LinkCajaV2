using System;

namespace LinkCajaV2.Model
{
    public class CashDropModel
    {
        public string Concepto { get; set; }
        public decimal Monto { get; set; }
        public string Articulo {  get; set; }
        public DateTime Fecha { get; set; }
    }
}
