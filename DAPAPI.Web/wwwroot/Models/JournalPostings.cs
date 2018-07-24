using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class JournalPostings
    {
        public long Id { get; set; }
        public decimal Amount { get; set; }
        public long ClientId { get; set; }
        public DateTime CreatedAt { get; set; }
        public long? CurrencyId { get; set; }
        public long? GlAccountId { get; set; }
        public long? GlReconciliationId { get; set; }
        public string Indicator { get; set; }
        public string Narration { get; set; }
        public DateTime PostingDate { get; set; }
        public string Reference { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
