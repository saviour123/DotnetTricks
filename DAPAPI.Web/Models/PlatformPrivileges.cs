using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class PlatformPrivileges
    {
        public PlatformPrivileges()
        {
            UserGroupPrivileges = new HashSet<UserGroupPrivileges>();
        }

        public int Id { get; set; }
        public string Category { get; set; }
        public string Name { get; set; }

        public ICollection<UserGroupPrivileges> UserGroupPrivileges { get; set; }
    }
}
