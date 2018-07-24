using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class TransactionBatches
    {
        public long Id { get; set; }
        public long BackOfficerId { get; set; }
        public decimal? TotalAmount { get; set; }
        public long? BranchId { get; set; }
        public decimal CashOnHand { get; set; }
        public long ClientId { get; set; }
        public DateTime CreatedAt { get; set; }
        public long? CurrencyId { get; set; }
        public int CustomerCount { get; set; }
        public long? DonationId { get; set; }
        public long? FieldTellerId { get; set; }
        public decimal? NetAmount { get; set; }
        public string Reference { get; set; }
        public string State { get; set; }
        public int TransactionCount { get; set; }
        public DateTime TransactionDate { get; set; }
        public long? TransactionReportId { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
