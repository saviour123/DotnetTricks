using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class ServiceProviderships
    {
        public long Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public long ServiceId { get; set; }
        public long ServiceProviderId { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
