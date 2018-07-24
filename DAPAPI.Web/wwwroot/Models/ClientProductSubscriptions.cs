using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class ClientProductSubscriptions
    {
        public long Id { get; set; }
        public long ClientId { get; set; }
        public DateTime CreatedAt { get; set; }
        public long? ProductId { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
