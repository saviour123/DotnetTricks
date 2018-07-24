using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class Users
    {
        public Users()
        {
            Activities = new HashSet<Activities>();
            AgentContracts = new HashSet<AgentContracts>();
            ApprovalLevels = new HashSet<ApprovalLevels>();
            Backofficers = new HashSet<Backofficers>();
            Customers = new HashSet<Customers>();
            OauthAccessGrants = new HashSet<OauthAccessGrants>();
            OauthAccessTokens = new HashSet<OauthAccessTokens>();
            TransactionStates = new HashSet<TransactionStates>();
        }

        public int Id { get; set; }
        public int? ClientId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? CurrentSignInAt { get; set; }
        public string CurrentSignInIp { get; set; }
        public int? EmailId { get; set; }
        public string EncryptedPassword { get; set; }
        public int FailedAttempts { get; set; }
        public string HashedPin { get; set; }
        public bool IsAgent { get; set; }
        public bool IsBackofficer { get; set; }
        public bool IsCustomer { get; set; }
        public bool? IsNotified { get; set; }
        public bool IsPlatformAdmin { get; set; }
        public DateTime? LastSignInAt { get; set; }
        public string LastSignInIp { get; set; }
        public DateTime? LockedAt { get; set; }
        public int? PersonId { get; set; }
        public int? ProfilePictureId { get; set; }
        public DateTime? RememberCreatedAt { get; set; }
        public DateTime? ResetPasswordSentAt { get; set; }
        public string ResetPasswordToken { get; set; }
        public string Role { get; set; }
        public string Salt { get; set; }
        public int SignInCount { get; set; }
        public string State { get; set; }
        public string Title { get; set; }
        public string UnlockToken { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string Username { get; set; }
        public string Meta { get; set; }
        public bool IsClient { get; set; }
        public bool IsSuperClient { get; set; }
        public int? UserGroupId { get; set; }
        public string PasswordDigest { get; set; }
        public int? PhoneNumberId { get; set; }

        public Clients Client { get; set; }
        public EmailAddresses Email { get; set; }
        public People Person { get; set; }
        public Pictures ProfilePicture { get; set; }
        public UserGroups UserGroup { get; set; }
        public ICollection<Activities> Activities { get; set; }
        public ICollection<AgentContracts> AgentContracts { get; set; }
        public ICollection<ApprovalLevels> ApprovalLevels { get; set; }
        public ICollection<Backofficers> Backofficers { get; set; }
        public ICollection<Customers> Customers { get; set; }
        public ICollection<OauthAccessGrants> OauthAccessGrants { get; set; }
        public ICollection<OauthAccessTokens> OauthAccessTokens { get; set; }
        public ICollection<TransactionStates> TransactionStates { get; set; }
    }
}
