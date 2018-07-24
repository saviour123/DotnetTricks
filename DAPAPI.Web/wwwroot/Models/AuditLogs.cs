using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class AuditLogs
    {
        public long Id { get; set; }
        public long ClientId { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool Current { get; set; }
        public string Title { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
