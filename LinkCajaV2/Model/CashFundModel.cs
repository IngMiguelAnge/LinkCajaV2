using System;

namespace LinkCajaV2.Model
{
    public class CashFundModel
    {
        public int Id { get; set; }
        public int IdBox { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public decimal CashIn {  get; set; }
        public decimal CashOut { get; set; }
        public decimal CashFinish { get; set; }
        public bool StatusOpen { get; set; }
    }
}
