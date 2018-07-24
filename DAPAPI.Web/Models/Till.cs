using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class Till
    {
        public Till()
        {
            TransactionDetails = new HashSet<TransactionDetails>();
        }

        public int Id { get; set; }
        public decimal Balance { get; set; }
        public string BalanceConstraint { get; set; }
        public decimal BalanceDifference { get; set; }
        public int ClientId { get; set; }
        public DateTime ClosedDate { get; set; }
        public decimal ClosingBalance { get; set; }
        public DateTime CreatedAt { get; set; }
        public decimal MaximumBalance { get; set; }
        public decimal MinimumBalance { get; set; }
        public int? OpenedById { get; set; }
        public DateTime OpenedDate { get; set; }
        public int? OriginalTillId { get; set; }
        public int? TellerId { get; set; }
        public string TillState { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public decimal VaultAmount { get; set; }

        public Clients Client { get; set; }
        public Backofficers OpenedBy { get; set; }
        public Backofficers Teller { get; set; }
        public ICollection<TransactionDetails> TransactionDetails { get; set; }
    }
}
