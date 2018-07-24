using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class ClientConfigurations
    {
        public int Id { get; set; }
        public string AccountNumberFormat { get; set; }
        public bool AutoReconcile { get; set; }
        public bool BillingEnabled { get; set; }
        public int ClientId { get; set; }
        public int? ControlAccountId { get; set; }
        public DateTime CreatedAt { get; set; }
        public int? SettlementAccountId { get; set; }
        public bool StoreAccounts { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public Clients Client { get; set; }
        public SavingsAccounts ControlAccount { get; set; }
        public SavingsAccounts SettlementAccount { get; set; }
    }
}
