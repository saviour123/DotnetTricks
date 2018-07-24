using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class Groups
    {
        public Groups()
        {
            Customers = new HashSet<Customers>();
            ExternalLinks = new HashSet<ExternalLinks>();
            GroupMembership = new HashSet<GroupMembership>();
        }

        public int Id { get; set; }
        public int ClientId { get; set; }
        public int? ContactDetailsId { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Name { get; set; }
        public string Notes { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public Clients Client { get; set; }
        public Contacts ContactDetails { get; set; }
        public ICollection<Customers> Customers { get; set; }
        public ICollection<ExternalLinks> ExternalLinks { get; set; }
        public ICollection<GroupMembership> GroupMembership { get; set; }
    }
}
