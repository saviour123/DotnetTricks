using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class Banks
    {
        public long Id { get; set; }
        public string BranchName { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Name { get; set; }
        public long? RegionId { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
