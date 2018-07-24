using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class ClientPartnerships
    {
        public int ClientId { get; set; }
        public int PartnerId { get; set; }

        public Clients Client { get; set; }
        public Partners Partner { get; set; }
    }
}
