using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class ServiceProviderships
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public int ServiceId { get; set; }
        public int ServiceProviderId { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public Services Service { get; set; }
        public ServiceProviders ServiceProvider { get; set; }
    }
}
