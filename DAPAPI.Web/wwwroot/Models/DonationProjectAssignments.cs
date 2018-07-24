using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class DonationProjectAssignments
    {
        public long Id { get; set; }
        public long? AgentOnDutyId { get; set; }
        public long ClientId { get; set; }
        public DateTime CreatedAt { get; set; }
        public long? DonationProjectId { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
