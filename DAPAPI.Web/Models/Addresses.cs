using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class Addresses
    {
        public Addresses()
        {
            Organizations = new HashSet<Organizations>();
            Partners = new HashSet<Partners>();
        }

        public int Id { get; set; }
        public string BoxNumber { get; set; }
        public string City { get; set; }
        public int? CountryId { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Description { get; set; }
        public int? GeoCoordinateId { get; set; }
        public int? PersonId { get; set; }
        public string PostCode { get; set; }
        public string Street { get; set; }
        public string Suburb { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? RegionId { get; set; }
        public string HouseNumber { get; set; }

        public Countries Country { get; set; }
        public GeoCoordinates GeoCoordinate { get; set; }
        public People Person { get; set; }
        public ICollection<Organizations> Organizations { get; set; }
        public ICollection<Partners> Partners { get; set; }
    }
}
