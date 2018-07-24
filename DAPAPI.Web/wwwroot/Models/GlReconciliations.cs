using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class GlReconciliations
    {
        public long Id { get; set; }
        public long ClientId { get; set; }
        public decimal ClosingBalance { get; set; }
        public DateTime CreatedAt { get; set; }
        public long FirstEntryId { get; set; }
        public long? GlAccountId { get; set; }
        public long LastEntryId { get; set; }
        public decimal OpeningBalance { get; set; }
        public DateTime ReconciledDate { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
