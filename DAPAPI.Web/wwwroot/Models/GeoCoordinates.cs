using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class GeoCoordinates
    {
        public long Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Latitude { get; set; }
        public string Location { get; set; }
        public string Longitude { get; set; }
        public string OwnedEntityType { get; set; }
        public long OwnedEntityTypeId { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public long? FarmerId { get; set; }
    }
}
