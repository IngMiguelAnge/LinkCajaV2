using System;

namespace LinkCajaV2.Model
{
    public class ListTicketModel
    {
        public int Id { get; set; }
        public string User { get; set; }
        public string Client { get; set; }
        public decimal Total { get; set; }  
        public decimal TotalReturn { get; set; }
        public decimal TotalEnd { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public string Status { get; set; }
    }
}
