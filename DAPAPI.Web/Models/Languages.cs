using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class Languages
    {
        public Languages()
        {
            Clients = new HashSet<Clients>();
        }

        public int Id { get; set; }
        public int? CountryId { get; set; }
        public string Iso6391 { get; set; }
        public string Iso6392 { get; set; }
        public string Name { get; set; }
        public string NativeName { get; set; }

        public Countries Country { get; set; }
        public ICollection<Clients> Clients { get; set; }
    }
}
