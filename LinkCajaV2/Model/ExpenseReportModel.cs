using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkCajaV2.Model
{
    public class ExpenseReportModel
    {
        public DateTime DateRecord { get; set; }
        public string UserName { get; set; }
        public string Concept { get; set; }
        public decimal Amount { get; set; }
        public bool IsExpense { get; set; }
        public string TypeMovement { get; set; }
    }
}
