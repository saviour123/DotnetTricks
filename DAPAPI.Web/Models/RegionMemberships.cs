using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class RegionMemberships
    {
        public int RegionId { get; set; }
        public int ClientId { get; set; }

        public Clients Client { get; set; }
        public Regions Region { get; set; }
    }
}
