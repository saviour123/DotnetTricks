using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class Groups
    {
        public long Id { get; set; }
        public long ClientId { get; set; }
        public long? ContactDetailsId { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Name { get; set; }
        public string Notes { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
