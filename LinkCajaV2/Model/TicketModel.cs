using System;

namespace LinkCajaV2.Model
{
    public class TicketModel
    {
        public int Id { get; set; }
        public int IdUser { get; set; }
        public int IdClient { get; set; } 
        public DateTime CreateDate { get; set; }
        public DateTime Lastmodification { get; set; }
        public bool Status { get; set; }
        public int IdBox { get; set; }
        public decimal Total { get; set; }
        public decimal TotalReturn { get; set; }
        public bool Send { get; set; }
        //public decimal Adjustment { get; set; }
        //public decimal TotalCharged { get; set; }
    }
}
