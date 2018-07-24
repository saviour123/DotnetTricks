using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class UserActions
    {
        public long Id { get; set; }
        public string Action { get; set; }
        public long ActionSourceId { get; set; }
        public string ActionSourceType { get; set; }
        public long AuditLogId { get; set; }
        public long BackOfficerId { get; set; }
        public DateTime CreatedAt { get; set; }
        public long CustomerId { get; set; }
        public int? PaperTrailVersion { get; set; }
        public string Subject { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
