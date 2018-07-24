using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class Activities
    {
        public Activities()
        {
            InverseParentActivity = new HashSet<Activities>();
            Notes = new HashSet<Notes>();
        }

        public int Id { get; set; }
        public DateTime ActivityDate { get; set; }
        public string ActivityType { get; set; }
        public int? AgentContractedId { get; set; }
        public int? BackOfficerId { get; set; }
        public int? BranchId { get; set; }
        public string Channel { get; set; }
        public int ClientId { get; set; }
        public DateTime CreatedAt { get; set; }
        public int? CustomerId { get; set; }
        public string Description { get; set; }
        public int? GeoCoordinatesId { get; set; }
        public int? GlAccountId { get; set; }
        public int? LoanAccountId { get; set; }
        public int? LoanProductId { get; set; }
        public string Mode { get; set; }
        public int? ParentActivityId { get; set; }
        public string Reference { get; set; }
        public int? SavingsAccountId { get; set; }
        public int? SavingsProductId { get; set; }
        public int? ServiceId { get; set; }
        public string State { get; set; }
        public int? TaskId { get; set; }
        public int? TransactionId { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UserId { get; set; }

        public AgentContracts AgentContracted { get; set; }
        public Backofficers BackOfficer { get; set; }
        public Branches Branch { get; set; }
        public Clients Client { get; set; }
        public Customers Customer { get; set; }
        public GeoCoordinates GeoCoordinates { get; set; }
        public GlAccounts GlAccount { get; set; }
        public LoanAccounts LoanAccount { get; set; }
        public LoanProducts LoanProduct { get; set; }
        public Activities ParentActivity { get; set; }
        public SavingsAccounts SavingsAccount { get; set; }
        public SavingsProducts SavingsProduct { get; set; }
        public Services Service { get; set; }
        public Tasks Task { get; set; }
        public Transactions Transaction { get; set; }
        public Users User { get; set; }
        public ICollection<Activities> InverseParentActivity { get; set; }
        public ICollection<Notes> Notes { get; set; }
    }
}
