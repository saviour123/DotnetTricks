using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class Clients
    {
        public Clients()
        {
            AccountCustomizations = new HashSet<AccountCustomizations>();
            Activities = new HashSet<Activities>();
            AgentContracts = new HashSet<AgentContracts>();
            AgentServiceSubscriptions = new HashSet<AgentServiceSubscriptions>();
            Agents = new HashSet<Agents>();
            Alias = new HashSet<Alias>();
            AuditLogs = new HashSet<AuditLogs>();
            Backofficers = new HashSet<Backofficers>();
            Beneficiaries = new HashSet<Beneficiaries>();
            Branches = new HashSet<Branches>();
            ClientPartnerships = new HashSet<ClientPartnerships>();
            ClientProductSubscriptions = new HashSet<ClientProductSubscriptions>();
            ClientServiceSubscriptions = new HashSet<ClientServiceSubscriptions>();
            Customers = new HashSet<Customers>();
            DeviceAssignments = new HashSet<DeviceAssignments>();
            Devices = new HashSet<Devices>();
            Documents = new HashSet<Documents>();
            DonationProjectAssignments = new HashSet<DonationProjectAssignments>();
            DonationProjects = new HashSet<DonationProjects>();
            ExternalLinks = new HashSet<ExternalLinks>();
            FarmerMemberships = new HashSet<FarmerMemberships>();
            Forms = new HashSet<Forms>();
            GlAccounts = new HashSet<GlAccounts>();
            GlProductLinks = new HashSet<GlProductLinks>();
            GlReconciliations = new HashSet<GlReconciliations>();
            GroupRole = new HashSet<GroupRole>();
            Groups = new HashSet<Groups>();
            JournalEntries = new HashSet<JournalEntries>();
            JournalPostings = new HashSet<JournalPostings>();
            LoanAccounts = new HashSet<LoanAccounts>();
            LoanProducts = new HashSet<LoanProducts>();
            MerchantContractsClient = new HashSet<MerchantContracts>();
            MerchantContractsMerchant = new HashSet<MerchantContracts>();
            Notes = new HashSet<Notes>();
            ProductAssignments = new HashSet<ProductAssignments>();
            RegionMemberships = new HashSet<RegionMemberships>();
            SavingsAccounts = new HashSet<SavingsAccounts>();
            SavingsProducts = new HashSet<SavingsProducts>();
            Tasks = new HashSet<Tasks>();
            Till = new HashSet<Till>();
            TransactionBatchPostings = new HashSet<TransactionBatchPostings>();
            TransactionBatches = new HashSet<TransactionBatches>();
            TransactionReports = new HashSet<TransactionReports>();
            Transactions = new HashSet<Transactions>();
            UserGroupPrivileges = new HashSet<UserGroupPrivileges>();
            UserGroups = new HashSet<UserGroups>();
            Users = new HashSet<Users>();
            UssdActions = new HashSet<UssdActions>();
            UssdFlows = new HashSet<UssdFlows>();
        }

        public int Id { get; set; }
        public string AccountState { get; set; }
        public string Code { get; set; }
        public int? CountryId { get; set; }
        public DateTime CreatedAt { get; set; }
        public int? CurrencyId { get; set; }
        public string Domain { get; set; }
        public int? IconId { get; set; }
        public bool? IsBankingClient { get; set; }
        public bool IsInsuranceClient { get; set; }
        public bool IsMerchantClient { get; set; }
        public bool IsRevenueCollectionClient { get; set; }
        public int? LanguageId { get; set; }
        public int? LogoId { get; set; }
        public string Name { get; set; }
        public int OrganizationId { get; set; }
        public string ShortName { get; set; }
        public string TagLine { get; set; }
        public string Timezone { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string Meta { get; set; }
        public int? SuperClientId { get; set; }
        public string TillNumber { get; set; }

        public Countries Country { get; set; }
        public Currencies Currency { get; set; }
        public Pictures Icon { get; set; }
        public Languages Language { get; set; }
        public Pictures Logo { get; set; }
        public Organizations Organization { get; set; }
        public ClientConfigurations ClientConfigurations { get; set; }
        public ICollection<AccountCustomizations> AccountCustomizations { get; set; }
        public ICollection<Activities> Activities { get; set; }
        public ICollection<AgentContracts> AgentContracts { get; set; }
        public ICollection<AgentServiceSubscriptions> AgentServiceSubscriptions { get; set; }
        public ICollection<Agents> Agents { get; set; }
        public ICollection<Alias> Alias { get; set; }
        public ICollection<AuditLogs> AuditLogs { get; set; }
        public ICollection<Backofficers> Backofficers { get; set; }
        public ICollection<Beneficiaries> Beneficiaries { get; set; }
        public ICollection<Branches> Branches { get; set; }
        public ICollection<ClientPartnerships> ClientPartnerships { get; set; }
        public ICollection<ClientProductSubscriptions> ClientProductSubscriptions { get; set; }
        public ICollection<ClientServiceSubscriptions> ClientServiceSubscriptions { get; set; }
        public ICollection<Customers> Customers { get; set; }
        public ICollection<DeviceAssignments> DeviceAssignments { get; set; }
        public ICollection<Devices> Devices { get; set; }
        public ICollection<Documents> Documents { get; set; }
        public ICollection<DonationProjectAssignments> DonationProjectAssignments { get; set; }
        public ICollection<DonationProjects> DonationProjects { get; set; }
        public ICollection<ExternalLinks> ExternalLinks { get; set; }
        public ICollection<FarmerMemberships> FarmerMemberships { get; set; }
        public ICollection<Forms> Forms { get; set; }
        public ICollection<GlAccounts> GlAccounts { get; set; }
        public ICollection<GlProductLinks> GlProductLinks { get; set; }
        public ICollection<GlReconciliations> GlReconciliations { get; set; }
        public ICollection<GroupRole> GroupRole { get; set; }
        public ICollection<Groups> Groups { get; set; }
        public ICollection<JournalEntries> JournalEntries { get; set; }
        public ICollection<JournalPostings> JournalPostings { get; set; }
        public ICollection<LoanAccounts> LoanAccounts { get; set; }
        public ICollection<LoanProducts> LoanProducts { get; set; }
        public ICollection<MerchantContracts> MerchantContractsClient { get; set; }
        public ICollection<MerchantContracts> MerchantContractsMerchant { get; set; }
        public ICollection<Notes> Notes { get; set; }
        public ICollection<ProductAssignments> ProductAssignments { get; set; }
        public ICollection<RegionMemberships> RegionMemberships { get; set; }
        public ICollection<SavingsAccounts> SavingsAccounts { get; set; }
        public ICollection<SavingsProducts> SavingsProducts { get; set; }
        public ICollection<Tasks> Tasks { get; set; }
        public ICollection<Till> Till { get; set; }
        public ICollection<TransactionBatchPostings> TransactionBatchPostings { get; set; }
        public ICollection<TransactionBatches> TransactionBatches { get; set; }
        public ICollection<TransactionReports> TransactionReports { get; set; }
        public ICollection<Transactions> Transactions { get; set; }
        public ICollection<UserGroupPrivileges> UserGroupPrivileges { get; set; }
        public ICollection<UserGroups> UserGroups { get; set; }
        public ICollection<Users> Users { get; set; }
        public ICollection<UssdActions> UssdActions { get; set; }
        public ICollection<UssdFlows> UssdFlows { get; set; }
    }
}
