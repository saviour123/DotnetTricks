using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class Services
    {
        public Services()
        {
            Activities = new HashSet<Activities>();
            ClientServiceSubscriptions = new HashSet<ClientServiceSubscriptions>();
            ProductServices = new HashSet<ProductServices>();
            ServiceProviderships = new HashSet<ServiceProviderships>();
            TransactionDetails = new HashSet<TransactionDetails>();
            Transactions = new HashSet<Transactions>();
        }

        public int Id { get; set; }
        public string Branding { get; set; }
        public string Category { get; set; }
        public string Code { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Name { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public ICollection<Activities> Activities { get; set; }
        public ICollection<ClientServiceSubscriptions> ClientServiceSubscriptions { get; set; }
        public ICollection<ProductServices> ProductServices { get; set; }
        public ICollection<ServiceProviderships> ServiceProviderships { get; set; }
        public ICollection<TransactionDetails> TransactionDetails { get; set; }
        public ICollection<Transactions> Transactions { get; set; }
    }
}
