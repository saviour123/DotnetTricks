using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class Countries
    {
        public Countries()
        {
            Addresses = new HashSet<Addresses>();
            Clients = new HashSet<Clients>();
            Currencies = new HashSet<Currencies>();
            Languages = new HashSet<Languages>();
            People = new HashSet<People>();
            RegionalBlocs = new HashSet<RegionalBlocs>();
            ServiceProviders = new HashSet<ServiceProviders>();
        }

        public int Id { get; set; }
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
        public int? GeoCoordinatesId { get; set; }
        public float? Gini { get; set; }
        public string Name { get; set; }
        public string NativeName { get; set; }
        public string NumericCode { get; set; }
        public int Population { get; set; }
        public string Region { get; set; }
        public string Subregion { get; set; }
        public string[] Timezones { get; set; }
        public string TopLevelDomain { get; set; }

        public GeoCoordinates GeoCoordinates { get; set; }
        public ICollection<Addresses> Addresses { get; set; }
        public ICollection<Clients> Clients { get; set; }
        public ICollection<Currencies> Currencies { get; set; }
        public ICollection<Languages> Languages { get; set; }
        public ICollection<People> People { get; set; }
        public ICollection<RegionalBlocs> RegionalBlocs { get; set; }
        public ICollection<ServiceProviders> ServiceProviders { get; set; }
    }
}
