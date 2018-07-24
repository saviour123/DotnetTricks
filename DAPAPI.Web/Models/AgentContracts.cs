using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class AgentContracts
    {
        public AgentContracts()
        {
            Activities = new HashSet<Activities>();
            AgentServiceSubscriptions = new HashSet<AgentServiceSubscriptions>();
            Customers = new HashSet<Customers>();
            DeviceAssignments = new HashSet<DeviceAssignments>();
            Devices = new HashSet<Devices>();
            DonationProjectAssignments = new HashSet<DonationProjectAssignments>();
            Notes = new HashSet<Notes>();
            ProductAssignments = new HashSet<ProductAssignments>();
            SavingsAccounts = new HashSet<SavingsAccounts>();
            TransactionBatches = new HashSet<TransactionBatches>();
            TransactionDetails = new HashSet<TransactionDetails>();
        }

        public int Id { get; set; }
        public int? AgentContractedId { get; set; }
        public bool Archived { get; set; }
        public int? BranchAssignedId { get; set; }
        public bool Backoffice { get; set; }
        public int ClientId { get; set; }
        public string Code { get; set; }
        public string ContractState { get; set; }
        public DateTime CreatedAt { get; set; }
        public int? DeviceId { get; set; }
        public int? EmailAddressId { get; set; }
        public bool IsOwnAgent { get; set; }
        public string Location { get; set; }
        public int? RegisteredPhoneNumberId { get; set; }
        public int? SupervisorId { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UserId { get; set; }
        public string Meta { get; set; }
        public int? GeoCoordinateId { get; set; }
        public string Type { get; set; }

        public Agents AgentContracted { get; set; }
        public Branches BranchAssigned { get; set; }
        public Clients Client { get; set; }
        public Devices Device { get; set; }
        public EmailAddresses EmailAddress { get; set; }
        public GeoCoordinates GeoCoordinate { get; set; }
        public PhoneNumbers RegisteredPhoneNumber { get; set; }
        public Backofficers Supervisor { get; set; }
        public Users User { get; set; }
        public ICollection<Activities> Activities { get; set; }
        public ICollection<AgentServiceSubscriptions> AgentServiceSubscriptions { get; set; }
        public ICollection<Customers> Customers { get; set; }
        public ICollection<DeviceAssignments> DeviceAssignments { get; set; }
        public ICollection<Devices> Devices { get; set; }
        public ICollection<DonationProjectAssignments> DonationProjectAssignments { get; set; }
        public ICollection<Notes> Notes { get; set; }
        public ICollection<ProductAssignments> ProductAssignments { get; set; }
        public ICollection<SavingsAccounts> SavingsAccounts { get; set; }
        public ICollection<TransactionBatches> TransactionBatches { get; set; }
        public ICollection<TransactionDetails> TransactionDetails { get; set; }
    }
}
