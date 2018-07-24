using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class UsergroupPrivileges1
    {
        public int Id { get; set; }
        public int? UserGroupId { get; set; }
        public int? PrivilegeId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
