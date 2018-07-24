using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class AgentServiceSubscriptions
    {
        public int Id { get; set; }
        public decimal AgentCommission { get; set; }
        public int? AgentContractId { get; set; }
        public bool? AllowBankAccountTransactions { get; set; }
        public bool? AllowCardTransactions { get; set; }
        public bool? AllowCashTransactions { get; set; }
        public bool? AllowMobileMoneyTransactions { get; set; }
        public int? ClientId { get; set; }
        public int? ClientServiceSubscriptionId { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool? Enabled { get; set; }
        public decimal? TransactionLimit { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public AgentContracts AgentContract { get; set; }
        public Clients Client { get; set; }
        public ClientServiceSubscriptions ClientServiceSubscription { get; set; }
    }
}
