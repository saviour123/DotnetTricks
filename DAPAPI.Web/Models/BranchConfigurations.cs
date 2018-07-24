using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class BranchConfigurations
    {
        public int Id { get; set; }
        public int BranchId { get; set; }
        public bool CanAssignAgents { get; set; }
        public bool CanAssignBackofficers { get; set; }
        public bool CanAssignCustomers { get; set; }
        public DateTime CreatedAt { get; set; }
        public int? SettlementAccountId { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public Branches Branch { get; set; }
        public SavingsAccounts SettlementAccount { get; set; }
    }
}
