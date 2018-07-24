using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class Devices
    {
        public Devices()
        {
            AgentContracts = new HashSet<AgentContracts>();
            DeviceAssignments = new HashSet<DeviceAssignments>();
        }

        public int Id { get; set; }
        public string ApiVersion { get; set; }
        public string AppVersion { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Imei { get; set; }
        public string Imsi { get; set; }
        public bool IsDeviceLocked { get; set; }
        public DateTime LastActivity { get; set; }
        public int? LastKnownLocationId { get; set; }
        public DateTime LastLogin { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string TerminalId { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? AgentAssignedId { get; set; }
        public int ClientId { get; set; }

        public AgentContracts AgentAssigned { get; set; }
        public Clients Client { get; set; }
        public GeoCoordinates LastKnownLocation { get; set; }
        public ICollection<AgentContracts> AgentContracts { get; set; }
        public ICollection<DeviceAssignments> DeviceAssignments { get; set; }
    }
}
