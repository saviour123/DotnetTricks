using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class TransactionBatchPostings
    {
        public long Id { get; set; }
        public DateTime CheckedAt { get; set; }
        public long CheckedById { get; set; }
        public long ClientId { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Error { get; set; }
        public long? FailedTransactionId { get; set; }
        public DateTime PostedAt { get; set; }
        public long PostedById { get; set; }
        public string State { get; set; }
        public long? TransactionBatchId { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
