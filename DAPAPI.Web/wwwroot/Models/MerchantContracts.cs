using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class MerchantContracts
    {
        public long MerchantId { get; set; }
        public long ClientId { get; set; }
        public DateTime ContractInitiated { get; set; }
        public DateTime ContractModified { get; set; }
        public decimal MerchantCommission { get; set; }
    }
}
