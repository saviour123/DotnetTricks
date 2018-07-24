using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class Transactions
    {
        public long Id { get; set; }
        public decimal Amount { get; set; }
        public long? BatchId { get; set; }
        public long ClientId { get; set; }
        public decimal CommissionAmount { get; set; }
        public DateTime CreatedAt { get; set; }
        public string CreditAccount { get; set; }
        public string CreditReceipt { get; set; }
        public long? CurrencyId { get; set; }
        public string DebitAccount { get; set; }
        public string DebitReceipt { get; set; }
        public decimal FeeAmount { get; set; }
        public decimal GrossAmount { get; set; }
        public decimal InterestAmount { get; set; }
        public string Narration { get; set; }
        public decimal OverDraftAmount { get; set; }
        public decimal OverdraftFeesAmount { get; set; }
        public decimal OverdraftInterestAmount { get; set; }
        public string Reference { get; set; }
        public long? RelatedTransactionId { get; set; }
        public long? ReversalTransactionId { get; set; }
        public long SequenceNumber { get; set; }
        public long? ServiceId { get; set; }
        public string Signature { get; set; }
        public string State { get; set; }
        public DateTime Timestamp { get; set; }
        public string TransactionType { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string Meta { get; set; }

        public Transactions RelatedTransaction { get; set; }
        public Transactions ReversalTransaction { get; set; }
        public Transactions InverseRelatedTransaction { get; set; }
        public Transactions InverseReversalTransaction { get; set; }
    }
}
