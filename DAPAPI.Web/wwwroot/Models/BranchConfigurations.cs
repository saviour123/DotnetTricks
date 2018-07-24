using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class BranchConfigurations
    {
        public long Id { get; set; }
        public long BranchId { get; set; }
        public bool CanAssignAgents { get; set; }
        public bool CanAssignBackofficers { get; set; }
        public bool CanAssignCustomers { get; set; }
        public DateTime CreatedAt { get; set; }
        public long? SettlementAccountId { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
