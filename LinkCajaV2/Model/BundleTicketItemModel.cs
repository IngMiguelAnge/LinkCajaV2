using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkCajaV2.Model
{
    public class BundleTicketItemModel
    {
        public int Id { get; set; }
        public int IdBundleTicket { get; set; }
        public int IdArticle { get; set; }
        public decimal UseStock { get; set; }
        public decimal QuantityUsed { get; set; }
        public DateTime CreateDate { get; set; }
        public bool Status { get; set; }

    }
}
