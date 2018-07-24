using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class GlAccounts
    {
        public GlAccounts()
        {
            InverseParentAccount = new HashSet<GlAccounts>();
        }

        public long Id { get; set; }
        public bool? Active { get; set; }
        public bool AllowManualJournalEntries { get; set; }
        public decimal Balance { get; set; }
        public DateTime BalanceAsAt { get; set; }
        public long? BranchId { get; set; }
        public string Class { get; set; }
        public long ClientId { get; set; }
        public string BranchCode { get; set; }
        public DateTime CreatedAt { get; set; }
        public long? CurrencyId { get; set; }
        public string Description { get; set; }
        public bool IsHeaderAccount { get; set; }
        public string Name { get; set; }
        public string Number { get; set; }
        public long? ParentAccountId { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public GlAccounts ParentAccount { get; set; }
        public ICollection<GlAccounts> InverseParentAccount { get; set; }
    }
}
