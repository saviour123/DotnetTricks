using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class SavingsProducts
    {
        public SavingsProducts()
        {
            Activities = new HashSet<Activities>();
            GlProductLinks = new HashSet<GlProductLinks>();
            ProductAssignments = new HashSet<ProductAssignments>();
            SavingsAccounts = new HashSet<SavingsAccounts>();
            TransactionDetails = new HashSet<TransactionDetails>();
        }

        public int Id { get; set; }
        public string AccountingMethod { get; set; }
        public bool? Active { get; set; }
        public bool AllowAccountOpening { get; set; }
        public bool AllowArbitraryFees { get; set; }
        public bool AllowDeposits { get; set; }
        public bool AllowOverdraft { get; set; }
        public bool AllowSelfService { get; set; }
        public bool AllowTransactions { get; set; }
        public bool AllowWithdrawals { get; set; }
        public int ClientId { get; set; }
        public string Code { get; set; }
        public decimal? CommissionPercentage { get; set; }
        public DateTime CreatedAt { get; set; }
        public int? CurrencyId { get; set; }
        public decimal DailyTransactionLimit { get; set; }
        public decimal DefaultOpeningBalance { get; set; }
        public string Description { get; set; }
        public int DormancyPeriodDays { get; set; }
        public bool ForCorporates { get; set; }
        public bool ForGroups { get; set; }
        public bool ForIndividuals { get; set; }
        public string InterestCalculationBalance { get; set; }
        public bool InterestPaidIntoAccount { get; set; }
        public string InterestPaymentPoint { get; set; }
        public decimal? InterestRate { get; set; }
        public bool IsBankingProduct { get; set; }
        public bool IsCommissionProduct { get; set; }
        public bool IsInsuranceProduct { get; set; }
        public bool IsSettlementProduct { get; set; }
        public decimal MaxDepositAmount { get; set; }
        public decimal MaxOpeningBalance { get; set; }
        public decimal MaxOverdraftLimit { get; set; }
        public decimal MaxWidthdrawalAmount { get; set; }
        public decimal MinDepositAmount { get; set; }
        public decimal MinOpeningBalance { get; set; }
        public decimal MinWidthdrawalAmount { get; set; }
        public decimal MinimumBalance { get; set; }
        public string Name { get; set; }
        public decimal PercentageCharge { get; set; }
        public string ProductType { get; set; }
        public decimal TransactionThreshold { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public Clients Client { get; set; }
        public Currencies Currency { get; set; }
        public ICollection<Activities> Activities { get; set; }
        public ICollection<GlProductLinks> GlProductLinks { get; set; }
        public ICollection<ProductAssignments> ProductAssignments { get; set; }
        public ICollection<SavingsAccounts> SavingsAccounts { get; set; }
        public ICollection<TransactionDetails> TransactionDetails { get; set; }
    }
}
