using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class GlReconciliations
    {
        public GlReconciliations()
        {
            JournalEntries = new HashSet<JournalEntries>();
            JournalPostings = new HashSet<JournalPostings>();
        }

        public int Id { get; set; }
        public int ClientId { get; set; }
        public decimal ClosingBalance { get; set; }
        public DateTime CreatedAt { get; set; }
        public int FirstEntryId { get; set; }
        public int? GlAccountId { get; set; }
        public int LastEntryId { get; set; }
        public decimal OpeningBalance { get; set; }
        public DateTime ReconciledDate { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public Clients Client { get; set; }
        public GlAccounts GlAccount { get; set; }
        public ICollection<JournalEntries> JournalEntries { get; set; }
        public ICollection<JournalPostings> JournalPostings { get; set; }
    }
}
