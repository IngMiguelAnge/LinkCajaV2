using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkCajaV2.Model
{
    public class SalesReportModel
    {
        public string Code { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public decimal QuantitySold { get; set; }
        public decimal Profit { get; set; }
        public decimal SalePrice { get; set; }
        public decimal SupplierPrice { get; set; }
        public decimal TotalInvestment { get; set; }
        public decimal TotalSale { get; set; }
        public decimal CostoEnvio { get; set; }


    }
}
