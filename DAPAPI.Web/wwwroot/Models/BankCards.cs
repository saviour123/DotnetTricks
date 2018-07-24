using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class BankCards
    {
        public long Id { get; set; }
        public long? CardOwnerId { get; set; }
        public string CardType { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Issuer { get; set; }
        public long? LinkedAccountId { get; set; }
        public string PAN { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
