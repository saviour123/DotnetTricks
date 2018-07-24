using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class GroupMembership
    {
        public GroupMembership()
        {
            TransactionDetails = new HashSet<TransactionDetails>();
        }

        public int PersonId { get; set; }
        public int GroupId { get; set; }
        public int? RoleId { get; set; }

        public Groups Group { get; set; }
        public People Person { get; set; }
        public GroupRole Role { get; set; }
        public ICollection<TransactionDetails> TransactionDetails { get; set; }
    }
}
