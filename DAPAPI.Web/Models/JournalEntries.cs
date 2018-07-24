using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class JournalEntries
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public int? ClientId { get; set; }
        public DateTime CreatedAt { get; set; }
        public int? CurrencyId { get; set; }
        public DateTime EntryDate { get; set; }
        public int EntryId { get; set; }
        public int? GlAccountId { get; set; }
        public int? GlReconciliationId { get; set; }
        public string Indicator { get; set; }
        public bool IsPosted { get; set; }
        public bool IsReversed { get; set; }
        public string Narration { get; set; }
        public int? NoteId { get; set; }
        public DateTime PostedDate { get; set; }
        public string Reference { get; set; }
        public int? ReversalEntryId { get; set; }
        public int? TransactionId { get; set; }

        public Clients Client { get; set; }
        public Currencies Currency { get; set; }
        public GlAccounts GlAccount { get; set; }
        public GlReconciliations GlReconciliation { get; set; }
        public Notes Note { get; set; }
        public JournalEntries ReversalEntry { get; set; }
        public Transactions Transaction { get; set; }
        public JournalEntries InverseReversalEntry { get; set; }
    }
}
