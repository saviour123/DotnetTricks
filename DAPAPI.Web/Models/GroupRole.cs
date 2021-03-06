﻿using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class GroupRole
    {
        public GroupRole()
        {
            GroupMembership = new HashSet<GroupMembership>();
        }

        public int Id { get; set; }
        public int ClientId { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Name { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public Clients Client { get; set; }
        public ICollection<GroupMembership> GroupMembership { get; set; }
    }
}
