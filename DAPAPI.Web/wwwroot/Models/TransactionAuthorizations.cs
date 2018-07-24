using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class TransactionAuthorizations
    {
        public long Id { get; set; }
        public bool Active { get; set; }
        public string AuthorizationCode { get; set; }
        public DateTime CreatedAt { get; set; }
        public long? TransactionId { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public bool Verified { get; set; }
    }
}
