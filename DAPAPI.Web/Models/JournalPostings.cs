using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class JournalPostings
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public int ClientId { get; set; }
        public DateTime CreatedAt { get; set; }
        public int? CurrencyId { get; set; }
        public int? GlAccountId { get; set; }
        public int? GlReconciliationId { get; set; }
        public string Indicator { get; set; }
        public string Narration { get; set; }
        public DateTime PostingDate { get; set; }
        public string Reference { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public Clients Client { get; set; }
        public Currencies Currency { get; set; }
        public GlAccounts GlAccount { get; set; }
        public GlReconciliations GlReconciliation { get; set; }
    }
}
