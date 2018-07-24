using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class GlProductLinks
    {
        public long Id { get; set; }
        public long ClientId { get; set; }
        public DateTime CreatedAt { get; set; }
        public long? FeeIncomeId { get; set; }
        public long? FeeReceivableId { get; set; }
        public long? FundSourceId { get; set; }
        public long? InterestExpenseId { get; set; }
        public long? InterestIncomeId { get; set; }
        public long? InterestReceivableId { get; set; }
        public long? LoanProductId { get; set; }
        public string Methodology { get; set; }
        public long? OverdraftPortfolioControlId { get; set; }
        public long? PenaltyIncomeId { get; set; }
        public long? PenaltyReceivableId { get; set; }
        public long? PortfolioControlId { get; set; }
        public long? SavingsProductId { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public long? WriteOffExpenseId { get; set; }
    }
}
