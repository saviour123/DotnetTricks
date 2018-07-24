using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class ServiceProviders
    {
        public long Id { get; set; }
        public long? CountryId { get; set; }
        public DateTime CreatedAt { get; set; }
        public long? LogoId { get; set; }
        public string Name { get; set; }
        public string Tagline { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
