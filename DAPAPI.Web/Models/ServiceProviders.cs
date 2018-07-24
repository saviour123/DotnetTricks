using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class ServiceProviders
    {
        public ServiceProviders()
        {
            ClientServiceSubscriptions = new HashSet<ClientServiceSubscriptions>();
            ServiceProviderships = new HashSet<ServiceProviderships>();
        }

        public int Id { get; set; }
        public int? CountryId { get; set; }
        public DateTime CreatedAt { get; set; }
        public int? LogoId { get; set; }
        public string Name { get; set; }
        public string Tagline { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public Countries Country { get; set; }
        public Pictures Logo { get; set; }
        public ICollection<ClientServiceSubscriptions> ClientServiceSubscriptions { get; set; }
        public ICollection<ServiceProviderships> ServiceProviderships { get; set; }
    }
}
