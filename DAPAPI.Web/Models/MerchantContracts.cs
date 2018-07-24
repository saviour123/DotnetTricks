using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class MerchantContracts
    {
        public int MerchantId { get; set; }
        public int ClientId { get; set; }
        public DateTime ContractInitiated { get; set; }
        public DateTime ContractModified { get; set; }
        public decimal MerchantCommission { get; set; }

        public Clients Client { get; set; }
        public Clients Merchant { get; set; }
    }
}
