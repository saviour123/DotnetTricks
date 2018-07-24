using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class Clients
    {
        public long Id { get; set; }
        public string AccountState { get; set; }
        public string Code { get; set; }
        public long? CountryId { get; set; }
        public DateTime CreatedAt { get; set; }
        public long? CurrencyId { get; set; }
        public string Domain { get; set; }
        public long? IconId { get; set; }
        public bool? IsBankingClient { get; set; }
        public bool IsInsuranceClient { get; set; }
        public bool IsMerchantClient { get; set; }
        public bool IsRevenueCollectionClient { get; set; }
        public long? LanguageId { get; set; }
        public long? LogoId { get; set; }
        public string Name { get; set; }
        public long OrganizationId { get; set; }
        public string ShortName { get; set; }
        public string TagLine { get; set; }
        public string Timezone { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string Meta { get; set; }
        public long? SuperClientId { get; set; }
        public string TillNumber { get; set; }
    }
}
