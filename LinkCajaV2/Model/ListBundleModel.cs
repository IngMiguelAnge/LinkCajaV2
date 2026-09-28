using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkCajaV2.Model
{
    public class ListBundleModel
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public decimal BasePrice { get; set; }
        public decimal OfferPrice { get; set; }
        public string Status { get; set; }
        public int Available { get; set; }
    }
}
