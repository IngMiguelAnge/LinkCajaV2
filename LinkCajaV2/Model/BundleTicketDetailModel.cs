using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkCajaV2.Model
{
    public class BundleTicketDetailModel
    {
        public int Id { get; set; }
        public int IdBundle { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public decimal Quantity { get; set; }
        public decimal PriceSold { get; set; }
        public decimal TotalSold { get; set; }
        public DateTime CreateDate { get; set; }
        public bool Status { get; set; }
    }
}
