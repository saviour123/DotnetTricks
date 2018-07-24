using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class Farmers
    {
        public Farmers()
        {
            ApprovalLevels = new HashSet<ApprovalLevels>();
            FarmerMemberships = new HashSet<FarmerMemberships>();
            GeoCoordinates = new HashSet<GeoCoordinates>();
            TransactionDetails = new HashSet<TransactionDetails>();
        }

        public int Id { get; set; }
        public int? BankId { get; set; }
        public DateTime CreatedAt { get; set; }
        public int? GeoCoordinateId { get; set; }
        public int? PersonId { get; set; }
        public int? RegionId { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? CollectionCentreId { get; set; }
        public string Data { get; set; }
        public string Code { get; set; }
        public bool? IsApproved { get; set; }
        public bool? IsReviewed { get; set; }

        public Banks Bank { get; set; }
        public GeoCoordinates GeoCoordinate { get; set; }
        public People Person { get; set; }
        public Regions Region { get; set; }
        public ICollection<ApprovalLevels> ApprovalLevels { get; set; }
        public ICollection<FarmerMemberships> FarmerMemberships { get; set; }
        public ICollection<GeoCoordinates> GeoCoordinates { get; set; }
        public ICollection<TransactionDetails> TransactionDetails { get; set; }
    }
}
