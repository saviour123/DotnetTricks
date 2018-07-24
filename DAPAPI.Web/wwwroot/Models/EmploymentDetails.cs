using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class EmploymentDetails
    {
        public long Id { get; set; }
        public long? EmployerId { get; set; }
        public DateTime? EndDate { get; set; }
        public bool? IsCurrent { get; set; }
        public string Occupation { get; set; }
        public long? OfficePhoneId { get; set; }
        public long? PersonId { get; set; }
        public string Position { get; set; }
        public DateTime? StartDate { get; set; }
        public long? WorkEmailId { get; set; }
    }
}
