using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class UserGroupPrivileges
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool Enabled { get; set; }
        public int? GroupId { get; set; }
        public string Meta { get; set; }
        public int? PrivilegeId { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public Clients Client { get; set; }
        public UserGroups Group { get; set; }
        public PlatformPrivileges Privilege { get; set; }
    }
}
