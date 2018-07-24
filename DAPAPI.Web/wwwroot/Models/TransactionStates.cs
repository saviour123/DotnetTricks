using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class TransactionStates
    {
        public long Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public long? InitiatorId { get; set; }
        public string Response { get; set; }
        public string State { get; set; }
        public bool Successful { get; set; }
        public long? TransactionId { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
