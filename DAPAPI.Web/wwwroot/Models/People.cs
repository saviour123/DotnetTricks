using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class People
    {
        public long Id { get; set; }
        public long? ContactDetailsId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public long? EconomicDetailsId { get; set; }
        public string FirstName { get; set; }
        public string Gender { get; set; }
        public long? MaritalDetailsId { get; set; }
        public long? NationalityId { get; set; }
        public long? NextOfKinId { get; set; }
        public string OtherNames { get; set; }
        public string PlaceOfBirth { get; set; }
        public string Surname { get; set; }
        public string Title { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? Age { get; set; }
        public long? RegionId { get; set; }
    }
}
