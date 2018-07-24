using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class Donors
    {
        public Donors()
        {
            TransactionDetails = new HashSet<TransactionDetails>();
        }

        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Description { get; set; }
        public int? DonationId { get; set; }
        public int? PersonId { get; set; }
        public int? PhoneNumberId { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public DonationProjects Donation { get; set; }
        public People Person { get; set; }
        public PhoneNumbers PhoneNumber { get; set; }
        public ICollection<TransactionDetails> TransactionDetails { get; set; }
    }
}
