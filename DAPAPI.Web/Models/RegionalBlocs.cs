using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class RegionalBlocs
    {
        public int Id { get; set; }
        public string Acronym { get; set; }
        public int? CountryId { get; set; }
        public string Name { get; set; }
        public string[] OtherAcronyms { get; set; }
        public string[] OtherNames { get; set; }

        public Countries Country { get; set; }
    }
}
