using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class Languages
    {
        public long Id { get; set; }
        public long? CountryId { get; set; }
        public string Iso6391 { get; set; }
        public string Iso6392 { get; set; }
        public string Name { get; set; }
        public string NativeName { get; set; }
    }
}
