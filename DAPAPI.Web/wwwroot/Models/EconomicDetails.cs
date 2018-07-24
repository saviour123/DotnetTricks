using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class EconomicDetails
    {
        public long Id { get; set; }
        public string EmploymentStatus { get; set; }
        public string EmploymentType { get; set; }
        public decimal NetMonthlyIncome { get; set; }
    }
}
