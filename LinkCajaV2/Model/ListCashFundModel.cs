using System;

namespace LinkCajaV2.Model
{
    public class ListCashFundModel
    {
        public int Id { get; set; }
        public int IdBox { get; set; }
        public string Caja {  get; set; }
        public DateTime Apertura { get; set; }
        public DateTime Cierre { get; set; }
        public string Estatus { get; set; }
        public string Usuario { get; set; }
        public decimal TotalVentas { get; set; }
        public decimal TotalEntradas { get; set; }
        public decimal TotalGastos { get; set; }
        public decimal Diferencia { get; set; }

    }
}
