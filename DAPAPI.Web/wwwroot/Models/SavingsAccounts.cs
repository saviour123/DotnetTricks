using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class SavingsAccounts
    {
        public long Id { get; set; }
        public long? AccountCurrencyId { get; set; }
        public long? AccountOfficerId { get; set; }
        public long? AccountOwnerId { get; set; }
        public string AccountState { get; set; }
        public decimal AccruedInterest { get; set; }
        public DateTime? ActivationDate { get; set; }
        public bool? Active { get; set; }
        public long? AgentContractId { get; set; }
        public decimal Balance { get; set; }
        public DateTime BalanceAsAt { get; set; }
        public long? BranchAssignedId { get; set; }
        public long? CentreAssignedId { get; set; }
        public long ClientId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? DateClosed { get; set; }
        public decimal FeesCollected { get; set; }
        public decimal InterestEarned { get; set; }
        public string Number { get; set; }
        public bool? Primary { get; set; }
        public long? SavingsProductId { get; set; }
        public string Title { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string Meta { get; set; }
    }
}
