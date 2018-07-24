using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class TransactionBatches
    {
        public TransactionBatches()
        {
            TransactionBatchPostings = new HashSet<TransactionBatchPostings>();
            Transactions = new HashSet<Transactions>();
        }

        public int Id { get; set; }
        public int BackOfficerId { get; set; }
        public decimal? TotalAmount { get; set; }
        public int? BranchId { get; set; }
        public decimal CashOnHand { get; set; }
        public int ClientId { get; set; }
        public DateTime CreatedAt { get; set; }
        public int? CurrencyId { get; set; }
        public int CustomerCount { get; set; }
        public int? DonationId { get; set; }
        public int? FieldTellerId { get; set; }
        public decimal? NetAmount { get; set; }
        public string Reference { get; set; }
        public string State { get; set; }
        public int TransactionCount { get; set; }
        public DateTime TransactionDate { get; set; }
        public int? TransactionReportId { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public Backofficers BackOfficer { get; set; }
        public Branches Branch { get; set; }
        public Clients Client { get; set; }
        public Currencies Currency { get; set; }
        public DonationProjects Donation { get; set; }
        public AgentContracts FieldTeller { get; set; }
        public TransactionReports TransactionReport { get; set; }
        public ICollection<TransactionBatchPostings> TransactionBatchPostings { get; set; }
        public ICollection<Transactions> Transactions { get; set; }
    }
}
