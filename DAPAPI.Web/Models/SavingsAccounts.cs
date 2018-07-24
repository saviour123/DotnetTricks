using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class SavingsAccounts
    {
        public SavingsAccounts()
        {
            Activities = new HashSet<Activities>();
            Alias = new HashSet<Alias>();
            BankCards = new HashSet<BankCards>();
            BranchConfigurations = new HashSet<BranchConfigurations>();
            ClientConfigurationsControlAccount = new HashSet<ClientConfigurations>();
            ClientConfigurationsSettlementAccount = new HashSet<ClientConfigurations>();
            ClientServiceSubscriptionsElectronicValueAccount = new HashSet<ClientServiceSubscriptions>();
            ClientServiceSubscriptionsServiceProviderAccount = new HashSet<ClientServiceSubscriptions>();
            ClientServiceSubscriptionsSettlementAccount = new HashSet<ClientServiceSubscriptions>();
            Notes = new HashSet<Notes>();
            TransactionDetails = new HashSet<TransactionDetails>();
        }

        public int Id { get; set; }
        public int? AccountCurrencyId { get; set; }
        public int? AccountOfficerId { get; set; }
        public int? AccountOwnerId { get; set; }
        public string AccountState { get; set; }
        public decimal AccruedInterest { get; set; }
        public DateTime? ActivationDate { get; set; }
        public bool? Active { get; set; }
        public int? AgentContractId { get; set; }
        public decimal Balance { get; set; }
        public DateTime BalanceAsAt { get; set; }
        public int? BranchAssignedId { get; set; }
        public int? CentreAssignedId { get; set; }
        public int ClientId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? DateClosed { get; set; }
        public decimal FeesCollected { get; set; }
        public decimal InterestEarned { get; set; }
        public string Number { get; set; }
        public bool? Primary { get; set; }
        public int? SavingsProductId { get; set; }
        public string Title { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string Meta { get; set; }

        public Currencies AccountCurrency { get; set; }
        public Backofficers AccountOfficer { get; set; }
        public Customers AccountOwner { get; set; }
        public AgentContracts AgentContract { get; set; }
        public Branches BranchAssigned { get; set; }
        public Centre CentreAssigned { get; set; }
        public Clients Client { get; set; }
        public SavingsProducts SavingsProduct { get; set; }
        public ICollection<Activities> Activities { get; set; }
        public ICollection<Alias> Alias { get; set; }
        public ICollection<BankCards> BankCards { get; set; }
        public ICollection<BranchConfigurations> BranchConfigurations { get; set; }
        public ICollection<ClientConfigurations> ClientConfigurationsControlAccount { get; set; }
        public ICollection<ClientConfigurations> ClientConfigurationsSettlementAccount { get; set; }
        public ICollection<ClientServiceSubscriptions> ClientServiceSubscriptionsElectronicValueAccount { get; set; }
        public ICollection<ClientServiceSubscriptions> ClientServiceSubscriptionsServiceProviderAccount { get; set; }
        public ICollection<ClientServiceSubscriptions> ClientServiceSubscriptionsSettlementAccount { get; set; }
        public ICollection<Notes> Notes { get; set; }
        public ICollection<TransactionDetails> TransactionDetails { get; set; }
    }
}
