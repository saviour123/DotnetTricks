using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class Backofficers
    {
        public long Id { get; set; }
        public long? BranchId { get; set; }
        public long? ClientId { get; set; }
        public long? ContactPhoneId { get; set; }
        public DateTime CreatedAt { get; set; }
        public long? EmailId { get; set; }
        public long? GroupAssignedId { get; set; }
        public long? PersonId { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public long? UserId { get; set; }
        public string Meta { get; set; }
        public int? PartnerId { get; set; }
    }
}
