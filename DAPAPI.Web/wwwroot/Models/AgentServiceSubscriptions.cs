using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class AgentServiceSubscriptions
    {
        public long Id { get; set; }
        public decimal AgentCommission { get; set; }
        public long? AgentContractId { get; set; }
        public bool? AllowBankAccountTransactions { get; set; }
        public bool? AllowCardTransactions { get; set; }
        public bool? AllowCashTransactions { get; set; }
        public bool? AllowMobileMoneyTransactions { get; set; }
        public long? ClientId { get; set; }
        public long? ClientServiceSubscriptionId { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool? Enabled { get; set; }
        public decimal? TransactionLimit { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
