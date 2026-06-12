using System;

namespace LinkCajaV2.Model
{
    public class RetirementModel
    {
        public int Id { get; set; }
        public int IdCashfund { get; set; }
        public string Concept { get; set; }
        public decimal Amount { get; set; }
        public DateTime Created { get; set; }
        public bool Retire { get; set; }
    }
}
