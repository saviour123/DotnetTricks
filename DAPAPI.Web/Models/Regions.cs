using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class Regions
    {
        public Regions()
        {
            Banks = new HashSet<Banks>();
            Farmers = new HashSet<Farmers>();
            People = new HashSet<People>();
            RegionMemberships = new HashSet<RegionMemberships>();
        }

        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Name { get; set; }
        public int? PersonId { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string Code { get; set; }

        public People Person { get; set; }
        public ICollection<Banks> Banks { get; set; }
        public ICollection<Farmers> Farmers { get; set; }
        public ICollection<People> People { get; set; }
        public ICollection<RegionMemberships> RegionMemberships { get; set; }
    }
}
