using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class GeoCoordinates
    {
        public GeoCoordinates()
        {
            Activities = new HashSet<Activities>();
            Addresses = new HashSet<Addresses>();
            AgentContracts = new HashSet<AgentContracts>();
            Countries = new HashSet<Countries>();
            Devices = new HashSet<Devices>();
            Farmers = new HashSet<Farmers>();
            TransactionDetails = new HashSet<TransactionDetails>();
        }

        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Latitude { get; set; }
        public string Location { get; set; }
        public string Longitude { get; set; }
        public string OwnedEntityType { get; set; }
        public int OwnedEntityTypeId { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? FarmerId { get; set; }

        public Farmers Farmer { get; set; }
        public ICollection<Activities> Activities { get; set; }
        public ICollection<Addresses> Addresses { get; set; }
        public ICollection<AgentContracts> AgentContracts { get; set; }
        public ICollection<Countries> Countries { get; set; }
        public ICollection<Devices> Devices { get; set; }
        public ICollection<Farmers> Farmers { get; set; }
        public ICollection<TransactionDetails> TransactionDetails { get; set; }
    }
}
