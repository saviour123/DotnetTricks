using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class ExternalLinks
    {
        public long Id { get; set; }
        public long? ClientId { get; set; }
        public long? CustomerId { get; set; }
        public string Destination { get; set; }
        public long? GroupId { get; set; }
        public long? IconId { get; set; }
        public long? OrganizationId { get; set; }
        public long? PersonId { get; set; }
        public string Url { get; set; }
    }
}
