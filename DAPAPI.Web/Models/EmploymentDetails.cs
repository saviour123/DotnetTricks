using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class EmploymentDetails
    {
        public int Id { get; set; }
        public int? EmployerId { get; set; }
        public DateTime? EndDate { get; set; }
        public bool? IsCurrent { get; set; }
        public string Occupation { get; set; }
        public int? OfficePhoneId { get; set; }
        public int? PersonId { get; set; }
        public string Position { get; set; }
        public DateTime? StartDate { get; set; }
        public int? WorkEmailId { get; set; }

        public Organizations Employer { get; set; }
        public PhoneNumbers OfficePhone { get; set; }
        public People Person { get; set; }
        public EmailAddresses WorkEmail { get; set; }
    }
}
