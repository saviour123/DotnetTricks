using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class Addresses
    {
        public long Id { get; set; }
        public string BoxNumber { get; set; }
        public string City { get; set; }
        public long? CountryId { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Description { get; set; }
        public long? GeoCoordinateId { get; set; }
        public long? PersonId { get; set; }
        public string PostCode { get; set; }
        public string Street { get; set; }
        public string Suburb { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? RegionId { get; set; }
        public string HouseNumber { get; set; }
    }
}
