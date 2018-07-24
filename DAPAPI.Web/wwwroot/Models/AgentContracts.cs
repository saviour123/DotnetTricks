using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class AgentContracts
    {
        public long Id { get; set; }
        public long? AgentContractedId { get; set; }
        public bool Archived { get; set; }
        public long? BranchAssignedId { get; set; }
        public bool Backoffice { get; set; }
        public long ClientId { get; set; }
        public string Code { get; set; }
        public string ContractState { get; set; }
        public DateTime CreatedAt { get; set; }
        public long? DeviceId { get; set; }
        public long? EmailAddressId { get; set; }
        public bool IsOwnAgent { get; set; }
        public string Location { get; set; }
        public long? RegisteredPhoneNumberId { get; set; }
        public long? SupervisorId { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public long? UserId { get; set; }
        public string Meta { get; set; }
        public long? GeoCoordinateId { get; set; }
        public string Type { get; set; }
    }
}
