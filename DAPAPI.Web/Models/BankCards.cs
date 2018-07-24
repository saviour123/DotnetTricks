using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class BankCards
    {
        public int Id { get; set; }
        public int? CardOwnerId { get; set; }
        public string CardType { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Issuer { get; set; }
        public int? LinkedAccountId { get; set; }
        public string PAN { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public Customers CardOwner { get; set; }
        public SavingsAccounts LinkedAccount { get; set; }
    }
}
