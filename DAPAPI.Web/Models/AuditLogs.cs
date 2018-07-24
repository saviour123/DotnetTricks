using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class AuditLogs
    {
        public AuditLogs()
        {
            UserActions = new HashSet<UserActions>();
        }

        public int Id { get; set; }
        public int ClientId { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool Current { get; set; }
        public string Title { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public Clients Client { get; set; }
        public ICollection<UserActions> UserActions { get; set; }
    }
}
