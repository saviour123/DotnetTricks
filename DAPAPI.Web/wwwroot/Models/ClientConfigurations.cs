using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class ClientConfigurations
    {
        public long Id { get; set; }
        public string AccountNumberFormat { get; set; }
        public bool AutoReconcile { get; set; }
        public bool BillingEnabled { get; set; }
        public long ClientId { get; set; }
        public long? ControlAccountId { get; set; }
        public DateTime CreatedAt { get; set; }
        public long? SettlementAccountId { get; set; }
        public bool StoreAccounts { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
