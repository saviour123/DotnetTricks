using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class UserGroups
    {
        public UserGroups()
        {
            Backofficers = new HashSet<Backofficers>();
            UserGroupPrivileges = new HashSet<UserGroupPrivileges>();
            Users = new HashSet<Users>();
        }

        public int Id { get; set; }
        public int? ClientId { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Name { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string Description { get; set; }
        public int? PartnerId { get; set; }

        public Clients Client { get; set; }
        public ICollection<Backofficers> Backofficers { get; set; }
        public ICollection<UserGroupPrivileges> UserGroupPrivileges { get; set; }
        public ICollection<Users> Users { get; set; }
    }
}
