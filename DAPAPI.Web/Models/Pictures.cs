using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class Pictures
    {
        public Pictures()
        {
            ClientsIcon = new HashSet<Clients>();
            ClientsLogo = new HashSet<Clients>();
            CustomersProfilePicture = new HashSet<Customers>();
            CustomersSignature = new HashSet<Customers>();
            Endorsements = new HashSet<Endorsements>();
            ExternalLinks = new HashSet<ExternalLinks>();
            FingerPrints = new HashSet<FingerPrints>();
            IdentityDocuments = new HashSet<IdentityDocuments>();
            Products = new HashSet<Products>();
            ServiceProviders = new HashSet<ServiceProviders>();
            TransactionDetails = new HashSet<TransactionDetails>();
            Users = new HashSet<Users>();
        }

        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Description { get; set; }
        public int? FileSize { get; set; }
        public string Format { get; set; }
        public string LargeImage { get; set; }
        public string MediumImage { get; set; }
        public string SmallImage { get; set; }
        public string Title { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public ICollection<Clients> ClientsIcon { get; set; }
        public ICollection<Clients> ClientsLogo { get; set; }
        public ICollection<Customers> CustomersProfilePicture { get; set; }
        public ICollection<Customers> CustomersSignature { get; set; }
        public ICollection<Endorsements> Endorsements { get; set; }
        public ICollection<ExternalLinks> ExternalLinks { get; set; }
        public ICollection<FingerPrints> FingerPrints { get; set; }
        public ICollection<IdentityDocuments> IdentityDocuments { get; set; }
        public ICollection<Products> Products { get; set; }
        public ICollection<ServiceProviders> ServiceProviders { get; set; }
        public ICollection<TransactionDetails> TransactionDetails { get; set; }
        public ICollection<Users> Users { get; set; }
    }
}
