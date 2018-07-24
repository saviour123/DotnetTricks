using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class ExternalLinks
    {
        public ExternalLinks()
        {
            ExchangeRates = new HashSet<ExchangeRates>();
        }

        public int Id { get; set; }
        public int? ClientId { get; set; }
        public int? CustomerId { get; set; }
        public string Destination { get; set; }
        public int? GroupId { get; set; }
        public int? IconId { get; set; }
        public int? OrganizationId { get; set; }
        public int? PersonId { get; set; }
        public string Url { get; set; }

        public Clients Client { get; set; }
        public Customers Customer { get; set; }
        public Groups Group { get; set; }
        public Pictures Icon { get; set; }
        public Organizations Organization { get; set; }
        public People Person { get; set; }
        public ICollection<ExchangeRates> ExchangeRates { get; set; }
    }
}
