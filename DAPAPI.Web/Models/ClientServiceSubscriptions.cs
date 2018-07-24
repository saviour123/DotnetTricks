using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class ClientServiceSubscriptions
    {
        public ClientServiceSubscriptions()
        {
            AgentServiceSubscriptions = new HashSet<AgentServiceSubscriptions>();
        }

        public int Id { get; set; }
        public bool? AllowBankAccountTransactions { get; set; }
        public bool? AllowCardTransactions { get; set; }
        public bool? AllowCashTransactions { get; set; }
        public bool? AllowMobileMoneyTransactions { get; set; }
        public int ClientId { get; set; }
        public string Code { get; set; }
        public decimal? Commission { get; set; }
        public DateTime CreatedAt { get; set; }
        public decimal? DefaultAgentCommission { get; set; }
        public string Description { get; set; }
        public int? ElectronicValueAccountId { get; set; }
        public decimal? Fee { get; set; }
        public int? ServiceId { get; set; }
        public int? ServiceProviderAccountId { get; set; }
        public int? ServiceProviderId { get; set; }
        public int? SettlementAccountId { get; set; }
        public decimal? TransactionLimit { get; set; }
        public string TransactionReceiptTemplate { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public Clients Client { get; set; }
        public SavingsAccounts ElectronicValueAccount { get; set; }
        public Services Service { get; set; }
        public ServiceProviders ServiceProvider { get; set; }
        public SavingsAccounts ServiceProviderAccount { get; set; }
        public SavingsAccounts SettlementAccount { get; set; }
        public ICollection<AgentServiceSubscriptions> AgentServiceSubscriptions { get; set; }
    }
}
