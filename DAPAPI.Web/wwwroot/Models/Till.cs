using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class Till
    {
        public long Id { get; set; }
        public decimal Balance { get; set; }
        public string BalanceConstraint { get; set; }
        public decimal BalanceDifference { get; set; }
        public long ClientId { get; set; }
        public DateTime ClosedDate { get; set; }
        public decimal ClosingBalance { get; set; }
        public DateTime CreatedAt { get; set; }
        public decimal MaximumBalance { get; set; }
        public decimal MinimumBalance { get; set; }
        public long? OpenedById { get; set; }
        public DateTime OpenedDate { get; set; }
        public long? OriginalTillId { get; set; }
        public long? TellerId { get; set; }
        public string TillState { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public decimal VaultAmount { get; set; }
    }
}
