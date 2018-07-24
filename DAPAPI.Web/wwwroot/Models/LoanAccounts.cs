using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class LoanAccounts
    {
        public long Id { get; set; }
        public long? AccountCurrencyId { get; set; }
        public long? AccountOfficerId { get; set; }
        public long AccountOwnerId { get; set; }
        public string AccountState { get; set; }
        public decimal AccruedInterest { get; set; }
        public decimal AccruedPenalty { get; set; }
        public DateTime? ActivationDate { get; set; }
        public long? ActivationTransactionId { get; set; }
        public bool? Active { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public long? BranchAssignedId { get; set; }
        public long? CentreAssignedId { get; set; }
        public long ClientId { get; set; }
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
        public long? LoanProductId { get; set; }
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
    }
}
