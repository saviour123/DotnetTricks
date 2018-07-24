using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class GlAccounts
    {
        public GlAccounts()
        {
            Activities = new HashSet<Activities>();
            GlProductLinksFeeIncome = new HashSet<GlProductLinks>();
            GlProductLinksFeeReceivable = new HashSet<GlProductLinks>();
            GlProductLinksFundSource = new HashSet<GlProductLinks>();
            GlProductLinksInterestExpense = new HashSet<GlProductLinks>();
            GlProductLinksInterestIncome = new HashSet<GlProductLinks>();
            GlProductLinksInterestReceivable = new HashSet<GlProductLinks>();
            GlProductLinksOverdraftPortfolioControl = new HashSet<GlProductLinks>();
            GlProductLinksPenaltyIncome = new HashSet<GlProductLinks>();
            GlProductLinksPenaltyReceivable = new HashSet<GlProductLinks>();
            GlProductLinksPortfolioControl = new HashSet<GlProductLinks>();
            GlProductLinksWriteOffExpense = new HashSet<GlProductLinks>();
            GlReconciliations = new HashSet<GlReconciliations>();
            InverseParentAccount = new HashSet<GlAccounts>();
            JournalEntries = new HashSet<JournalEntries>();
            JournalPostings = new HashSet<JournalPostings>();
        }

        public int Id { get; set; }
        public bool? Active { get; set; }
        public bool AllowManualJournalEntries { get; set; }
        public decimal Balance { get; set; }
        public DateTime BalanceAsAt { get; set; }
        public int? BranchId { get; set; }
        public string Class { get; set; }
        public int ClientId { get; set; }
        public string BranchCode { get; set; }
        public DateTime CreatedAt { get; set; }
        public int? CurrencyId { get; set; }
        public string Description { get; set; }
        public bool IsHeaderAccount { get; set; }
        public string Name { get; set; }
        public string Number { get; set; }
        public int? ParentAccountId { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public Branches Branch { get; set; }
        public Clients Client { get; set; }
        public Currencies Currency { get; set; }
        public GlAccounts ParentAccount { get; set; }
        public ICollection<Activities> Activities { get; set; }
        public ICollection<GlProductLinks> GlProductLinksFeeIncome { get; set; }
        public ICollection<GlProductLinks> GlProductLinksFeeReceivable { get; set; }
        public ICollection<GlProductLinks> GlProductLinksFundSource { get; set; }
        public ICollection<GlProductLinks> GlProductLinksInterestExpense { get; set; }
        public ICollection<GlProductLinks> GlProductLinksInterestIncome { get; set; }
        public ICollection<GlProductLinks> GlProductLinksInterestReceivable { get; set; }
        public ICollection<GlProductLinks> GlProductLinksOverdraftPortfolioControl { get; set; }
        public ICollection<GlProductLinks> GlProductLinksPenaltyIncome { get; set; }
        public ICollection<GlProductLinks> GlProductLinksPenaltyReceivable { get; set; }
        public ICollection<GlProductLinks> GlProductLinksPortfolioControl { get; set; }
        public ICollection<GlProductLinks> GlProductLinksWriteOffExpense { get; set; }
        public ICollection<GlReconciliations> GlReconciliations { get; set; }
        public ICollection<GlAccounts> InverseParentAccount { get; set; }
        public ICollection<JournalEntries> JournalEntries { get; set; }
        public ICollection<JournalPostings> JournalPostings { get; set; }
    }
}
