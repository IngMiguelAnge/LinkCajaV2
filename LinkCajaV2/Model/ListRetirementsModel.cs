using System;

namespace LinkCajaV2.Model
{
    public class ListRetirementsModel
    {
        public int Id { get; set; }
        public string Concept { get; set; }
        public decimal Amount { get; set; }
        public DateTime Created { get; set; }
        public string Status { get; set; }
    }
}
