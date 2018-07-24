using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class ProductAssignments
    {
        public int Id { get; set; }
        public int AgentContractId { get; set; }
        public int ClientId { get; set; }
        public DateTime CreatedAt { get; set; }
        public int? LoanProductId { get; set; }
        public int? SavingsProductId { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public AgentContracts AgentContract { get; set; }
        public Clients Client { get; set; }
        public LoanProducts SavingsProduct { get; set; }
        public SavingsProducts SavingsProductNavigation { get; set; }
    }
}
