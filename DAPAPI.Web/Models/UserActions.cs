using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class UserActions
    {
        public int Id { get; set; }
        public string Action { get; set; }
        public int ActionSourceId { get; set; }
        public string ActionSourceType { get; set; }
        public int AuditLogId { get; set; }
        public int BackOfficerId { get; set; }
        public DateTime CreatedAt { get; set; }
        public int CustomerId { get; set; }
        public int? PaperTrailVersion { get; set; }
        public string Subject { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public AuditLogs AuditLog { get; set; }
        public Backofficers BackOfficer { get; set; }
        public Customers Customer { get; set; }
    }
}
