
using System.Collections.Generic;

namespace LinkCajaV2.Model
{
    public class BillingDetails
    {
        public string IdTicket { get; set; }
        public string FormPayment { get; set; }
        public string PaymentMethod { get; set; }
        public string IssuingLocation { get; set; }
        public Sender Sender { get; set; }
        public List<Concepts> Concepts { get; set; }
    }
    public class Sender
    {
        public string RFC { get; set; }
        public string Name { get; set; }
        public string TaxRegime { get; set; }
    }
    public class Concepts
    {
        public string CodeSat { get; set; }
        public string CodeProdServ { get; set; }
        public string Stock { get; set; }
        public string UnitSat { get; set; }
        public string Description { get; set; }
        public string ObjetImp { get; set; }
        public Taxs Tax { get; set; }
    }
    public class Taxs
    {
        public string Base { get; set; }
        public string Tax { get; set; }
        public string TypeFactor { get; set; }
        public string Rate { get; set; }
        public string Import { get; set; }
    }
}
