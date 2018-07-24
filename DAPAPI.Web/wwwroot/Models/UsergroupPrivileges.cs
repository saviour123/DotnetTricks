using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class UsergroupPrivileges
    {
        public long Id { get; set; }
        public long? UserGroupId { get; set; }
        public long? PrivilegeId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
