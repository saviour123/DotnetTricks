using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class Notes
    {
        public long Id { get; set; }
        public long? ActivityId { get; set; }
        public long? AgentContractId { get; set; }
        public long? CentreId { get; set; }
        public DateTime CreatedAt { get; set; }
        public long? CreatedById { get; set; }
        public long? LoanAccountId { get; set; }
        public long? PersonId { get; set; }
        public long? SavingsAccountId { get; set; }
        public string Text { get; set; }
        public long? TransactionDetailId { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public long ClientId { get; set; }
    }
}
