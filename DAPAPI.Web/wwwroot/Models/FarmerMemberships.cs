using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class FarmerMemberships
    {
        public long FarmerId { get; set; }
        public long ClientId { get; set; }
    }
}
