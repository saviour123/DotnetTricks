using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class Donors
    {
        public long Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Description { get; set; }
        public long? DonationId { get; set; }
        public long? PersonId { get; set; }
        public long? PhoneNumberId { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
