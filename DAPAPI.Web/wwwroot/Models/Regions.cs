using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class Regions
    {
        public long Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Name { get; set; }
        public long? PersonId { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string Code { get; set; }
    }
}
