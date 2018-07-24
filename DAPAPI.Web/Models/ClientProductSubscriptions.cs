using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class ClientProductSubscriptions
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public DateTime CreatedAt { get; set; }
        public int? ProductId { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public Clients Client { get; set; }
        public Products Product { get; set; }
    }
}
