using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class TransactionStates
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public int? InitiatorId { get; set; }
        public string Response { get; set; }
        public string State { get; set; }
        public bool Successful { get; set; }
        public int? TransactionId { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public Users Initiator { get; set; }
        public Transactions Transaction { get; set; }
    }
}
