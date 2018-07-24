using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class Countries
    {
        public long Id { get; set; }
        public string Alpha2Code { get; set; }
        public string Alpha3Code { get; set; }
        public string[] AlternateSpellings { get; set; }
        public float? Area { get; set; }
        public string[] Borders { get; set; }
        public string[] CallingCodes { get; set; }
        public string Capital { get; set; }
        public string Cioc { get; set; }
        public string Demonym { get; set; }
        public string Flag { get; set; }
        public long? GeoCoordinatesId { get; set; }
        public float? Gini { get; set; }
        public string Name { get; set; }
        public string NativeName { get; set; }
        public string NumericCode { get; set; }
        public long Population { get; set; }
        public string Region { get; set; }
        public string Subregion { get; set; }
        public string[] Timezones { get; set; }
        public string TopLevelDomain { get; set; }
    }
}
