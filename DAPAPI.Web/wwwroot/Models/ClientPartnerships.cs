using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class ClientPartnerships
    {
        public long ClientId { get; set; }
        public long PartnerId { get; set; }
    }
}
