using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class Backofficers
    {
        public Backofficers()
        {
            Activities = new HashSet<Activities>();
            AgentContracts = new HashSet<AgentContracts>();
            Customers = new HashSet<Customers>();
            Documents = new HashSet<Documents>();
            LoanAccounts = new HashSet<LoanAccounts>();
            Notes = new HashSet<Notes>();
            SavingsAccounts = new HashSet<SavingsAccounts>();
            TasksBackOfficerAssigned = new HashSet<Tasks>();
            TasksTaskCreator = new HashSet<Tasks>();
            TillOpenedBy = new HashSet<Till>();
            TillTeller = new HashSet<Till>();
            TransactionBatchPostingsCheckedBy = new HashSet<TransactionBatchPostings>();
            TransactionBatchPostingsPostedBy = new HashSet<TransactionBatchPostings>();
            TransactionBatches = new HashSet<TransactionBatches>();
            UserActions = new HashSet<UserActions>();
        }

        public int Id { get; set; }
        public int? BranchId { get; set; }
        public int? ClientId { get; set; }
        public int? ContactPhoneId { get; set; }
        public DateTime CreatedAt { get; set; }
        public int? EmailId { get; set; }
        public int? GroupAssignedId { get; set; }
        public int? PersonId { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UserId { get; set; }
        public string Meta { get; set; }
        public int? PartnerId { get; set; }

        public Branches Branch { get; set; }
        public Clients Client { get; set; }
        public PhoneNumbers ContactPhone { get; set; }
        public EmailAddresses Email { get; set; }
        public UserGroups GroupAssigned { get; set; }
        public People Person { get; set; }
        public Users User { get; set; }
        public ICollection<Activities> Activities { get; set; }
        public ICollection<AgentContracts> AgentContracts { get; set; }
        public ICollection<Customers> Customers { get; set; }
        public ICollection<Documents> Documents { get; set; }
        public ICollection<LoanAccounts> LoanAccounts { get; set; }
        public ICollection<Notes> Notes { get; set; }
        public ICollection<SavingsAccounts> SavingsAccounts { get; set; }
        public ICollection<Tasks> TasksBackOfficerAssigned { get; set; }
        public ICollection<Tasks> TasksTaskCreator { get; set; }
        public ICollection<Till> TillOpenedBy { get; set; }
        public ICollection<Till> TillTeller { get; set; }
        public ICollection<TransactionBatchPostings> TransactionBatchPostingsCheckedBy { get; set; }
        public ICollection<TransactionBatchPostings> TransactionBatchPostingsPostedBy { get; set; }
        public ICollection<TransactionBatches> TransactionBatches { get; set; }
        public ICollection<UserActions> UserActions { get; set; }
    }
}
