using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class Beneficiaries
    {
        public long Id { get; set; }
        public long ClientId { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Relation { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public long PersonId { get; set; }
    }
}
