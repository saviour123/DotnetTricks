using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class ProductAssignments
    {
        public long Id { get; set; }
        public long AgentContractId { get; set; }
        public long ClientId { get; set; }
        public DateTime CreatedAt { get; set; }
        public long? LoanProductId { get; set; }
        public long? SavingsProductId { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
