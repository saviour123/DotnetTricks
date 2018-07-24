using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class Devices
    {
        public long Id { get; set; }
        public string ApiVersion { get; set; }
        public string AppVersion { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Imei { get; set; }
        public string Imsi { get; set; }
        public bool IsDeviceLocked { get; set; }
        public DateTime LastActivity { get; set; }
        public long? LastKnownLocationId { get; set; }
        public DateTime LastLogin { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string TerminalId { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public long? AgentAssignedId { get; set; }
        public long ClientId { get; set; }
    }
}
