using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class TransactionAuthorizations
    {
        public TransactionAuthorizations()
        {
            TransactionDetails = new HashSet<TransactionDetails>();
        }

        public int Id { get; set; }
        public bool Active { get; set; }
        public string AuthorizationCode { get; set; }
        public DateTime CreatedAt { get; set; }
        public int? TransactionId { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public bool Verified { get; set; }

        public Transactions Transaction { get; set; }
        public ICollection<TransactionDetails> TransactionDetails { get; set; }
    }
}
