using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class GlProductLinks
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public DateTime CreatedAt { get; set; }
        public int? FeeIncomeId { get; set; }
        public int? FeeReceivableId { get; set; }
        public int? FundSourceId { get; set; }
        public int? InterestExpenseId { get; set; }
        public int? InterestIncomeId { get; set; }
        public int? InterestReceivableId { get; set; }
        public int? LoanProductId { get; set; }
        public string Methodology { get; set; }
        public int? OverdraftPortfolioControlId { get; set; }
        public int? PenaltyIncomeId { get; set; }
        public int? PenaltyReceivableId { get; set; }
        public int? PortfolioControlId { get; set; }
        public int? SavingsProductId { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? WriteOffExpenseId { get; set; }

        public Clients Client { get; set; }
        public GlAccounts FeeIncome { get; set; }
        public GlAccounts FeeReceivable { get; set; }
        public GlAccounts FundSource { get; set; }
        public GlAccounts InterestExpense { get; set; }
        public GlAccounts InterestIncome { get; set; }
        public GlAccounts InterestReceivable { get; set; }
        public LoanProducts LoanProduct { get; set; }
        public GlAccounts OverdraftPortfolioControl { get; set; }
        public GlAccounts PenaltyIncome { get; set; }
        public GlAccounts PenaltyReceivable { get; set; }
        public GlAccounts PortfolioControl { get; set; }
        public SavingsProducts SavingsProduct { get; set; }
        public GlAccounts WriteOffExpense { get; set; }
    }
}
