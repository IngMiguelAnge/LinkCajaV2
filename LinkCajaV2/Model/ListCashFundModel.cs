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
    }
}
