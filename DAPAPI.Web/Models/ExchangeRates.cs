using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class ExchangeRates
    {
        public int Id { get; set; }
        public decimal BuyRate { get; set; }
        public DateTime CreatedAt { get; set; }
        public int? FromCurrencyId { get; set; }
        public decimal SellRate { get; set; }
        public int? SourceId { get; set; }
        public int? ToCurrencyId { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }

        public Currencies FromCurrency { get; set; }
        public ExternalLinks Source { get; set; }
        public Currencies ToCurrency { get; set; }
    }
}
