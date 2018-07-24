using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class UserGroupPrivileges
    {
        public long Id { get; set; }
        public long ClientId { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool Enabled { get; set; }
        public long? GroupId { get; set; }
        public string Meta { get; set; }
        public int? PrivilegeId { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
