using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class Farmers
    {
        public long Id { get; set; }
        public long? BankId { get; set; }
        public DateTime CreatedAt { get; set; }
        public long? GeoCoordinateId { get; set; }
        public long? PersonId { get; set; }
        public long? RegionId { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? CollectionCentreId { get; set; }
        public string Data { get; set; }
        public string Code { get; set; }
        public bool? IsApproved { get; set; }
        public bool? IsReviewed { get; set; }
    }
}
