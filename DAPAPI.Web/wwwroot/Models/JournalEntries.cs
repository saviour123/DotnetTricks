using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class JournalEntries
    {
        public long Id { get; set; }
        public decimal Amount { get; set; }
        public long? ClientId { get; set; }
        public DateTime CreatedAt { get; set; }
        public long? CurrencyId { get; set; }
        public DateTime EntryDate { get; set; }
        public long EntryId { get; set; }
        public long? GlAccountId { get; set; }
        public long? GlReconciliationId { get; set; }
        public string Indicator { get; set; }
        public bool IsPosted { get; set; }
        public bool IsReversed { get; set; }
        public string Narration { get; set; }
        public long? NoteId { get; set; }
        public DateTime PostedDate { get; set; }
        public string Reference { get; set; }
        public long? ReversalEntryId { get; set; }
        public long? TransactionId { get; set; }

        public JournalEntries ReversalEntry { get; set; }
        public JournalEntries InverseReversalEntry { get; set; }
    }
}
