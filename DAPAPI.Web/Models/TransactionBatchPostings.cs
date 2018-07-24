using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class TransactionBatchPostings
    {
        public int Id { get; set; }
        public DateTime CheckedAt { get; set; }
        public int CheckedById { get; set; }
        public int ClientId { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Error { get; set; }
        public int? FailedTransactionId { get; set; }
        public DateTime PostedAt { get; set; }
        public int PostedById { get; set; }
        public string State { get; set; }
        public int? TransactionBatchId { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public Backofficers CheckedBy { get; set; }
        public Clients Client { get; set; }
        public Transactions FailedTransaction { get; set; }
        public Backofficers PostedBy { get; set; }
        public TransactionBatches TransactionBatch { get; set; }
    }
}
