using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class LoanProducts
    {
        public LoanProducts()
        {
            Activities = new HashSet<Activities>();
            GlProductLinks = new HashSet<GlProductLinks>();
            LoanAccounts = new HashSet<LoanAccounts>();
            ProductAssignments = new HashSet<ProductAssignments>();
            TransactionDetails = new HashSet<TransactionDetails>();
        }

        public int Id { get; set; }
        public bool AccountLinkingEnabled { get; set; }
        public string AccountingMethod { get; set; }
        public bool? Active { get; set; }
        public bool AllowAccountOpening { get; set; }
        public bool AllowSelfService { get; set; }
        public bool AllowTransactions { get; set; }
        public int ClientId { get; set; }
        public string Code { get; set; }
        public decimal? CommissionPercentage { get; set; }
        public DateTime CreatedAt { get; set; }
        public int? CurrencyId { get; set; }
        public int DefaultFirstRepaymentDueDateOffset { get; set; }
        public int DefaultGracePeriod { get; set; }
        public decimal DefaultLoanAmount { get; set; }
        public int DefaultNumInstallments { get; set; }
        public decimal DefaultPenaltyRate { get; set; }
        public string Description { get; set; }
        public int DormancyPeriodDays { get; set; }
        public bool ForCorporates { get; set; }
        public bool ForGroups { get; set; }
        public bool ForIndividuals { get; set; }
        public decimal? InterestRate { get; set; }
        public decimal LoanLimit { get; set; }
        public int LoanPenaltyGracePeriod { get; set; }
        public int LockPeriodDays { get; set; }
        public int MaxFirstRepaymentDueDateOffset { get; set; }
        public int MaxGracePeriod { get; set; }
        public decimal MaxLoanAmount { get; set; }
        public int MaxNumInstallments { get; set; }
        public decimal MaxPenaltyRate { get; set; }
        public int MinFirstRepaymentDueDateOffset { get; set; }
        public int MinGracePeriod { get; set; }
        public decimal MinLoanAmount { get; set; }
        public int MinNumInstallments { get; set; }
        public decimal MinPenaltyRate { get; set; }
        public decimal MinimumBalance { get; set; }
        public string Name { get; set; }
        public decimal? ProcessingFeeRate { get; set; }
        public string ProductType { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public Clients Client { get; set; }
        public Currencies Currency { get; set; }
        public ICollection<Activities> Activities { get; set; }
        public ICollection<GlProductLinks> GlProductLinks { get; set; }
        public ICollection<LoanAccounts> LoanAccounts { get; set; }
        public ICollection<ProductAssignments> ProductAssignments { get; set; }
        public ICollection<TransactionDetails> TransactionDetails { get; set; }
    }
}
