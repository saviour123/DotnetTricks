using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class Organizations
    {
        public Organizations()
        {
            Alias = new HashSet<Alias>();
            Clients = new HashSet<Clients>();
            Customers = new HashSet<Customers>();
            EmploymentDetails = new HashSet<EmploymentDetails>();
            ExternalLinks = new HashSet<ExternalLinks>();
            Partners = new HashSet<Partners>();
        }

        public int Id { get; set; }
        public int? AddressId { get; set; }
        public string BusinessName { get; set; }
        public string BusinessRegistrationNumber { get; set; }
        public int? ContactDetailsId { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Industry { get; set; }
        public int? ManagerId { get; set; }
        public string OrganizationType { get; set; }
        public string Sector { get; set; }
        public string TradeName { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public Addresses Address { get; set; }
        public Contacts ContactDetails { get; set; }
        public People Manager { get; set; }
        public ICollection<Alias> Alias { get; set; }
        public ICollection<Clients> Clients { get; set; }
        public ICollection<Customers> Customers { get; set; }
        public ICollection<EmploymentDetails> EmploymentDetails { get; set; }
        public ICollection<ExternalLinks> ExternalLinks { get; set; }
        public ICollection<Partners> Partners { get; set; }
    }
}
