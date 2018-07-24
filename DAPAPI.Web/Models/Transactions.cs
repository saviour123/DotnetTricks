using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class Transactions
    {
        public Transactions()
        {
            Activities = new HashSet<Activities>();
            JournalEntries = new HashSet<JournalEntries>();
            TransactionAuthorizations = new HashSet<TransactionAuthorizations>();
            TransactionBatchPostings = new HashSet<TransactionBatchPostings>();
            TransactionStates = new HashSet<TransactionStates>();
        }

        public int Id { get; set; }
        public decimal Amount { get; set; }
        public int? BatchId { get; set; }
        public int ClientId { get; set; }
        public decimal CommissionAmount { get; set; }
        public DateTime CreatedAt { get; set; }
        public string CreditAccount { get; set; }
        public string CreditReceipt { get; set; }
        public int? CurrencyId { get; set; }
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
        public int? RelatedTransactionId { get; set; }
        public int? ReversalTransactionId { get; set; }
        public int SequenceNumber { get; set; }
        public int? ServiceId { get; set; }
        public string Signature { get; set; }
        public string State { get; set; }
        public DateTime Timestamp { get; set; }
        public string TransactionType { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string Meta { get; set; }

        public TransactionBatches Batch { get; set; }
        public Clients Client { get; set; }
        public Currencies Currency { get; set; }
        public Transactions RelatedTransaction { get; set; }
        public Transactions ReversalTransaction { get; set; }
        public Services Service { get; set; }
        public Transactions InverseRelatedTransaction { get; set; }
        public Transactions InverseReversalTransaction { get; set; }
        public TransactionDetails TransactionDetails { get; set; }
        public ICollection<Activities> Activities { get; set; }
        public ICollection<JournalEntries> JournalEntries { get; set; }
        public ICollection<TransactionAuthorizations> TransactionAuthorizations { get; set; }
        public ICollection<TransactionBatchPostings> TransactionBatchPostings { get; set; }
        public ICollection<TransactionStates> TransactionStates { get; set; }
    }
}
