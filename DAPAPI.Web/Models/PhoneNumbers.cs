using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class PhoneNumbers
    {
        public PhoneNumbers()
        {
            AgentContracts = new HashSet<AgentContracts>();
            Agents = new HashSet<Agents>();
            Backofficers = new HashSet<Backofficers>();
            Donors = new HashSet<Donors>();
            EmploymentDetails = new HashSet<EmploymentDetails>();
            TransactionDetails = new HashSet<TransactionDetails>();
        }

        public int Id { get; set; }
        public bool? Active { get; set; }
        public string Carrier { get; set; }
        public int? ContactDetailId { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Description { get; set; }
        public string Number { get; set; }
        public string NumberType { get; set; }
        public bool? Ported { get; set; }
        public bool? Primary { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public bool Verified { get; set; }

        public Contacts ContactDetail { get; set; }
        public ICollection<AgentContracts> AgentContracts { get; set; }
        public ICollection<Agents> Agents { get; set; }
        public ICollection<Backofficers> Backofficers { get; set; }
        public ICollection<Donors> Donors { get; set; }
        public ICollection<EmploymentDetails> EmploymentDetails { get; set; }
        public ICollection<TransactionDetails> TransactionDetails { get; set; }
    }
}
