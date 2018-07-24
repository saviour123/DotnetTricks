using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class EmailAddresses
    {
        public EmailAddresses()
        {
            AgentContracts = new HashSet<AgentContracts>();
            Backofficers = new HashSet<Backofficers>();
            EmploymentDetails = new HashSet<EmploymentDetails>();
            Users = new HashSet<Users>();
        }

        public int Id { get; set; }
        public bool? Active { get; set; }
        public string Address { get; set; }
        public int? ContactDetailId { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Description { get; set; }
        public bool? Primary { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public bool Verified { get; set; }

        public Contacts ContactDetail { get; set; }
        public ICollection<AgentContracts> AgentContracts { get; set; }
        public ICollection<Backofficers> Backofficers { get; set; }
        public ICollection<EmploymentDetails> EmploymentDetails { get; set; }
        public ICollection<Users> Users { get; set; }
    }
}
