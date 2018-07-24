using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class ClientServiceSubscriptions
    {
        public long Id { get; set; }
        public bool? AllowBankAccountTransactions { get; set; }
        public bool? AllowCardTransactions { get; set; }
        public bool? AllowCashTransactions { get; set; }
        public bool? AllowMobileMoneyTransactions { get; set; }
        public long ClientId { get; set; }
        public string Code { get; set; }
        public decimal? Commission { get; set; }
        public DateTime CreatedAt { get; set; }
        public decimal? DefaultAgentCommission { get; set; }
        public string Description { get; set; }
        public long? ElectronicValueAccountId { get; set; }
        public decimal? Fee { get; set; }
        public long? ServiceId { get; set; }
        public long? ServiceProviderAccountId { get; set; }
        public long? ServiceProviderId { get; set; }
        public long? SettlementAccountId { get; set; }
        public decimal? TransactionLimit { get; set; }
        public string TransactionReceiptTemplate { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
