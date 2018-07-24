using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class Beneficiaries
    {
        public Beneficiaries()
        {
            People = new HashSet<People>();
        }

        public int Id { get; set; }
        public int ClientId { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Relation { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int PersonId { get; set; }

        public Clients Client { get; set; }
        public People Person { get; set; }
        public ICollection<People> People { get; set; }
    }
}
