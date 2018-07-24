using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class TransactionDetails
    {
        public TransactionDetails()
        {
            Endorsements = new HashSet<Endorsements>();
            Notes = new HashSet<Notes>();
        }

        public int Id { get; set; }
        public int? BranchId { get; set; }
        public string Channel { get; set; }
        public int? ChequeImageId { get; set; }
        public string ChequeNumber { get; set; }
        public int? CommissionId { get; set; }
        public string CreditResponse { get; set; }
        public int? CustomerId { get; set; }
        public string DebitResponse { get; set; }
        public int? DonorId { get; set; }
        public int? FeeId { get; set; }
        public int? FieldTellerId { get; set; }
        public int? GeoCoordinateId { get; set; }
        public int? GroupMemberGroupId { get; set; }
        public int? GroupMemberPersonId { get; set; }
        public int? LoanAccountId { get; set; }
        public int? LoanId { get; set; }
        public int? LoanProductId { get; set; }
        public string Meta { get; set; }
        public string PaymentMode { get; set; }
        public int? SavingsAccountId { get; set; }
        public int? SavingsProductId { get; set; }
        public int? ServiceId { get; set; }
        public int? TillId { get; set; }
        public int? TransactionAuthorizationId { get; set; }
        public int TransactionId { get; set; }
        public int? TransactionPhoneNumberId { get; set; }
        public int? FarmerId { get; set; }

        public Branches Branch { get; set; }
        public Pictures ChequeImage { get; set; }
        public Customers Customer { get; set; }
        public Donors Donor { get; set; }
        public Farmers Farmer { get; set; }
        public AgentContracts FieldTeller { get; set; }
        public GeoCoordinates GeoCoordinate { get; set; }
        public GroupMembership GroupMember { get; set; }
        public LoanAccounts LoanAccount { get; set; }
        public LoanProducts LoanProduct { get; set; }
        public SavingsAccounts SavingsAccount { get; set; }
        public SavingsProducts SavingsProduct { get; set; }
        public Services Service { get; set; }
        public Till Till { get; set; }
        public Transactions Transaction { get; set; }
        public TransactionAuthorizations TransactionAuthorization { get; set; }
        public PhoneNumbers TransactionPhoneNumber { get; set; }
        public ICollection<Endorsements> Endorsements { get; set; }
        public ICollection<Notes> Notes { get; set; }
    }
}
