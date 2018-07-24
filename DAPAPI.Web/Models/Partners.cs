using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class Partners
    {
        public Partners()
        {
            ClientPartnerships = new HashSet<ClientPartnerships>();
        }

        public int Id { get; set; }
        public int? AddressId { get; set; }
        public string Code { get; set; }
        public int? ContactDetailId { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Location { get; set; }
        public string Name { get; set; }
        public int? OrganizationId { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UserId { get; set; }

        public Addresses Address { get; set; }
        public Contacts ContactDetail { get; set; }
        public Organizations Organization { get; set; }
        public ICollection<ClientPartnerships> ClientPartnerships { get; set; }
    }
}
