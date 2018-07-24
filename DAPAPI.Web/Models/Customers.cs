using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class Customers
    {
        public Customers()
        {
            Activities = new HashSet<Activities>();
            Alias = new HashSet<Alias>();
            BankCards = new HashSet<BankCards>();
            DonationProjects = new HashSet<DonationProjects>();
            Endorsements = new HashSet<Endorsements>();
            ExternalLinks = new HashSet<ExternalLinks>();
            FingerPrints = new HashSet<FingerPrints>();
            LoanAccounts = new HashSet<LoanAccounts>();
            QuestionAnswers = new HashSet<QuestionAnswers>();
            SavingsAccounts = new HashSet<SavingsAccounts>();
            TransactionDetails = new HashSet<TransactionDetails>();
            UserActions = new HashSet<UserActions>();
            UssdScreenResponses = new HashSet<UssdScreenResponses>();
        }

        public int Id { get; set; }
        public DateTime ActivatedDate { get; set; }
        public bool? Active { get; set; }
        public int? AgentAssignedId { get; set; }
        public DateTime ApprovedDate { get; set; }
        public string Bbid { get; set; }
        public int? BranchId { get; set; }
        public int ClientId { get; set; }
        public DateTime ClosedDate { get; set; }
        public DateTime CreatedAt { get; set; }
        public int? GroupId { get; set; }
        public bool IsCorporate { get; set; }
        public bool IsGroup { get; set; }
        public bool? IsIndividual { get; set; }
        public string Meta { get; set; }
        public string Number { get; set; }
        public int? OrganizationId { get; set; }
        public int? PersonId { get; set; }
        public int? ProfilePictureId { get; set; }
        public int? RelationshipOfficerId { get; set; }
        public bool SelfServiceEnabled { get; set; }
        public int? SignatureId { get; set; }
        public string Status { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UserId { get; set; }

        public AgentContracts AgentAssigned { get; set; }
        public Branches Branch { get; set; }
        public Clients Client { get; set; }
        public Groups Group { get; set; }
        public Organizations Organization { get; set; }
        public People Person { get; set; }
        public Pictures ProfilePicture { get; set; }
        public Backofficers RelationshipOfficer { get; set; }
        public Pictures Signature { get; set; }
        public Users User { get; set; }
        public ICollection<Activities> Activities { get; set; }
        public ICollection<Alias> Alias { get; set; }
        public ICollection<BankCards> BankCards { get; set; }
        public ICollection<DonationProjects> DonationProjects { get; set; }
        public ICollection<Endorsements> Endorsements { get; set; }
        public ICollection<ExternalLinks> ExternalLinks { get; set; }
        public ICollection<FingerPrints> FingerPrints { get; set; }
        public ICollection<LoanAccounts> LoanAccounts { get; set; }
        public ICollection<QuestionAnswers> QuestionAnswers { get; set; }
        public ICollection<SavingsAccounts> SavingsAccounts { get; set; }
        public ICollection<TransactionDetails> TransactionDetails { get; set; }
        public ICollection<UserActions> UserActions { get; set; }
        public ICollection<UssdScreenResponses> UssdScreenResponses { get; set; }
    }
}
