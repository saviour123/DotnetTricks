using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class Banks
    {
        public Banks()
        {
            Farmers = new HashSet<Farmers>();
        }

        public int Id { get; set; }
        public string BranchName { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Name { get; set; }
        public int? RegionId { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public Regions Region { get; set; }
        public ICollection<Farmers> Farmers { get; set; }
    }
}
