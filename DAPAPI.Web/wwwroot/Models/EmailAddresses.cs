using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class EmailAddresses
    {
        public long Id { get; set; }
        public bool? Active { get; set; }
        public string Address { get; set; }
        public long? ContactDetailId { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Description { get; set; }
        public bool? Primary { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public bool Verified { get; set; }
    }
}
