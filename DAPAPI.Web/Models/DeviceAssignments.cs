using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class DeviceAssignments
    {
        public int Id { get; set; }
        public int AgentContractId { get; set; }
        public DateTime AssignedFrom { get; set; }
        public DateTime? AssignedTo { get; set; }
        public int ClientId { get; set; }
        public DateTime CreatedAt { get; set; }
        public int DeviceId { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public AgentContracts AgentContract { get; set; }
        public Clients Client { get; set; }
        public Devices Device { get; set; }
    }
}
