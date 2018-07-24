using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class LoanAccounts
    {
        public LoanAccounts()
        {
            Activities = new HashSet<Activities>();
            Alias = new HashSet<Alias>();
            Notes = new HashSet<Notes>();
            TransactionDetails = new HashSet<TransactionDetails>();
        }

        public int Id { get; set; }
        public int? AccountCurrencyId { get; set; }
        public int? AccountOfficerId { get; set; }
        public int AccountOwnerId { get; set; }
        public string AccountState { get; set; }
        public decimal AccruedInterest { get; set; }
        public decimal AccruedPenalty { get; set; }
        public DateTime? ActivationDate { get; set; }
        public int? ActivationTransactionId { get; set; }
        public bool? Active { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public int? BranchAssignedId { get; set; }
        public int? CentreAssignedId { get; set; }
        public int ClientId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? DateClosed { get; set; }
        public decimal FeesBalance { get; set; }
        public decimal FeesDue { get; set; }
        public decimal FeesPaid { get; set; }
        public bool HasCustomSchedule { get; set; }
        public decimal InterestBalance { get; set; }
        public decimal InterestCommission { get; set; }
        public decimal InterestDue { get; set; }
        public decimal InterestPaid { get; set; }
        public decimal InterestRate { get; set; }
        public decimal InterestSpread { get; set; }
        public decimal LoanAmount { get; set; }
        public string LoanName { get; set; }
        public int? LoanProductId { get; set; }
        public string Number { get; set; }
        public decimal PenaltyBalance { get; set; }
        public decimal PenaltyDue { get; set; }
        public decimal PenaltyRate { get; set; }
        public bool Primary { get; set; }
        public decimal PrincipalDue { get; set; }
        public decimal PrincipalPaid { get; set; }
        public int RepaymentInstallments { get; set; }
        public string Title { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string Meta { get; set; }

        public Currencies AccountCurrency { get; set; }
        public Backofficers AccountOfficer { get; set; }
        public Customers AccountOwner { get; set; }
        public Branches BranchAssigned { get; set; }
        public Centre CentreAssigned { get; set; }
        public Clients Client { get; set; }
        public LoanProducts LoanProduct { get; set; }
        public ICollection<Activities> Activities { get; set; }
        public ICollection<Alias> Alias { get; set; }
        public ICollection<Notes> Notes { get; set; }
        public ICollection<TransactionDetails> TransactionDetails { get; set; }
    }
}
