using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class Agents
    {
        public Agents()
        {
            AgentContracts = new HashSet<AgentContracts>();
        }

        public int Id { get; set; }
        public bool? Active { get; set; }
        public bool Archived { get; set; }
        public string Code { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsSuperAgent { get; set; }
        public int? PersonId { get; set; }
        public int? RegisteredPhoneNumberId { get; set; }
        public int SupplierId { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? CollectionCentreId { get; set; }

        public People Person { get; set; }
        public PhoneNumbers RegisteredPhoneNumber { get; set; }
        public Clients Supplier { get; set; }
        public ICollection<AgentContracts> AgentContracts { get; set; }
    }
}
