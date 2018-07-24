using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class ExchangeRates
    {
        public long Id { get; set; }
        public decimal BuyRate { get; set; }
        public DateTime CreatedAt { get; set; }
        public long? FromCurrencyId { get; set; }
        public decimal SellRate { get; set; }
        public long? SourceId { get; set; }
        public long? ToCurrencyId { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }
    }
}
