using System;

namespace LinkCajaV2.Model
{
    public class ListDetailsTicketModel
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Stock { get; set; }
        public decimal PriceSold { get; set; }
        public decimal TotalSold { get; set; }
        public DateTime CreateDate { get; set; }
        public string Status { get; set; }
    }
}
