using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class TransactionDetails
    {
        public long Id { get; set; }
        public long? BranchId { get; set; }
        public string Channel { get; set; }
        public long? ChequeImageId { get; set; }
        public string ChequeNumber { get; set; }
        public int? CommissionId { get; set; }
        public string CreditResponse { get; set; }
        public long? CustomerId { get; set; }
        public string DebitResponse { get; set; }
        public long? DonorId { get; set; }
        public int? FeeId { get; set; }
        public long? FieldTellerId { get; set; }
        public long? GeoCoordinateId { get; set; }
        public long? GroupMemberGroupId { get; set; }
        public long? GroupMemberPersonId { get; set; }
        public long? LoanAccountId { get; set; }
        public int? LoanId { get; set; }
        public long? LoanProductId { get; set; }
        public string Meta { get; set; }
        public string PaymentMode { get; set; }
        public long? SavingsAccountId { get; set; }
        public long? SavingsProductId { get; set; }
        public long? ServiceId { get; set; }
        public long? TillId { get; set; }
        public long? TransactionAuthorizationId { get; set; }
        public long TransactionId { get; set; }
        public long? TransactionPhoneNumberId { get; set; }
        public long? FarmerId { get; set; }
    }
}
