using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class GroupMembership
    {
        public long PersonId { get; set; }
        public long GroupId { get; set; }
        public long? RoleId { get; set; }
    }
}
