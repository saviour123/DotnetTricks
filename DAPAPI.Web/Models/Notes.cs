using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class Notes
    {
        public Notes()
        {
            Endorsements = new HashSet<Endorsements>();
            JournalEntries = new HashSet<JournalEntries>();
        }

        public int Id { get; set; }
        public int? ActivityId { get; set; }
        public int? AgentContractId { get; set; }
        public int? CentreId { get; set; }
        public DateTime CreatedAt { get; set; }
        public int? CreatedById { get; set; }
        public int? LoanAccountId { get; set; }
        public int? PersonId { get; set; }
        public int? SavingsAccountId { get; set; }
        public string Text { get; set; }
        public int? TransactionDetailId { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int ClientId { get; set; }

        public Activities Activity { get; set; }
        public AgentContracts AgentContract { get; set; }
        public Centre Centre { get; set; }
        public Clients Client { get; set; }
        public Backofficers CreatedBy { get; set; }
        public LoanAccounts LoanAccount { get; set; }
        public People Person { get; set; }
        public SavingsAccounts SavingsAccount { get; set; }
        public TransactionDetails TransactionDetail { get; set; }
        public ICollection<Endorsements> Endorsements { get; set; }
        public ICollection<JournalEntries> JournalEntries { get; set; }
    }
}
