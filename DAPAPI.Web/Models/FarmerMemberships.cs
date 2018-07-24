using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class FarmerMemberships
    {
        public int FarmerId { get; set; }
        public int ClientId { get; set; }

        public Clients Client { get; set; }
        public Farmers Farmer { get; set; }
    }
}
