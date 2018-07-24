using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class DonationProjectAssignments
    {
        public int Id { get; set; }
        public int? AgentOnDutyId { get; set; }
        public int ClientId { get; set; }
        public DateTime CreatedAt { get; set; }
        public int? DonationProjectId { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public AgentContracts AgentOnDuty { get; set; }
        public Clients Client { get; set; }
        public DonationProjects DonationProject { get; set; }
    }
}
