using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DAPAPI.Web.Models
{
    public partial class lemon_testContext : DbContext
    {
        public lemon_testContext()
        {
        }

        public lemon_testContext(DbContextOptions<lemon_testContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AccountCustomizations> AccountCustomizations { get; set; }
        public virtual DbSet<Activities> Activities { get; set; }
        public virtual DbSet<Addresses> Addresses { get; set; }
        public virtual DbSet<AgentContracts> AgentContracts { get; set; }
        public virtual DbSet<Agents> Agents { get; set; }
        public virtual DbSet<AgentServiceSubscriptions> AgentServiceSubscriptions { get; set; }
        public virtual DbSet<Alias> Alias { get; set; }
        public virtual DbSet<ApprovalLevels> ApprovalLevels { get; set; }
        public virtual DbSet<ArInternalMetadata> ArInternalMetadata { get; set; }
        public virtual DbSet<AuditEntries> AuditEntries { get; set; }
        public virtual DbSet<AuditEntryProperties> AuditEntryProperties { get; set; }
        public virtual DbSet<AuditLogs> AuditLogs { get; set; }
        public virtual DbSet<Backofficers> Backofficers { get; set; }
        public virtual DbSet<BankCards> BankCards { get; set; }
        public virtual DbSet<Banks> Banks { get; set; }
        public virtual DbSet<Beneficiaries> Beneficiaries { get; set; }
        public virtual DbSet<BranchConfigurations> BranchConfigurations { get; set; }
        public virtual DbSet<Branches> Branches { get; set; }
        public virtual DbSet<Centre> Centre { get; set; }
        public virtual DbSet<ClientConfigurations> ClientConfigurations { get; set; }
        public virtual DbSet<ClientPartnerships> ClientPartnerships { get; set; }
        public virtual DbSet<ClientProductSubscriptions> ClientProductSubscriptions { get; set; }
        public virtual DbSet<Clients> Clients { get; set; }
        public virtual DbSet<ClientServiceSubscriptions> ClientServiceSubscriptions { get; set; }
        public virtual DbSet<CollectionCentres> CollectionCentres { get; set; }
        public virtual DbSet<Contacts> Contacts { get; set; }
        public virtual DbSet<Countries> Countries { get; set; }
        public virtual DbSet<Currencies> Currencies { get; set; }
        public virtual DbSet<CustomerQuestions> CustomerQuestions { get; set; }
        public virtual DbSet<Customers> Customers { get; set; }
        public virtual DbSet<Customization> Customization { get; set; }
        public virtual DbSet<DependentQuestions> DependentQuestions { get; set; }
        public virtual DbSet<DependentSections> DependentSections { get; set; }
        public virtual DbSet<DeviceAssignments> DeviceAssignments { get; set; }
        public virtual DbSet<Devices> Devices { get; set; }
        public virtual DbSet<Documents> Documents { get; set; }
        public virtual DbSet<DonationProjectAssignments> DonationProjectAssignments { get; set; }
        public virtual DbSet<DonationProjects> DonationProjects { get; set; }
        public virtual DbSet<Donors> Donors { get; set; }
        public virtual DbSet<EconomicDetails> EconomicDetails { get; set; }
        public virtual DbSet<EfMigrationsHistory> EfMigrationsHistory { get; set; }
        public virtual DbSet<EmailAddresses> EmailAddresses { get; set; }
        public virtual DbSet<EmploymentDetails> EmploymentDetails { get; set; }
        public virtual DbSet<Endorsements> Endorsements { get; set; }
        public virtual DbSet<ExchangeRates> ExchangeRates { get; set; }
        public virtual DbSet<ExternalLinks> ExternalLinks { get; set; }
        public virtual DbSet<FarmerMemberships> FarmerMemberships { get; set; }
        public virtual DbSet<Farmers> Farmers { get; set; }
        public virtual DbSet<FingerPrints> FingerPrints { get; set; }
        public virtual DbSet<Forms> Forms { get; set; }
        public virtual DbSet<FormSections> FormSections { get; set; }
        public virtual DbSet<GeoCoordinates> GeoCoordinates { get; set; }
        public virtual DbSet<GlAccounts> GlAccounts { get; set; }
        public virtual DbSet<GlProductLinks> GlProductLinks { get; set; }
        public virtual DbSet<GlReconciliations> GlReconciliations { get; set; }
        public virtual DbSet<GroupMembership> GroupMembership { get; set; }
        public virtual DbSet<GroupRole> GroupRole { get; set; }
        public virtual DbSet<Groups> Groups { get; set; }
        public virtual DbSet<IdentityDocuments> IdentityDocuments { get; set; }
        public virtual DbSet<JournalEntries> JournalEntries { get; set; }
        public virtual DbSet<JournalPostings> JournalPostings { get; set; }
        public virtual DbSet<Languages> Languages { get; set; }
        public virtual DbSet<LoanAccounts> LoanAccounts { get; set; }
        public virtual DbSet<LoanProducts> LoanProducts { get; set; }
        public virtual DbSet<MaritalDetails> MaritalDetails { get; set; }
        public virtual DbSet<MerchantContracts> MerchantContracts { get; set; }
        public virtual DbSet<Notes> Notes { get; set; }
        public virtual DbSet<OauthAccessGrants> OauthAccessGrants { get; set; }
        public virtual DbSet<OauthAccessTokens> OauthAccessTokens { get; set; }
        public virtual DbSet<OauthApplications> OauthApplications { get; set; }
        public virtual DbSet<Organizations> Organizations { get; set; }
        public virtual DbSet<OtherBankAccount> OtherBankAccount { get; set; }
        public virtual DbSet<Partners> Partners { get; set; }
        public virtual DbSet<People> People { get; set; }
        public virtual DbSet<PhoneNumbers> PhoneNumbers { get; set; }
        public virtual DbSet<Pictures> Pictures { get; set; }
        public virtual DbSet<PlatformPrivileges> PlatformPrivileges { get; set; }
        public virtual DbSet<Privileges> Privileges { get; set; }
        public virtual DbSet<ProductAssignments> ProductAssignments { get; set; }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<ProductServices> ProductServices { get; set; }
        public virtual DbSet<QuestionAnswers> QuestionAnswers { get; set; }
        public virtual DbSet<QuestionOptions> QuestionOptions { get; set; }
        public virtual DbSet<Questions> Questions { get; set; }
        public virtual DbSet<QuestionTypes> QuestionTypes { get; set; }
        public virtual DbSet<RegionalBlocs> RegionalBlocs { get; set; }
        public virtual DbSet<RegionMemberships> RegionMemberships { get; set; }
        public virtual DbSet<Regions> Regions { get; set; }
        public virtual DbSet<SavingsAccounts> SavingsAccounts { get; set; }
        public virtual DbSet<SavingsProducts> SavingsProducts { get; set; }
        public virtual DbSet<SchemaMigrations> SchemaMigrations { get; set; }
        public virtual DbSet<ScreenTypes> ScreenTypes { get; set; }
        public virtual DbSet<ServiceProviders> ServiceProviders { get; set; }
        public virtual DbSet<ServiceProviderships> ServiceProviderships { get; set; }
        public virtual DbSet<Services> Services { get; set; }
        public virtual DbSet<Tasks> Tasks { get; set; }
        public virtual DbSet<Till> Till { get; set; }
        public virtual DbSet<TransactionAuthorizations> TransactionAuthorizations { get; set; }
        public virtual DbSet<TransactionBatches> TransactionBatches { get; set; }
        public virtual DbSet<TransactionBatchPostings> TransactionBatchPostings { get; set; }
        public virtual DbSet<TransactionDetails> TransactionDetails { get; set; }
        public virtual DbSet<TransactionReports> TransactionReports { get; set; }
        public virtual DbSet<Transactions> Transactions { get; set; }
        public virtual DbSet<TransactionStates> TransactionStates { get; set; }
        public virtual DbSet<UserActions> UserActions { get; set; }
        public virtual DbSet<UserGroupPrivileges> UserGroupPrivileges { get; set; }
        public virtual DbSet<UsergroupPrivileges1> UsergroupPrivileges1 { get; set; }
        public virtual DbSet<UserGroups> UserGroups { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<UssdActions> UssdActions { get; set; }
        public virtual DbSet<UssdFlows> UssdFlows { get; set; }
        public virtual DbSet<UssdScreenOptions> UssdScreenOptions { get; set; }
        public virtual DbSet<UssdScreenResponses> UssdScreenResponses { get; set; }
        public virtual DbSet<UssdScreens> UssdScreens { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseNpgsql("Host=localhost;Database=lemon_test;Username=sav;Password=sav");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AccountCustomizations>(entity =>
            {
                entity.ToTable("account_customizations");

                entity.HasIndex(e => e.ClientId)
                    .HasName("index_account_customizations_on_client_id");

                entity.HasIndex(e => e.CustomizationId)
                    .HasName("index_account_customizations_on_customization_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.CustomizationId).HasColumnName("customization_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("timestamp with time zone");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.AccountCustomizations)
                    .HasForeignKey(d => d.ClientId)
                    .HasConstraintName("fk_account_customizations_clients");

                entity.HasOne(d => d.Customization)
                    .WithMany(p => p.AccountCustomizations)
                    .HasForeignKey(d => d.CustomizationId)
                    .HasConstraintName("fk_account_customizations_customizations");
            });

            modelBuilder.Entity<Activities>(entity =>
            {
                entity.ToTable("activities");

                entity.HasIndex(e => e.ActivityType);

                entity.HasIndex(e => e.AgentContractedId);

                entity.HasIndex(e => e.BackOfficerId);

                entity.HasIndex(e => e.BranchId);

                entity.HasIndex(e => e.Channel);

                entity.HasIndex(e => e.ClientId);

                entity.HasIndex(e => e.CreatedAt);

                entity.HasIndex(e => e.CustomerId);

                entity.HasIndex(e => e.GeoCoordinatesId);

                entity.HasIndex(e => e.GlAccountId);

                entity.HasIndex(e => e.LoanAccountId);

                entity.HasIndex(e => e.LoanProductId);

                entity.HasIndex(e => e.Mode);

                entity.HasIndex(e => e.ParentActivityId);

                entity.HasIndex(e => e.Reference);

                entity.HasIndex(e => e.SavingsAccountId);

                entity.HasIndex(e => e.SavingsProductId);

                entity.HasIndex(e => e.ServiceId);

                entity.HasIndex(e => e.State);

                entity.HasIndex(e => e.TaskId);

                entity.HasIndex(e => e.TransactionId);

                entity.HasIndex(e => e.UpdatedAt);

                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ActivityDate)
                    .HasColumnName("activity_date")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.ActivityType).HasColumnName("activity_type");

                entity.Property(e => e.AgentContractedId).HasColumnName("agent_contracted_id");

                entity.Property(e => e.BackOfficerId).HasColumnName("back_officer_id");

                entity.Property(e => e.BranchId).HasColumnName("branch_id");

                entity.Property(e => e.Channel).HasColumnName("channel");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.GeoCoordinatesId).HasColumnName("geo_coordinates_id");

                entity.Property(e => e.GlAccountId).HasColumnName("gl_account_id");

                entity.Property(e => e.LoanAccountId).HasColumnName("loan_account_id");

                entity.Property(e => e.LoanProductId).HasColumnName("loan_product_id");

                entity.Property(e => e.Mode).HasColumnName("mode");

                entity.Property(e => e.ParentActivityId).HasColumnName("parent_activity_id");

                entity.Property(e => e.Reference).HasColumnName("reference");

                entity.Property(e => e.SavingsAccountId).HasColumnName("savings_account_id");

                entity.Property(e => e.SavingsProductId).HasColumnName("savings_product_id");

                entity.Property(e => e.ServiceId).HasColumnName("service_id");

                entity.Property(e => e.State).HasColumnName("state");

                entity.Property(e => e.TaskId).HasColumnName("task_id");

                entity.Property(e => e.TransactionId).HasColumnName("transaction_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.AgentContracted)
                    .WithMany(p => p.Activities)
                    .HasForeignKey(d => d.AgentContractedId);

                entity.HasOne(d => d.BackOfficer)
                    .WithMany(p => p.Activities)
                    .HasForeignKey(d => d.BackOfficerId);

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.Activities)
                    .HasForeignKey(d => d.BranchId);

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.Activities)
                    .HasForeignKey(d => d.ClientId);

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Activities)
                    .HasForeignKey(d => d.CustomerId);

                entity.HasOne(d => d.GeoCoordinates)
                    .WithMany(p => p.Activities)
                    .HasForeignKey(d => d.GeoCoordinatesId);

                entity.HasOne(d => d.GlAccount)
                    .WithMany(p => p.Activities)
                    .HasForeignKey(d => d.GlAccountId);

                entity.HasOne(d => d.LoanAccount)
                    .WithMany(p => p.Activities)
                    .HasForeignKey(d => d.LoanAccountId);

                entity.HasOne(d => d.LoanProduct)
                    .WithMany(p => p.Activities)
                    .HasForeignKey(d => d.LoanProductId);

                entity.HasOne(d => d.ParentActivity)
                    .WithMany(p => p.InverseParentActivity)
                    .HasForeignKey(d => d.ParentActivityId);

                entity.HasOne(d => d.SavingsAccount)
                    .WithMany(p => p.Activities)
                    .HasForeignKey(d => d.SavingsAccountId);

                entity.HasOne(d => d.SavingsProduct)
                    .WithMany(p => p.Activities)
                    .HasForeignKey(d => d.SavingsProductId);

                entity.HasOne(d => d.Service)
                    .WithMany(p => p.Activities)
                    .HasForeignKey(d => d.ServiceId);

                entity.HasOne(d => d.Task)
                    .WithMany(p => p.Activities)
                    .HasForeignKey(d => d.TaskId);

                entity.HasOne(d => d.Transaction)
                    .WithMany(p => p.Activities)
                    .HasForeignKey(d => d.TransactionId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Activities)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<Addresses>(entity =>
            {
                entity.ToTable("addresses");

                entity.HasIndex(e => e.City);

                entity.HasIndex(e => e.CountryId);

                entity.HasIndex(e => e.GeoCoordinateId);

                entity.HasIndex(e => e.PersonId);

                entity.HasIndex(e => e.RegionId)
                    .HasName("index_addresses_on_region_id");

                entity.HasIndex(e => e.UpdatedAt);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BoxNumber).HasColumnName("box_number");

                entity.Property(e => e.City).HasColumnName("city");

                entity.Property(e => e.CountryId).HasColumnName("country_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.GeoCoordinateId).HasColumnName("geo_coordinate_id");

                entity.Property(e => e.HouseNumber)
                    .HasColumnName("house_number")
                    .HasColumnType("character varying");

                entity.Property(e => e.PersonId).HasColumnName("person_id");

                entity.Property(e => e.PostCode).HasColumnName("post_code");

                entity.Property(e => e.RegionId).HasColumnName("region_id");

                entity.Property(e => e.Street).HasColumnName("street");

                entity.Property(e => e.Suburb).HasColumnName("suburb");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("timestamp with time zone");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Addresses)
                    .HasForeignKey(d => d.CountryId);

                entity.HasOne(d => d.GeoCoordinate)
                    .WithMany(p => p.Addresses)
                    .HasForeignKey(d => d.GeoCoordinateId);

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.Addresses)
                    .HasForeignKey(d => d.PersonId);
            });

            modelBuilder.Entity<AgentContracts>(entity =>
            {
                entity.ToTable("agent_contracts");

                entity.HasIndex(e => e.AgentContractedId);

                entity.HasIndex(e => e.Archived)
                    .HasName("index_agent_contracts_on_archived");

                entity.HasIndex(e => e.Backoffice);

                entity.HasIndex(e => e.BranchAssignedId);

                entity.HasIndex(e => e.ContractState);

                entity.HasIndex(e => e.CreatedAt);

                entity.HasIndex(e => e.DeviceId);

                entity.HasIndex(e => e.EmailAddressId);

                entity.HasIndex(e => e.GeoCoordinateId);

                entity.HasIndex(e => e.IsOwnAgent);

                entity.HasIndex(e => e.Location);

                entity.HasIndex(e => e.RegisteredPhoneNumberId);

                entity.HasIndex(e => e.SupervisorId);

                entity.HasIndex(e => e.UpdatedAt);

                entity.HasIndex(e => e.UserId);

                entity.HasIndex(e => new { e.ClientId, e.Code })
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AgentContractedId).HasColumnName("agent_contracted_id");

                entity.Property(e => e.Archived).HasColumnName("archived");

                entity.Property(e => e.Backoffice).HasColumnName("backoffice");

                entity.Property(e => e.BranchAssignedId).HasColumnName("branch_assigned_id");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.Code).HasColumnName("code");

                entity.Property(e => e.ContractState).HasColumnName("contract_state");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.DeviceId).HasColumnName("device_id");

                entity.Property(e => e.EmailAddressId).HasColumnName("email_address_id");

                entity.Property(e => e.GeoCoordinateId).HasColumnName("geo_coordinate_id");

                entity.Property(e => e.IsOwnAgent).HasColumnName("is_own_agent");

                entity.Property(e => e.Location).HasColumnName("location");

                entity.Property(e => e.Meta)
                    .HasColumnName("meta")
                    .HasColumnType("jsonb");

                entity.Property(e => e.RegisteredPhoneNumberId).HasColumnName("registered_phone_number_id");

                entity.Property(e => e.SupervisorId).HasColumnName("supervisor_id");

                entity.Property(e => e.Type).HasColumnName("type");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.AgentContracted)
                    .WithMany(p => p.AgentContracts)
                    .HasForeignKey(d => d.AgentContractedId);

                entity.HasOne(d => d.BranchAssigned)
                    .WithMany(p => p.AgentContracts)
                    .HasForeignKey(d => d.BranchAssignedId);

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.AgentContracts)
                    .HasForeignKey(d => d.ClientId);

                entity.HasOne(d => d.Device)
                    .WithMany(p => p.AgentContracts)
                    .HasForeignKey(d => d.DeviceId);

                entity.HasOne(d => d.EmailAddress)
                    .WithMany(p => p.AgentContracts)
                    .HasForeignKey(d => d.EmailAddressId);

                entity.HasOne(d => d.GeoCoordinate)
                    .WithMany(p => p.AgentContracts)
                    .HasForeignKey(d => d.GeoCoordinateId);

                entity.HasOne(d => d.RegisteredPhoneNumber)
                    .WithMany(p => p.AgentContracts)
                    .HasForeignKey(d => d.RegisteredPhoneNumberId);

                entity.HasOne(d => d.Supervisor)
                    .WithMany(p => p.AgentContracts)
                    .HasForeignKey(d => d.SupervisorId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AgentContracts)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<Agents>(entity =>
            {
                entity.ToTable("agents");

                entity.HasIndex(e => e.Active);

                entity.HasIndex(e => e.Archived);

                entity.HasIndex(e => e.CreatedAt);

                entity.HasIndex(e => e.IsSuperAgent)
                    .HasName("index_agents_on_is_super_agent");

                entity.HasIndex(e => e.PersonId);

                entity.HasIndex(e => e.RegisteredPhoneNumberId);

                entity.HasIndex(e => e.UpdatedAt);

                entity.HasIndex(e => new { e.SupplierId, e.Code })
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasColumnName("active")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.Archived).HasColumnName("archived");

                entity.Property(e => e.Code).HasColumnName("code");

                entity.Property(e => e.CollectionCentreId).HasColumnName("collection_centre_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.IsSuperAgent).HasColumnName("is_super_agent");

                entity.Property(e => e.PersonId).HasColumnName("person_id");

                entity.Property(e => e.RegisteredPhoneNumberId).HasColumnName("registered_phone_number_id");

                entity.Property(e => e.SupplierId).HasColumnName("supplier_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("timestamp with time zone");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.Agents)
                    .HasForeignKey(d => d.PersonId);

                entity.HasOne(d => d.RegisteredPhoneNumber)
                    .WithMany(p => p.Agents)
                    .HasForeignKey(d => d.RegisteredPhoneNumberId);

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.Agents)
                    .HasForeignKey(d => d.SupplierId);
            });

            modelBuilder.Entity<AgentServiceSubscriptions>(entity =>
            {
                entity.ToTable("agent_service_subscriptions");

                entity.HasIndex(e => e.AgentContractId);

                entity.HasIndex(e => e.AllowBankAccountTransactions);

                entity.HasIndex(e => e.AllowCardTransactions);

                entity.HasIndex(e => e.AllowCashTransactions);

                entity.HasIndex(e => e.AllowMobileMoneyTransactions);

                entity.HasIndex(e => e.ClientId);

                entity.HasIndex(e => e.ClientServiceSubscriptionId);

                entity.HasIndex(e => e.CreatedAt);

                entity.HasIndex(e => e.Enabled);

                entity.HasIndex(e => e.UpdatedAt);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AgentCommission)
                    .HasColumnName("agent_commission")
                    .HasColumnType("numeric(5,2)");

                entity.Property(e => e.AgentContractId).HasColumnName("agent_contract_id");

                entity.Property(e => e.AllowBankAccountTransactions).HasColumnName("allow_bank_account_transactions");

                entity.Property(e => e.AllowCardTransactions).HasColumnName("allow_card_transactions");

                entity.Property(e => e.AllowCashTransactions).HasColumnName("allow_cash_transactions");

                entity.Property(e => e.AllowMobileMoneyTransactions).HasColumnName("allow_mobile_money_transactions");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.ClientServiceSubscriptionId).HasColumnName("client_service_subscription_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.Enabled).HasColumnName("enabled");

                entity.Property(e => e.TransactionLimit)
                    .HasColumnName("transaction_limit")
                    .HasColumnType("numeric(5,2)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("timestamp with time zone");

                entity.HasOne(d => d.AgentContract)
                    .WithMany(p => p.AgentServiceSubscriptions)
                    .HasForeignKey(d => d.AgentContractId)
                    .HasConstraintName("FK_agent_service_subscriptions_agent_contracts_agent_contract_i");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.AgentServiceSubscriptions)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(d => d.ClientServiceSubscription)
                    .WithMany(p => p.AgentServiceSubscriptions)
                    .HasForeignKey(d => d.ClientServiceSubscriptionId)
                    .HasConstraintName("FK_agent_service_subscriptions_client_service_subscriptions_cli");
            });

            modelBuilder.Entity<Alias>(entity =>
            {
                entity.ToTable("alias");

                entity.HasIndex(e => e.ClientId);

                entity.HasIndex(e => e.CustomerId);

                entity.HasIndex(e => e.LoanAccountId);

                entity.HasIndex(e => e.OrganizationId);

                entity.HasIndex(e => e.SavingsAccountId);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.LoanAccountId).HasColumnName("loan_account_id");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.OrganizationId).HasColumnName("organization_id");

                entity.Property(e => e.SavingsAccountId).HasColumnName("savings_account_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("timestamp with time zone");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.Alias)
                    .HasForeignKey(d => d.ClientId);

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Alias)
                    .HasForeignKey(d => d.CustomerId);

                entity.HasOne(d => d.LoanAccount)
                    .WithMany(p => p.Alias)
                    .HasForeignKey(d => d.LoanAccountId);

                entity.HasOne(d => d.Organization)
                    .WithMany(p => p.Alias)
                    .HasForeignKey(d => d.OrganizationId);

                entity.HasOne(d => d.SavingsAccount)
                    .WithMany(p => p.Alias)
                    .HasForeignKey(d => d.SavingsAccountId);
            });

            modelBuilder.Entity<ApprovalLevels>(entity =>
            {
                entity.HasKey(e => new { e.FarmerId, e.UserId });

                entity.ToTable("approval_levels");

                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.FarmerId).HasColumnName("farmer_id");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("timestamp with time zone");

                entity.HasOne(d => d.Farmer)
                    .WithMany(p => p.ApprovalLevels)
                    .HasForeignKey(d => d.FarmerId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ApprovalLevels)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<ArInternalMetadata>(entity =>
            {
                entity.HasKey(e => e.Key);

                entity.ToTable("ar_internal_metadata");

                entity.Property(e => e.Key)
                    .HasColumnName("key")
                    .HasColumnType("character varying")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.Property(e => e.Value)
                    .HasColumnName("value")
                    .HasColumnType("character varying");
            });

            modelBuilder.Entity<AuditEntries>(entity =>
            {
                entity.HasKey(e => e.AuditEntryID);

                entity.ToTable("audit_entries");

                entity.Property(e => e.AuditEntryID)
                    .HasColumnName("audit_entry_i_d")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("character varying(255)");

                entity.Property(e => e.CreatedDate).HasColumnName("created_date");

                entity.Property(e => e.EntitySetName)
                    .HasColumnName("entity_set_name")
                    .HasColumnType("character varying(255)");

                entity.Property(e => e.EntityTypeName)
                    .HasColumnName("entity_type_name")
                    .HasColumnType("character varying(255)");

                entity.Property(e => e.State).HasColumnName("state");

                entity.Property(e => e.StateName)
                    .HasColumnName("state_name")
                    .HasColumnType("character varying(255)");
            });

            modelBuilder.Entity<AuditEntryProperties>(entity =>
            {
                entity.HasKey(e => e.AuditEntryPropertyID);

                entity.ToTable("audit_entry_properties");

                entity.HasIndex(e => e.AuditEntryID);

                entity.Property(e => e.AuditEntryPropertyID)
                    .HasColumnName("audit_entry_property_i_d")
                    .ValueGeneratedNever();

                entity.Property(e => e.AuditEntryID).HasColumnName("audit_entry_i_d");

                entity.Property(e => e.NewValue).HasColumnName("new_value");

                entity.Property(e => e.OldValue).HasColumnName("old_value");

                entity.Property(e => e.PropertyName)
                    .HasColumnName("property_name")
                    .HasColumnType("character varying(255)");

                entity.Property(e => e.RelationName)
                    .HasColumnName("relation_name")
                    .HasColumnType("character varying(255)");

                entity.HasOne(d => d.AuditEntry)
                    .WithMany(p => p.AuditEntryProperties)
                    .HasForeignKey(d => d.AuditEntryID);
            });

            modelBuilder.Entity<AuditLogs>(entity =>
            {
                entity.ToTable("audit_logs");

                entity.HasIndex(e => e.ClientId);

                entity.HasIndex(e => e.Current);

                entity.HasIndex(e => e.Title);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.Current).HasColumnName("current");

                entity.Property(e => e.Title).HasColumnName("title");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("timestamp with time zone");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.AuditLogs)
                    .HasForeignKey(d => d.ClientId);
            });

            modelBuilder.Entity<Backofficers>(entity =>
            {
                entity.ToTable("backofficers");

                entity.HasIndex(e => e.BranchId);

                entity.HasIndex(e => e.ClientId)
                    .HasName("index_backofficers_on_client_id");

                entity.HasIndex(e => e.ContactPhoneId);

                entity.HasIndex(e => e.CreatedAt);

                entity.HasIndex(e => e.EmailId);

                entity.HasIndex(e => e.GroupAssignedId);

                entity.HasIndex(e => e.PartnerId)
                    .HasName("index_backofficers_on_partner_id");

                entity.HasIndex(e => e.PersonId);

                entity.HasIndex(e => e.UpdatedAt);

                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.BranchId).HasColumnName("branch_id");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.ContactPhoneId).HasColumnName("contact_phone_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.EmailId).HasColumnName("email_id");

                entity.Property(e => e.GroupAssignedId).HasColumnName("group_assigned_id");

                entity.Property(e => e.Meta)
                    .HasColumnName("meta")
                    .HasColumnType("jsonb");

                entity.Property(e => e.PartnerId).HasColumnName("partner_id");

                entity.Property(e => e.PersonId).HasColumnName("person_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.Backofficers)
                    .HasForeignKey(d => d.BranchId);

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.Backofficers)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(d => d.ContactPhone)
                    .WithMany(p => p.Backofficers)
                    .HasForeignKey(d => d.ContactPhoneId);

                entity.HasOne(d => d.Email)
                    .WithMany(p => p.Backofficers)
                    .HasForeignKey(d => d.EmailId);

                entity.HasOne(d => d.GroupAssigned)
                    .WithMany(p => p.Backofficers)
                    .HasForeignKey(d => d.GroupAssignedId);

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.Backofficers)
                    .HasForeignKey(d => d.PersonId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Backofficers)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<BankCards>(entity =>
            {
                entity.ToTable("bank_cards");

                entity.HasIndex(e => e.CardOwnerId);

                entity.HasIndex(e => e.CardType);

                entity.HasIndex(e => e.CreatedAt);

                entity.HasIndex(e => e.Issuer);

                entity.HasIndex(e => e.LinkedAccountId);

                entity.HasIndex(e => e.PAN);

                entity.HasIndex(e => e.UpdatedAt);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CardOwnerId).HasColumnName("card_owner_id");

                entity.Property(e => e.CardType).HasColumnName("card_type");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.Issuer).HasColumnName("issuer");

                entity.Property(e => e.LinkedAccountId).HasColumnName("linked_account_id");

                entity.Property(e => e.PAN).HasColumnName("p_a_n");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("timestamp with time zone");

                entity.HasOne(d => d.CardOwner)
                    .WithMany(p => p.BankCards)
                    .HasForeignKey(d => d.CardOwnerId);

                entity.HasOne(d => d.LinkedAccount)
                    .WithMany(p => p.BankCards)
                    .HasForeignKey(d => d.LinkedAccountId);
            });

            modelBuilder.Entity<Banks>(entity =>
            {
                entity.ToTable("banks");

                entity.HasIndex(e => e.RegionId);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BranchName).HasColumnName("branch_name");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.RegionId).HasColumnName("region_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("timestamp with time zone");

                entity.HasOne(d => d.Region)
                    .WithMany(p => p.Banks)
                    .HasForeignKey(d => d.RegionId);
            });

            modelBuilder.Entity<Beneficiaries>(entity =>
            {
                entity.ToTable("beneficiaries");

                entity.HasIndex(e => e.ClientId);

                entity.HasIndex(e => e.PersonId);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.PersonId).HasColumnName("person_id");

                entity.Property(e => e.Relation).HasColumnName("relation");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("timestamp with time zone");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.Beneficiaries)
                    .HasForeignKey(d => d.ClientId);

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.Beneficiaries)
                    .HasForeignKey(d => d.PersonId);
            });

            modelBuilder.Entity<BranchConfigurations>(entity =>
            {
                entity.ToTable("branch_configurations");

                entity.HasIndex(e => e.BranchId)
                    .IsUnique();

                entity.HasIndex(e => e.SettlementAccountId);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BranchId).HasColumnName("branch_id");

                entity.Property(e => e.CanAssignAgents).HasColumnName("can_assign_agents");

                entity.Property(e => e.CanAssignBackofficers).HasColumnName("can_assign_backofficers");

                entity.Property(e => e.CanAssignCustomers).HasColumnName("can_assign_customers");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.SettlementAccountId).HasColumnName("settlement_account_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("timestamp with time zone");

                entity.HasOne(d => d.Branch)
                    .WithOne(p => p.BranchConfigurations)
                    .HasForeignKey<BranchConfigurations>(d => d.BranchId);

                entity.HasOne(d => d.SettlementAccount)
                    .WithMany(p => p.BranchConfigurations)
                    .HasForeignKey(d => d.SettlementAccountId);
            });

            modelBuilder.Entity<Branches>(entity =>
            {
                entity.ToTable("branches");

                entity.HasIndex(e => e.Active);

                entity.HasIndex(e => e.CreatedAt);

                entity.HasIndex(e => e.IsHeadOffice);

                entity.HasIndex(e => e.IsSubBranch);

                entity.HasIndex(e => e.Name);

                entity.HasIndex(e => e.ParentBranchId);

                entity.HasIndex(e => e.UpdatedAt);

                entity.HasIndex(e => new { e.ClientId, e.BranchCode })
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasColumnName("active")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.BranchCode).HasColumnName("branch_code");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.IsHeadOffice).HasColumnName("is_head_office");

                entity.Property(e => e.IsSubBranch).HasColumnName("is_sub_branch");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.ParentBranchId).HasColumnName("parent_branch_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("timestamp with time zone");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.Branches)
                    .HasForeignKey(d => d.ClientId);

                entity.HasOne(d => d.ParentBranch)
                    .WithMany(p => p.InverseParentBranch)
                    .HasForeignKey(d => d.ParentBranchId);
            });

            modelBuilder.Entity<Centre>(entity =>
            {
                entity.ToTable("centre");

                entity.HasIndex(e => e.AssignedToBranchId);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.AssignedToBranchId).HasColumnName("assigned_to_branch_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("timestamp with time zone");

                entity.HasOne(d => d.AssignedToBranch)
                    .WithMany(p => p.Centre)
                    .HasForeignKey(d => d.AssignedToBranchId);
            });

            modelBuilder.Entity<ClientConfigurations>(entity =>
            {
                entity.ToTable("client_configurations");

                entity.HasIndex(e => e.AutoReconcile);

                entity.HasIndex(e => e.BillingEnabled);

                entity.HasIndex(e => e.ClientId)
                    .IsUnique();

                entity.HasIndex(e => e.ControlAccountId);

                entity.HasIndex(e => e.CreatedAt);

                entity.HasIndex(e => e.SettlementAccountId);

                entity.HasIndex(e => e.StoreAccounts)
                    .HasName("index_clients_on_stores_accts");

                entity.HasIndex(e => e.UpdatedAt);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AccountNumberFormat).HasColumnName("account_number_format");

                entity.Property(e => e.AutoReconcile).HasColumnName("auto_reconcile");

                entity.Property(e => e.BillingEnabled).HasColumnName("billing_enabled");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.ControlAccountId).HasColumnName("control_account_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.SettlementAccountId).HasColumnName("settlement_account_id");

                entity.Property(e => e.StoreAccounts).HasColumnName("store_accounts");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("timestamp with time zone");

                entity.HasOne(d => d.Client)
                    .WithOne(p => p.ClientConfigurations)
                    .HasForeignKey<ClientConfigurations>(d => d.ClientId);

                entity.HasOne(d => d.ControlAccount)
                    .WithMany(p => p.ClientConfigurationsControlAccount)
                    .HasForeignKey(d => d.ControlAccountId);

                entity.HasOne(d => d.SettlementAccount)
                    .WithMany(p => p.ClientConfigurationsSettlementAccount)
                    .HasForeignKey(d => d.SettlementAccountId);
            });

            modelBuilder.Entity<ClientPartnerships>(entity =>
            {
                entity.HasKey(e => new { e.ClientId, e.PartnerId });

                entity.ToTable("client_partnerships");

                entity.HasIndex(e => e.PartnerId);

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.PartnerId).HasColumnName("partner_id");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.ClientPartnerships)
                    .HasForeignKey(d => d.ClientId);

                entity.HasOne(d => d.Partner)
                    .WithMany(p => p.ClientPartnerships)
                    .HasForeignKey(d => d.PartnerId);
            });

            modelBuilder.Entity<ClientProductSubscriptions>(entity =>
            {
                entity.ToTable("client_product_subscriptions");

                entity.HasIndex(e => e.ClientId);

                entity.HasIndex(e => e.ProductId);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("timestamp with time zone");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.ClientProductSubscriptions)
                    .HasForeignKey(d => d.ClientId);

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ClientProductSubscriptions)
                    .HasForeignKey(d => d.ProductId);
            });

            modelBuilder.Entity<Clients>(entity =>
            {
                entity.ToTable("clients");

                entity.HasIndex(e => e.AccountState);

                entity.HasIndex(e => e.Code)
                    .HasName("index_clients_on_code")
                    .IsUnique();

                entity.HasIndex(e => e.CountryId);

                entity.HasIndex(e => e.CreatedAt);

                entity.HasIndex(e => e.CurrencyId);

                entity.HasIndex(e => e.IconId);

                entity.HasIndex(e => e.IsBankingClient);

                entity.HasIndex(e => e.IsInsuranceClient);

                entity.HasIndex(e => e.IsMerchantClient);

                entity.HasIndex(e => e.IsRevenueCollectionClient);

                entity.HasIndex(e => e.LanguageId);

                entity.HasIndex(e => e.LogoId);

                entity.HasIndex(e => e.Name);

                entity.HasIndex(e => e.OrganizationId);

                entity.HasIndex(e => e.ShortName);

                entity.HasIndex(e => e.UpdatedAt);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AccountState).HasColumnName("account_state");

                entity.Property(e => e.Code).HasColumnName("code");

                entity.Property(e => e.CountryId).HasColumnName("country_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.CurrencyId).HasColumnName("currency_id");

                entity.Property(e => e.Domain).HasColumnName("domain");

                entity.Property(e => e.IconId).HasColumnName("icon_id");

                entity.Property(e => e.IsBankingClient)
                    .IsRequired()
                    .HasColumnName("is_banking_client")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.IsInsuranceClient).HasColumnName("is_insurance_client");

                entity.Property(e => e.IsMerchantClient).HasColumnName("is_merchant_client");

                entity.Property(e => e.IsRevenueCollectionClient).HasColumnName("is_revenue_collection_client");

                entity.Property(e => e.LanguageId).HasColumnName("language_id");

                entity.Property(e => e.LogoId).HasColumnName("logo_id");

                entity.Property(e => e.Meta)
                    .HasColumnName("meta")
                    .HasColumnType("jsonb");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("character varying(300)");

                entity.Property(e => e.OrganizationId).HasColumnName("organization_id");

                entity.Property(e => e.ShortName).HasColumnName("short_name");

                entity.Property(e => e.SuperClientId).HasColumnName("super_client_id");

                entity.Property(e => e.TagLine).HasColumnName("tag_line");

                entity.Property(e => e.TillNumber).HasColumnName("till_number");

                entity.Property(e => e.Timezone).HasColumnName("timezone");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("timestamp with time zone");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Clients)
                    .HasForeignKey(d => d.CountryId);

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.Clients)
                    .HasForeignKey(d => d.CurrencyId);

                entity.HasOne(d => d.Icon)
                    .WithMany(p => p.ClientsIcon)
                    .HasForeignKey(d => d.IconId);

                entity.HasOne(d => d.Language)
                    .WithMany(p => p.Clients)
                    .HasForeignKey(d => d.LanguageId);

                entity.HasOne(d => d.Logo)
                    .WithMany(p => p.ClientsLogo)
                    .HasForeignKey(d => d.LogoId);

                entity.HasOne(d => d.Organization)
                    .WithMany(p => p.Clients)
                    .HasForeignKey(d => d.OrganizationId);
            });

            modelBuilder.Entity<ClientServiceSubscriptions>(entity =>
            {
                entity.ToTable("client_service_subscriptions");

                entity.HasIndex(e => e.AllowBankAccountTransactions);

                entity.HasIndex(e => e.AllowCardTransactions);

                entity.HasIndex(e => e.AllowCashTransactions);

                entity.HasIndex(e => e.AllowMobileMoneyTransactions);

                entity.HasIndex(e => e.ClientId);

                entity.HasIndex(e => e.Code);

                entity.HasIndex(e => e.CreatedAt);

                entity.HasIndex(e => e.ElectronicValueAccountId);

                entity.HasIndex(e => e.ServiceId);

                entity.HasIndex(e => e.ServiceProviderAccountId);

                entity.HasIndex(e => e.ServiceProviderId);

                entity.HasIndex(e => e.SettlementAccountId);

                entity.HasIndex(e => e.UpdatedAt);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AllowBankAccountTransactions).HasColumnName("allow_bank_account_transactions");

                entity.Property(e => e.AllowCardTransactions).HasColumnName("allow_card_transactions");

                entity.Property(e => e.AllowCashTransactions).HasColumnName("allow_cash_transactions");

                entity.Property(e => e.AllowMobileMoneyTransactions).HasColumnName("allow_mobile_money_transactions");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.Code).HasColumnName("code");

                entity.Property(e => e.Commission)
                    .HasColumnName("commission")
                    .HasColumnType("numeric(5,2)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.DefaultAgentCommission)
                    .HasColumnName("default_agent_commission")
                    .HasColumnType("numeric(5,2)")
                    .HasDefaultValueSql("0.0");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.ElectronicValueAccountId).HasColumnName("electronic_value_account_id");

                entity.Property(e => e.Fee)
                    .HasColumnName("fee")
                    .HasColumnType("numeric(5,2)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ServiceId).HasColumnName("service_id");

                entity.Property(e => e.ServiceProviderAccountId).HasColumnName("service_provider_account_id");

                entity.Property(e => e.ServiceProviderId).HasColumnName("service_provider_id");

                entity.Property(e => e.SettlementAccountId).HasColumnName("settlement_account_id");

                entity.Property(e => e.TransactionLimit)
                    .HasColumnName("transaction_limit")
                    .HasColumnType("numeric(5,2)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TransactionReceiptTemplate).HasColumnName("transaction_receipt_template");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("timestamp with time zone");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.ClientServiceSubscriptions)
                    .HasForeignKey(d => d.ClientId);

                entity.HasOne(d => d.ElectronicValueAccount)
                    .WithMany(p => p.ClientServiceSubscriptionsElectronicValueAccount)
                    .HasForeignKey(d => d.ElectronicValueAccountId)
                    .HasConstraintName("FK_client_service_subscriptions_savings_accounts_electronic_val");

                entity.HasOne(d => d.Service)
                    .WithMany(p => p.ClientServiceSubscriptions)
                    .HasForeignKey(d => d.ServiceId);

                entity.HasOne(d => d.ServiceProviderAccount)
                    .WithMany(p => p.ClientServiceSubscriptionsServiceProviderAccount)
                    .HasForeignKey(d => d.ServiceProviderAccountId)
                    .HasConstraintName("FK_client_service_subscriptions_savings_accounts_service_provid");

                entity.HasOne(d => d.ServiceProvider)
                    .WithMany(p => p.ClientServiceSubscriptions)
                    .HasForeignKey(d => d.ServiceProviderId)
                    .HasConstraintName("FK_client_service_subscriptions_service_providers_service_provi");

                entity.HasOne(d => d.SettlementAccount)
                    .WithMany(p => p.ClientServiceSubscriptionsSettlementAccount)
                    .HasForeignKey(d => d.SettlementAccountId)
                    .HasConstraintName("FK_client_service_subscriptions_savings_accounts_settlement_acc");
            });

            modelBuilder.Entity<CollectionCentres>(entity =>
            {
                entity.ToTable("collection_centres");

                entity.HasIndex(e => e.RegionId)
                    .HasName("index_collection_centres_on_region_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Centre)
                    .HasColumnName("centre")
                    .HasColumnType("character varying");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.IsArchived)
                    .HasColumnName("is_archived")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.RegionId).HasColumnName("region_id");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
            });

            modelBuilder.Entity<Contacts>(entity =>
            {
                entity.ToTable("contacts");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("nextval('contact_detail_id_seq'::regclass)");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("timestamp with time zone");
            });

            modelBuilder.Entity<Countries>(entity =>
            {
                entity.ToTable("countries");

                entity.HasIndex(e => e.Alpha2Code);

                entity.HasIndex(e => e.Alpha3Code);

                entity.HasIndex(e => e.Demonym);

                entity.HasIndex(e => e.GeoCoordinatesId);

                entity.HasIndex(e => e.Name);

                entity.HasIndex(e => e.NativeName);

                entity.HasIndex(e => e.NumericCode);

                entity.HasIndex(e => e.Region);

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Alpha2Code).HasColumnName("alpha2_code");

                entity.Property(e => e.Alpha3Code).HasColumnName("alpha3_code");

                entity.Property(e => e.AlternateSpellings).HasColumnName("alternate_spellings");

                entity.Property(e => e.Area).HasColumnName("area");

                entity.Property(e => e.Borders).HasColumnName("borders");

                entity.Property(e => e.CallingCodes).HasColumnName("calling_codes");

                entity.Property(e => e.Capital).HasColumnName("capital");

                entity.Property(e => e.Cioc).HasColumnName("cioc");

                entity.Property(e => e.Demonym).HasColumnName("demonym");

                entity.Property(e => e.Flag).HasColumnName("flag");

                entity.Property(e => e.GeoCoordinatesId).HasColumnName("geo_coordinates_id");

                entity.Property(e => e.Gini).HasColumnName("gini");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("character varying(200)");

                entity.Property(e => e.NativeName).HasColumnName("native_name");

                entity.Property(e => e.NumericCode).HasColumnName("numeric_code");

                entity.Property(e => e.Population).HasColumnName("population");

                entity.Property(e => e.Region).HasColumnName("region");

                entity.Property(e => e.Subregion).HasColumnName("subregion");

                entity.Property(e => e.Timezones).HasColumnName("timezones");

                entity.Property(e => e.TopLevelDomain).HasColumnName("top_level_domain");

                entity.HasOne(d => d.GeoCoordinates)
                    .WithMany(p => p.Countries)
                    .HasForeignKey(d => d.GeoCoordinatesId);
            });

            modelBuilder.Entity<Currencies>(entity =>
            {
                entity.ToTable("currencies");

                entity.HasIndex(e => e.CountryId);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Code).HasColumnName("code");

                entity.Property(e => e.CountryId).HasColumnName("country_id");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.Symbol).HasColumnName("symbol");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Currencies)
                    .HasForeignKey(d => d.CountryId);
            });

            modelBuilder.Entity<CustomerQuestions>(entity =>
            {
                entity.ToTable("customer_questions");

                entity.HasIndex(e => e.QuestionId);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.FieldName).HasColumnName("field_name");

                entity.Property(e => e.InsertedAt).HasColumnName("inserted_at");

                entity.Property(e => e.QuestionId).HasColumnName("question_id");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.HasOne(d => d.Question)
                    .WithMany(p => p.CustomerQuestions)
                    .HasForeignKey(d => d.QuestionId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("customer_questions_question_id_fkey");
            });

            modelBuilder.Entity<Customers>(entity =>
            {
                entity.ToTable("customers");

                entity.HasIndex(e => e.ActivatedDate);

                entity.HasIndex(e => e.Active);

                entity.HasIndex(e => e.AgentAssignedId);

                entity.HasIndex(e => e.ApprovedDate);

                entity.HasIndex(e => e.BranchId);

                entity.HasIndex(e => e.ClientId);

                entity.HasIndex(e => e.ClosedDate);

                entity.HasIndex(e => e.CreatedAt);

                entity.HasIndex(e => e.GroupId);

                entity.HasIndex(e => e.IsCorporate);

                entity.HasIndex(e => e.IsGroup);

                entity.HasIndex(e => e.IsIndividual);

                entity.HasIndex(e => e.Number);

                entity.HasIndex(e => e.OrganizationId);

                entity.HasIndex(e => e.PersonId);

                entity.HasIndex(e => e.ProfilePictureId);

                entity.HasIndex(e => e.RelationshipOfficerId);

                entity.HasIndex(e => e.SignatureId);

                entity.HasIndex(e => e.Status)
                    .HasName("index_customer_on_status");

                entity.HasIndex(e => e.UpdatedAt);

                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ActivatedDate)
                    .HasColumnName("activated_date")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasColumnName("active")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.AgentAssignedId).HasColumnName("agent_assigned_id");

                entity.Property(e => e.ApprovedDate)
                    .HasColumnName("approved_date")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.Bbid).HasColumnName("bbid");

                entity.Property(e => e.BranchId).HasColumnName("branch_id");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.ClosedDate)
                    .HasColumnName("closed_date")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.GroupId).HasColumnName("group_id");

                entity.Property(e => e.IsCorporate).HasColumnName("is_corporate");

                entity.Property(e => e.IsGroup).HasColumnName("is_group");

                entity.Property(e => e.IsIndividual)
                    .IsRequired()
                    .HasColumnName("is_individual")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.Meta)
                    .HasColumnName("meta")
                    .HasColumnType("jsonb");

                entity.Property(e => e.Number).HasColumnName("number");

                entity.Property(e => e.OrganizationId).HasColumnName("organization_id");

                entity.Property(e => e.PersonId).HasColumnName("person_id");

                entity.Property(e => e.ProfilePictureId).HasColumnName("profile_picture_id");

                entity.Property(e => e.RelationshipOfficerId).HasColumnName("relationship_officer_id");

                entity.Property(e => e.SelfServiceEnabled).HasColumnName("self_service_enabled");

                entity.Property(e => e.SignatureId).HasColumnName("signature_id");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.AgentAssigned)
                    .WithMany(p => p.Customers)
                    .HasForeignKey(d => d.AgentAssignedId);

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.Customers)
                    .HasForeignKey(d => d.BranchId);

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.Customers)
                    .HasForeignKey(d => d.ClientId);

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.Customers)
                    .HasForeignKey(d => d.GroupId);

                entity.HasOne(d => d.Organization)
                    .WithMany(p => p.Customers)
                    .HasForeignKey(d => d.OrganizationId);

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.Customers)
                    .HasForeignKey(d => d.PersonId);

                entity.HasOne(d => d.ProfilePicture)
                    .WithMany(p => p.CustomersProfilePicture)
                    .HasForeignKey(d => d.ProfilePictureId);

                entity.HasOne(d => d.RelationshipOfficer)
                    .WithMany(p => p.Customers)
                    .HasForeignKey(d => d.RelationshipOfficerId);

                entity.HasOne(d => d.Signature)
                    .WithMany(p => p.CustomersSignature)
                    .HasForeignKey(d => d.SignatureId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Customers)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<Customization>(entity =>
            {
                entity.ToTable("customization");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Identifier).HasColumnName("identifier");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
            });

            modelBuilder.Entity<DependentQuestions>(entity =>
            {
                entity.ToTable("dependent_questions");

                entity.HasIndex(e => e.DependentQuestionId);

                entity.HasIndex(e => e.QuestionId);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Answer).HasColumnName("answer");

                entity.Property(e => e.AnswerType).HasColumnName("answer_type");

                entity.Property(e => e.DependentQuestionId).HasColumnName("dependent_question_id");

                entity.Property(e => e.QuestionId).HasColumnName("question_id");

                entity.HasOne(d => d.DependentQuestion)
                    .WithMany(p => p.DependentQuestionsDependentQuestion)
                    .HasForeignKey(d => d.DependentQuestionId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("dependent_questions_dependent_question_id_fkey");

                entity.HasOne(d => d.Question)
                    .WithMany(p => p.DependentQuestionsQuestion)
                    .HasForeignKey(d => d.QuestionId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("dependent_questions_question_id_fkey");
            });

            modelBuilder.Entity<DependentSections>(entity =>
            {
                entity.ToTable("dependent_sections");

                entity.HasIndex(e => e.DependentSectionId);

                entity.HasIndex(e => e.QuestionId);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Answer).HasColumnName("answer");

                entity.Property(e => e.AnswerType).HasColumnName("answer_type");

                entity.Property(e => e.DependentSectionId).HasColumnName("dependent_section_id");

                entity.Property(e => e.QuestionId).HasColumnName("question_id");

                entity.HasOne(d => d.DependentSection)
                    .WithMany(p => p.DependentSections)
                    .HasForeignKey(d => d.DependentSectionId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("dependent_sections_dependent_section_id_fkey");

                entity.HasOne(d => d.Question)
                    .WithMany(p => p.DependentSections)
                    .HasForeignKey(d => d.QuestionId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("dependent_sections_question_id_fkey");
            });

            modelBuilder.Entity<DeviceAssignments>(entity =>
            {
                entity.ToTable("device_assignments");

                entity.HasIndex(e => e.AgentContractId);

                entity.HasIndex(e => e.ClientId);

                entity.HasIndex(e => e.DeviceId);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AgentContractId).HasColumnName("agent_contract_id");

                entity.Property(e => e.AssignedFrom)
                    .HasColumnName("assigned_from")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.AssignedTo)
                    .HasColumnName("assigned_to")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.DeviceId).HasColumnName("device_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("timestamp with time zone");

                entity.HasOne(d => d.AgentContract)
                    .WithMany(p => p.DeviceAssignments)
                    .HasForeignKey(d => d.AgentContractId);

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.DeviceAssignments)
                    .HasForeignKey(d => d.ClientId);

                entity.HasOne(d => d.Device)
                    .WithMany(p => p.DeviceAssignments)
                    .HasForeignKey(d => d.DeviceId);
            });

            modelBuilder.Entity<Devices>(entity =>
            {
                entity.ToTable("devices");

                entity.HasIndex(e => e.AgentAssignedId);

                entity.HasIndex(e => e.ApiVersion);

                entity.HasIndex(e => e.AppVersion);

                entity.HasIndex(e => e.ClientId);

                entity.HasIndex(e => e.CreatedAt);

                entity.HasIndex(e => e.Imei);

                entity.HasIndex(e => e.Imsi);

                entity.HasIndex(e => e.IsDeviceLocked);

                entity.HasIndex(e => e.LastActivity);

                entity.HasIndex(e => e.LastKnownLocationId);

                entity.HasIndex(e => e.LastLogin);

                entity.HasIndex(e => e.TerminalId);

                entity.HasIndex(e => e.UpdatedAt);

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AgentAssignedId).HasColumnName("agent_assigned_id");

                entity.Property(e => e.ApiVersion).HasColumnName("api_version");

                entity.Property(e => e.AppVersion).HasColumnName("app_version");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.Imei).HasColumnName("imei");

                entity.Property(e => e.Imsi).HasColumnName("imsi");

                entity.Property(e => e.IsDeviceLocked).HasColumnName("is_device_locked");

                entity.Property(e => e.LastActivity)
                    .HasColumnName("last_activity")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.LastKnownLocationId).HasColumnName("last_known_location_id");

                entity.Property(e => e.LastLogin)
                    .HasColumnName("last_login")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.Make).HasColumnName("make");

                entity.Property(e => e.Model).HasColumnName("model");

                entity.Property(e => e.TerminalId).HasColumnName("terminal_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("timestamp with time zone");

                entity.HasOne(d => d.AgentAssigned)
                    .WithMany(p => p.Devices)
                    .HasForeignKey(d => d.AgentAssignedId);

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.Devices)
                    .HasForeignKey(d => d.ClientId);

                entity.HasOne(d => d.LastKnownLocation)
                    .WithMany(p => p.Devices)
                    .HasForeignKey(d => d.LastKnownLocationId);
            });

            modelBuilder.Entity<Documents>(entity =>
            {
                entity.ToTable("documents");

                entity.HasIndex(e => e.ClientId);

                entity.HasIndex(e => e.CreatedById);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.CreatedById).HasColumnName("created_by_id");

                entity.Property(e => e.DocumentType).HasColumnName("document_type");

                entity.Property(e => e.FileName).HasColumnName("file_name");

                entity.Property(e => e.FileType).HasColumnName("file_type");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("timestamp with time zone");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.Documents)
                    .HasForeignKey(d => d.ClientId);

                entity.HasOne(d => d.CreatedBy)
                    .WithMany(p => p.Documents)
                    .HasForeignKey(d => d.CreatedById);
            });

            modelBuilder.Entity<DonationProjectAssignments>(entity =>
            {
                entity.ToTable("donation_project_assignments");

                entity.HasIndex(e => e.AgentOnDutyId);

                entity.HasIndex(e => e.ClientId);

                entity.HasIndex(e => e.DonationProjectId);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AgentOnDutyId).HasColumnName("agent_on_duty_id");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.DonationProjectId).HasColumnName("donation_project_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("timestamp with time zone");

                entity.HasOne(d => d.AgentOnDuty)
                    .WithMany(p => p.DonationProjectAssignments)
                    .HasForeignKey(d => d.AgentOnDutyId)
                    .HasConstraintName("FK_donation_project_assignments_agent_contracts_agent_on_duty_i");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.DonationProjectAssignments)
                    .HasForeignKey(d => d.ClientId);

                entity.HasOne(d => d.DonationProject)
                    .WithMany(p => p.DonationProjectAssignments)
                    .HasForeignKey(d => d.DonationProjectId)
                    .HasConstraintName("FK_donation_project_assignments_donation_projects_donation_proj");
            });

            modelBuilder.Entity<DonationProjects>(entity =>
            {
                entity.ToTable("donation_projects");

                entity.HasIndex(e => e.ClientId);

                entity.HasIndex(e => e.CustomerId);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AccountNumber).HasColumnName("account_number");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.ReceiptImageContentType).HasColumnName("receipt_image_content_type");

                entity.Property(e => e.ReceiptImageFileName).HasColumnName("receipt_image_file_name");

                entity.Property(e => e.ReceiptImageFileSize).HasColumnName("receipt_image_file_size");

                entity.Property(e => e.ReceiptImageUpdatedAt).HasColumnName("receipt_image_updated_at");

                entity.Property(e => e.ReceiptTemplate).HasColumnName("receipt_template");

                entity.Property(e => e.Title).HasColumnName("title");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("timestamp with time zone");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.DonationProjects)
                    .HasForeignKey(d => d.ClientId);

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.DonationProjects)
                    .HasForeignKey(d => d.CustomerId);
            });

            modelBuilder.Entity<Donors>(entity =>
            {
                entity.ToTable("donors");

                entity.HasIndex(e => e.DonationId);

                entity.HasIndex(e => e.PersonId);

                entity.HasIndex(e => e.PhoneNumberId);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.DonationId).HasColumnName("donation_id");

                entity.Property(e => e.PersonId).HasColumnName("person_id");

                entity.Property(e => e.PhoneNumberId).HasColumnName("phone_number_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("timestamp with time zone");

                entity.HasOne(d => d.Donation)
                    .WithMany(p => p.Donors)
                    .HasForeignKey(d => d.DonationId);

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.Donors)
                    .HasForeignKey(d => d.PersonId);

                entity.HasOne(d => d.PhoneNumber)
                    .WithMany(p => p.Donors)
                    .HasForeignKey(d => d.PhoneNumberId);
            });

            modelBuilder.Entity<EconomicDetails>(entity =>
            {
                entity.ToTable("economic_details");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.EmploymentStatus).HasColumnName("employment_status");

                entity.Property(e => e.EmploymentType).HasColumnName("employment_type");

                entity.Property(e => e.NetMonthlyIncome).HasColumnName("net_monthly_income");
            });

            modelBuilder.Entity<EfMigrationsHistory>(entity =>
            {
                entity.HasKey(e => e.MigrationId);

                entity.ToTable("_ef_migrations_history");

                entity.Property(e => e.MigrationId)
                    .HasColumnType("character varying(150)")
                    .ValueGeneratedNever();

                entity.Property(e => e.ProductVersion)
                    .IsRequired()
                    .HasColumnType("character varying(32)");
            });

            modelBuilder.Entity<EmailAddresses>(entity =>
            {
                entity.ToTable("email_addresses");

                entity.HasIndex(e => e.Active);

                entity.HasIndex(e => e.Address)
                    .HasName("index_email_addresses_on_address")
                    .IsUnique();

                entity.HasIndex(e => e.ContactDetailId);

                entity.HasIndex(e => e.CreatedAt);

                entity.HasIndex(e => e.Primary);

                entity.HasIndex(e => e.UpdatedAt);

                entity.HasIndex(e => e.Verified);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasColumnName("active")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasColumnName("address")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.ContactDetailId).HasColumnName("contact_detail_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Primary)
                    .HasColumnName("primary")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.Verified).HasColumnName("verified");

                entity.HasOne(d => d.ContactDetail)
                    .WithMany(p => p.EmailAddresses)
                    .HasForeignKey(d => d.ContactDetailId);
            });

            modelBuilder.Entity<EmploymentDetails>(entity =>
            {
                entity.ToTable("employment_details");

                entity.HasIndex(e => e.EmployerId);

                entity.HasIndex(e => e.OfficePhoneId);

                entity.HasIndex(e => e.PersonId);

                entity.HasIndex(e => e.WorkEmailId);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.EmployerId).HasColumnName("employer_id");

                entity.Property(e => e.EndDate)
                    .HasColumnName("end_date")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.IsCurrent)
                    .IsRequired()
                    .HasColumnName("is_current")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.Occupation).HasColumnName("occupation");

                entity.Property(e => e.OfficePhoneId).HasColumnName("office_phone_id");

                entity.Property(e => e.PersonId).HasColumnName("person_id");

                entity.Property(e => e.Position).HasColumnName("position");

                entity.Property(e => e.StartDate)
                    .HasColumnName("start_date")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.WorkEmailId).HasColumnName("work_email_id");

                entity.HasOne(d => d.Employer)
                    .WithMany(p => p.EmploymentDetails)
                    .HasForeignKey(d => d.EmployerId);

                entity.HasOne(d => d.OfficePhone)
                    .WithMany(p => p.EmploymentDetails)
                    .HasForeignKey(d => d.OfficePhoneId);

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.EmploymentDetails)
                    .HasForeignKey(d => d.PersonId);

                entity.HasOne(d => d.WorkEmail)
                    .WithMany(p => p.EmploymentDetails)
                    .HasForeignKey(d => d.WorkEmailId);
            });

            modelBuilder.Entity<Endorsements>(entity =>
            {
                entity.ToTable("endorsements");

                entity.HasIndex(e => e.CommentId);

                entity.HasIndex(e => e.CustomerId);

                entity.HasIndex(e => e.EndorsementPhotoId);

                entity.HasIndex(e => e.TransactionDetailId);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CommentId).HasColumnName("comment_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.EndorsementPhotoId).HasColumnName("endorsement_photo_id");

                entity.Property(e => e.TransactionDetailId).HasColumnName("transaction_detail_id");

                entity.Property(e => e.TransactionId).HasColumnName("transaction_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("timestamp with time zone");

                entity.HasOne(d => d.Comment)
                    .WithMany(p => p.Endorsements)
                    .HasForeignKey(d => d.CommentId);

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Endorsements)
                    .HasForeignKey(d => d.CustomerId);

                entity.HasOne(d => d.EndorsementPhoto)
                    .WithMany(p => p.Endorsements)
                    .HasForeignKey(d => d.EndorsementPhotoId);

                entity.HasOne(d => d.TransactionDetail)
                    .WithMany(p => p.Endorsements)
                    .HasForeignKey(d => d.TransactionDetailId);
            });

            modelBuilder.Entity<ExchangeRates>(entity =>
            {
                entity.ToTable("exchange_rates");

                entity.HasIndex(e => e.FromCurrencyId);

                entity.HasIndex(e => e.SourceId);

                entity.HasIndex(e => e.ToCurrencyId);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BuyRate).HasColumnName("buy_rate");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.FromCurrencyId).HasColumnName("from_currency_id");

                entity.Property(e => e.SellRate).HasColumnName("sell_rate");

                entity.Property(e => e.SourceId).HasColumnName("source_id");

                entity.Property(e => e.ToCurrencyId).HasColumnName("to_currency_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.ValidFrom)
                    .HasColumnName("valid_from")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.ValidTo)
                    .HasColumnName("valid_to")
                    .HasColumnType("timestamp with time zone");

                entity.HasOne(d => d.FromCurrency)
                    .WithMany(p => p.ExchangeRatesFromCurrency)
                    .HasForeignKey(d => d.FromCurrencyId);

                entity.HasOne(d => d.Source)
                    .WithMany(p => p.ExchangeRates)
                    .HasForeignKey(d => d.SourceId);

                entity.HasOne(d => d.ToCurrency)
                    .WithMany(p => p.ExchangeRatesToCurrency)
                    .HasForeignKey(d => d.ToCurrencyId);
            });

            modelBuilder.Entity<ExternalLinks>(entity =>
            {
                entity.ToTable("external_links");

                entity.HasIndex(e => e.ClientId);

                entity.HasIndex(e => e.CustomerId);

                entity.HasIndex(e => e.GroupId);

                entity.HasIndex(e => e.IconId);

                entity.HasIndex(e => e.OrganizationId);

                entity.HasIndex(e => e.PersonId);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.Destination).HasColumnName("destination");

                entity.Property(e => e.GroupId).HasColumnName("group_id");

                entity.Property(e => e.IconId).HasColumnName("icon_id");

                entity.Property(e => e.OrganizationId).HasColumnName("organization_id");

                entity.Property(e => e.PersonId).HasColumnName("person_id");

                entity.Property(e => e.Url).HasColumnName("url");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.ExternalLinks)
                    .HasForeignKey(d => d.ClientId);

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.ExternalLinks)
                    .HasForeignKey(d => d.CustomerId);

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.ExternalLinks)
                    .HasForeignKey(d => d.GroupId);

                entity.HasOne(d => d.Icon)
                    .WithMany(p => p.ExternalLinks)
                    .HasForeignKey(d => d.IconId);

                entity.HasOne(d => d.Organization)
                    .WithMany(p => p.ExternalLinks)
                    .HasForeignKey(d => d.OrganizationId);

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.ExternalLinks)
                    .HasForeignKey(d => d.PersonId);
            });

            modelBuilder.Entity<FarmerMemberships>(entity =>
            {
                entity.HasKey(e => new { e.FarmerId, e.ClientId });

                entity.ToTable("farmer_memberships");

                entity.HasIndex(e => e.ClientId);

                entity.Property(e => e.FarmerId).HasColumnName("farmer_id");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.FarmerMemberships)
                    .HasForeignKey(d => d.ClientId);

                entity.HasOne(d => d.Farmer)
                    .WithMany(p => p.FarmerMemberships)
                    .HasForeignKey(d => d.FarmerId);
            });

            modelBuilder.Entity<Farmers>(entity =>
            {
                entity.ToTable("farmers");

                entity.HasIndex(e => e.BankId);

                entity.HasIndex(e => e.GeoCoordinateId);

                entity.HasIndex(e => e.IsApproved)
                    .HasName("index_farmers_on_is_approved");

                entity.HasIndex(e => e.IsReviewed)
                    .HasName("index_farmers_on_is_reviewed");

                entity.HasIndex(e => e.PersonId);

                entity.HasIndex(e => e.RegionId);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BankId).HasColumnName("bank_id");

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasColumnType("character varying")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.CollectionCentreId).HasColumnName("collection_centre_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.Data)
                    .HasColumnName("data")
                    .HasColumnType("jsonb")
                    .HasDefaultValueSql("'\"{}\"'::jsonb");

                entity.Property(e => e.GeoCoordinateId).HasColumnName("geo_coordinate_id");

                entity.Property(e => e.IsApproved)
                    .HasColumnName("is_approved")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.IsReviewed)
                    .HasColumnName("is_reviewed")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.PersonId).HasColumnName("person_id");

                entity.Property(e => e.RegionId).HasColumnName("region_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("timestamp with time zone");

                entity.HasOne(d => d.Bank)
                    .WithMany(p => p.Farmers)
                    .HasForeignKey(d => d.BankId);

                entity.HasOne(d => d.GeoCoordinate)
                    .WithMany(p => p.Farmers)
                    .HasForeignKey(d => d.GeoCoordinateId);

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.Farmers)
                    .HasForeignKey(d => d.PersonId);

                entity.HasOne(d => d.Region)
                    .WithMany(p => p.Farmers)
                    .HasForeignKey(d => d.RegionId);
            });

            modelBuilder.Entity<FingerPrints>(entity =>
            {
                entity.ToTable("finger_prints");

                entity.HasIndex(e => e.CustomerId);

                entity.HasIndex(e => e.ImageId);

                entity.HasIndex(e => e.PersonId);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Code).HasColumnName("code");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.ImageId).HasColumnName("image_id");

                entity.Property(e => e.PersonId).HasColumnName("person_id");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.FingerPrints)
                    .HasForeignKey(d => d.CustomerId);

                entity.HasOne(d => d.Image)
                    .WithMany(p => p.FingerPrints)
                    .HasForeignKey(d => d.ImageId);

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.FingerPrints)
                    .HasForeignKey(d => d.PersonId);
            });

            modelBuilder.Entity<Forms>(entity =>
            {
                entity.ToTable("forms");

                entity.HasIndex(e => e.ClientId);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("timestamp with time zone");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.Forms)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("forms_client_id_fkey");
            });

            modelBuilder.Entity<FormSections>(entity =>
            {
                entity.ToTable("form_sections");

                entity.HasIndex(e => e.FormId);

                entity.HasIndex(e => e.SectionId);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.FormId).HasColumnName("form_id");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.Order).HasColumnName("order");

                entity.Property(e => e.SectionId).HasColumnName("section_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("timestamp with time zone");

                entity.HasOne(d => d.Form)
                    .WithMany(p => p.FormSections)
                    .HasForeignKey(d => d.FormId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("form_sections_form_id_fkey");

                entity.HasOne(d => d.Section)
                    .WithMany(p => p.InverseSection)
                    .HasForeignKey(d => d.SectionId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("form_sections_section_id_fkey");
            });

            modelBuilder.Entity<GeoCoordinates>(entity =>
            {
                entity.ToTable("geo_coordinates");

                entity.HasIndex(e => e.CreatedAt);

                entity.HasIndex(e => e.FarmerId);

                entity.HasIndex(e => e.Id)
                    .HasName("index_geo_data_on_id");

                entity.HasIndex(e => e.Location);

                entity.HasIndex(e => e.OwnedEntityType);

                entity.HasIndex(e => e.OwnedEntityTypeId);

                entity.HasIndex(e => e.UpdatedAt);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.FarmerId).HasColumnName("farmer_id");

                entity.Property(e => e.Latitude).HasColumnName("latitude");

                entity.Property(e => e.Location).HasColumnName("location");

                entity.Property(e => e.Longitude).HasColumnName("longitude");

                entity.Property(e => e.OwnedEntityType).HasColumnName("owned_entity_type");

                entity.Property(e => e.OwnedEntityTypeId).HasColumnName("owned_entity_type_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("timestamp with time zone");

                entity.HasOne(d => d.Farmer)
                    .WithMany(p => p.GeoCoordinates)
                    .HasForeignKey(d => d.FarmerId);
            });

            modelBuilder.Entity<GlAccounts>(entity =>
            {
                entity.ToTable("gl_accounts");

                entity.HasIndex(e => e.Active);

                entity.HasIndex(e => e.AllowManualJournalEntries);

                entity.HasIndex(e => e.BranchCode);

                entity.HasIndex(e => e.BranchId);

                entity.HasIndex(e => e.Class);

                entity.HasIndex(e => e.ClientId);

                entity.HasIndex(e => e.CreatedAt);

                entity.HasIndex(e => e.CurrencyId);

                entity.HasIndex(e => e.IsHeaderAccount);

                entity.HasIndex(e => e.Name);

                entity.HasIndex(e => e.Number);

                entity.HasIndex(e => e.ParentAccountId);

                entity.HasIndex(e => e.UpdatedAt);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasColumnName("active")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.AllowManualJournalEntries).HasColumnName("allow_manual_journal_entries");

                entity.Property(e => e.Balance).HasColumnName("balance");

                entity.Property(e => e.BalanceAsAt)
                    .HasColumnName("balance_as_at")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.BranchCode).HasColumnName("branch_code");

                entity.Property(e => e.BranchId).HasColumnName("branch_id");

                entity.Property(e => e.Class).HasColumnName("class");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.CurrencyId).HasColumnName("currency_id");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.IsHeaderAccount).HasColumnName("is_header_account");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.Number).HasColumnName("number");

                entity.Property(e => e.ParentAccountId).HasColumnName("parent_account_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("timestamp with time zone");

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.GlAccounts)
                    .HasForeignKey(d => d.BranchId);

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.GlAccounts)
                    .HasForeignKey(d => d.ClientId);

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.GlAccounts)
                    .HasForeignKey(d => d.CurrencyId);

                entity.HasOne(d => d.ParentAccount)
                    .WithMany(p => p.InverseParentAccount)
                    .HasForeignKey(d => d.ParentAccountId);
            });

            modelBuilder.Entity<GlProductLinks>(entity =>
            {
                entity.ToTable("gl_product_links");

                entity.HasIndex(e => e.ClientId);

                entity.HasIndex(e => e.FeeIncomeId);

                entity.HasIndex(e => e.FeeReceivableId);

                entity.HasIndex(e => e.FundSourceId);

                entity.HasIndex(e => e.InterestExpenseId);

                entity.HasIndex(e => e.InterestIncomeId);

                entity.HasIndex(e => e.InterestReceivableId);

                entity.HasIndex(e => e.LoanProductId);

                entity.HasIndex(e => e.OverdraftPortfolioControlId);

                entity.HasIndex(e => e.PenaltyIncomeId);

                entity.HasIndex(e => e.PenaltyReceivableId);

                entity.HasIndex(e => e.PortfolioControlId);

                entity.HasIndex(e => e.SavingsProductId);

                entity.HasIndex(e => e.WriteOffExpenseId);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.FeeIncomeId).HasColumnName("fee_income_id");

                entity.Property(e => e.FeeReceivableId).HasColumnName("fee_receivable_id");

                entity.Property(e => e.FundSourceId).HasColumnName("fund_source_id");

                entity.Property(e => e.InterestExpenseId).HasColumnName("interest_expense_id");

                entity.Property(e => e.InterestIncomeId).HasColumnName("interest_income_id");

                entity.Property(e => e.InterestReceivableId).HasColumnName("interest_receivable_id");

                entity.Property(e => e.LoanProductId).HasColumnName("loan_product_id");

                entity.Property(e => e.Methodology).HasColumnName("methodology");

                entity.Property(e => e.OverdraftPortfolioControlId).HasColumnName("overdraft_portfolio_control_id");

                entity.Property(e => e.PenaltyIncomeId).HasColumnName("penalty_income_id");

                entity.Property(e => e.PenaltyReceivableId).HasColumnName("penalty_receivable_id");

                entity.Property(e => e.PortfolioControlId).HasColumnName("portfolio_control_id");

                entity.Property(e => e.SavingsProductId).HasColumnName("savings_product_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.WriteOffExpenseId).HasColumnName("write_off_expense_id");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.GlProductLinks)
                    .HasForeignKey(d => d.ClientId);

                entity.HasOne(d => d.FeeIncome)
                    .WithMany(p => p.GlProductLinksFeeIncome)
                    .HasForeignKey(d => d.FeeIncomeId);

                entity.HasOne(d => d.FeeReceivable)
                    .WithMany(p => p.GlProductLinksFeeReceivable)
                    .HasForeignKey(d => d.FeeReceivableId);

                entity.HasOne(d => d.FundSource)
                    .WithMany(p => p.GlProductLinksFundSource)
                    .HasForeignKey(d => d.FundSourceId);

                entity.HasOne(d => d.InterestExpense)
                    .WithMany(p => p.GlProductLinksInterestExpense)
                    .HasForeignKey(d => d.InterestExpenseId);

                entity.HasOne(d => d.InterestIncome)
                    .WithMany(p => p.GlProductLinksInterestIncome)
                    .HasForeignKey(d => d.InterestIncomeId);

                entity.HasOne(d => d.InterestReceivable)
                    .WithMany(p => p.GlProductLinksInterestReceivable)
                    .HasForeignKey(d => d.InterestReceivableId);

                entity.HasOne(d => d.LoanProduct)
                    .WithMany(p => p.GlProductLinks)
                    .HasForeignKey(d => d.LoanProductId);

                entity.HasOne(d => d.OverdraftPortfolioControl)
                    .WithMany(p => p.GlProductLinksOverdraftPortfolioControl)
                    .HasForeignKey(d => d.OverdraftPortfolioControlId);

                entity.HasOne(d => d.PenaltyIncome)
                    .WithMany(p => p.GlProductLinksPenaltyIncome)
                    .HasForeignKey(d => d.PenaltyIncomeId);

                entity.HasOne(d => d.PenaltyReceivable)
                    .WithMany(p => p.GlProductLinksPenaltyReceivable)
                    .HasForeignKey(d => d.PenaltyReceivableId);

                entity.HasOne(d => d.PortfolioControl)
                    .WithMany(p => p.GlProductLinksPortfolioControl)
                    .HasForeignKey(d => d.PortfolioControlId);

                entity.HasOne(d => d.SavingsProduct)
                    .WithMany(p => p.GlProductLinks)
                    .HasForeignKey(d => d.SavingsProductId);

                entity.HasOne(d => d.WriteOffExpense)
                    .WithMany(p => p.GlProductLinksWriteOffExpense)
                    .HasForeignKey(d => d.WriteOffExpenseId);
            });

            modelBuilder.Entity<GlReconciliations>(entity =>
            {
                entity.ToTable("gl_reconciliations");

                entity.HasIndex(e => e.ClientId);

                entity.HasIndex(e => e.GlAccountId);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.ClosingBalance).HasColumnName("closing_balance");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.FirstEntryId).HasColumnName("first_entry_id");

                entity.Property(e => e.GlAccountId).HasColumnName("gl_account_id");

                entity.Property(e => e.LastEntryId).HasColumnName("last_entry_id");

                entity.Property(e => e.OpeningBalance).HasColumnName("opening_balance");

                entity.Property(e => e.ReconciledDate)
                    .HasColumnName("reconciled_date")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("timestamp with time zone");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.GlReconciliations)
                    .HasForeignKey(d => d.ClientId);

                entity.HasOne(d => d.GlAccount)
                    .WithMany(p => p.GlReconciliations)
                    .HasForeignKey(d => d.GlAccountId);
            });

            modelBuilder.Entity<GroupMembership>(entity =>
            {
                entity.HasKey(e => new { e.PersonId, e.GroupId });

                entity.ToTable("group_membership");

                entity.HasIndex(e => e.GroupId);

                entity.HasIndex(e => e.RoleId);

                entity.Property(e => e.PersonId).HasColumnName("person_id");

                entity.Property(e => e.GroupId).HasColumnName("group_id");

                entity.Property(e => e.RoleId).HasColumnName("role_id");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.GroupMembership)
                    .HasForeignKey(d => d.GroupId);

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.GroupMembership)
                    .HasForeignKey(d => d.PersonId);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.GroupMembership)
                    .HasForeignKey(d => d.RoleId);
            });

            modelBuilder.Entity<GroupRole>(entity =>
            {
                entity.ToTable("group_role");

                entity.HasIndex(e => e.ClientId);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("timestamp with time zone");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.GroupRole)
                    .HasForeignKey(d => d.ClientId);
            });

            modelBuilder.Entity<Groups>(entity =>
            {
                entity.ToTable("groups");

                entity.HasIndex(e => e.ClientId);

                entity.HasIndex(e => e.ContactDetailsId);

                entity.HasIndex(e => e.Name);

                entity.HasIndex(e => e.UpdatedAt);

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.ContactDetailsId).HasColumnName("contact_details_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.Notes).HasColumnName("notes");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("timestamp with time zone");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.Groups)
                    .HasForeignKey(d => d.ClientId);

                entity.HasOne(d => d.ContactDetails)
                    .WithMany(p => p.Groups)
                    .HasForeignKey(d => d.ContactDetailsId);
            });

            modelBuilder.Entity<IdentityDocuments>(entity =>
            {
                entity.ToTable("identity_documents");

                entity.HasIndex(e => e.DocumentHolderId);

                entity.HasIndex(e => e.ImageId);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.DocumentHolderId).HasColumnName("document_holder_id");

                entity.Property(e => e.DocumentType).HasColumnName("document_type");

                entity.Property(e => e.ImageId).HasColumnName("image_id");

                entity.Property(e => e.IssuedDate)
                    .HasColumnName("issued_date")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.IssuingAuthority).HasColumnName("issuing_authority");

                entity.Property(e => e.Number).HasColumnName("number");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.ValidUntil)
                    .HasColumnName("valid_until")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.Verified).HasColumnName("verified");

                entity.HasOne(d => d.DocumentHolder)
                    .WithMany(p => p.IdentityDocuments)
                    .HasForeignKey(d => d.DocumentHolderId);

                entity.HasOne(d => d.Image)
                    .WithMany(p => p.IdentityDocuments)
                    .HasForeignKey(d => d.ImageId);
            });

            modelBuilder.Entity<JournalEntries>(entity =>
            {
                entity.ToTable("journal_entries");

                entity.HasIndex(e => e.ClientId);

                entity.HasIndex(e => e.CreatedAt);

                entity.HasIndex(e => e.CurrencyId);

                entity.HasIndex(e => e.EntryDate);

                entity.HasIndex(e => e.EntryId);

                entity.HasIndex(e => e.GlAccountId);

                entity.HasIndex(e => e.GlReconciliationId);

                entity.HasIndex(e => e.Indicator);

                entity.HasIndex(e => e.IsPosted);

                entity.HasIndex(e => e.IsReversed);

                entity.HasIndex(e => e.NoteId);

                entity.HasIndex(e => e.PostedDate);

                entity.HasIndex(e => e.Reference);

                entity.HasIndex(e => e.ReversalEntryId)
                    .IsUnique();

                entity.HasIndex(e => e.TransactionId);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.CurrencyId).HasColumnName("currency_id");

                entity.Property(e => e.EntryDate)
                    .HasColumnName("entry_date")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.EntryId)
                    .HasColumnName("entry_id")
                    .HasDefaultValueSql("nextval('\"JournalEntriesSequence\"'::regclass)");

                entity.Property(e => e.GlAccountId).HasColumnName("gl_account_id");

                entity.Property(e => e.GlReconciliationId).HasColumnName("gl_reconciliation_id");

                entity.Property(e => e.Indicator).HasColumnName("indicator");

                entity.Property(e => e.IsPosted).HasColumnName("is_posted");

                entity.Property(e => e.IsReversed).HasColumnName("is_reversed");

                entity.Property(e => e.Narration).HasColumnName("narration");

                entity.Property(e => e.NoteId).HasColumnName("note_id");

                entity.Property(e => e.PostedDate)
                    .HasColumnName("posted_date")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.Reference).HasColumnName("reference");

                entity.Property(e => e.ReversalEntryId).HasColumnName("reversal_entry_id");

                entity.Property(e => e.TransactionId).HasColumnName("transaction_id");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.JournalEntries)
                    .HasForeignKey(d => d.ClientId);

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.JournalEntries)
                    .HasForeignKey(d => d.CurrencyId);

                entity.HasOne(d => d.GlAccount)
                    .WithMany(p => p.JournalEntries)
                    .HasForeignKey(d => d.GlAccountId);

                entity.HasOne(d => d.GlReconciliation)
                    .WithMany(p => p.JournalEntries)
                    .HasForeignKey(d => d.GlReconciliationId);

                entity.HasOne(d => d.Note)
                    .WithMany(p => p.JournalEntries)
                    .HasForeignKey(d => d.NoteId);

                entity.HasOne(d => d.ReversalEntry)
                    .WithOne(p => p.InverseReversalEntry)
                    .HasForeignKey<JournalEntries>(d => d.ReversalEntryId);

                entity.HasOne(d => d.Transaction)
                    .WithMany(p => p.JournalEntries)
                    .HasForeignKey(d => d.TransactionId);
            });

            modelBuilder.Entity<JournalPostings>(entity =>
            {
                entity.ToTable("journal_postings");

                entity.HasIndex(e => e.ClientId);

                entity.HasIndex(e => e.CurrencyId);

                entity.HasIndex(e => e.GlAccountId);

                entity.HasIndex(e => e.GlReconciliationId);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.CurrencyId).HasColumnName("currency_id");

                entity.Property(e => e.GlAccountId).HasColumnName("gl_account_id");

                entity.Property(e => e.GlReconciliationId).HasColumnName("gl_reconciliation_id");

                entity.Property(e => e.Indicator).HasColumnName("indicator");

                entity.Property(e => e.Narration).HasColumnName("narration");

                entity.Property(e => e.PostingDate)
                    .HasColumnName("posting_date")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.Reference).HasColumnName("reference");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("timestamp with time zone");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.JournalPostings)
                    .HasForeignKey(d => d.ClientId);

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.JournalPostings)
                    .HasForeignKey(d => d.CurrencyId);

                entity.HasOne(d => d.GlAccount)
                    .WithMany(p => p.JournalPostings)
                    .HasForeignKey(d => d.GlAccountId);

                entity.HasOne(d => d.GlReconciliation)
                    .WithMany(p => p.JournalPostings)
                    .HasForeignKey(d => d.GlReconciliationId);
            });

            modelBuilder.Entity<Languages>(entity =>
            {
                entity.ToTable("languages");

                entity.HasIndex(e => e.CountryId);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CountryId).HasColumnName("country_id");

                entity.Property(e => e.Iso6391).HasColumnName("iso6391");

                entity.Property(e => e.Iso6392).HasColumnName("iso6392");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.NativeName).HasColumnName("native_name");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Languages)
                    .HasForeignKey(d => d.CountryId);
            });

            modelBuilder.Entity<LoanAccounts>(entity =>
            {
                entity.ToTable("loan_accounts");

                entity.HasIndex(e => e.AccountCurrencyId);

                entity.HasIndex(e => e.AccountOfficerId);

                entity.HasIndex(e => e.AccountOwnerId);

                entity.HasIndex(e => e.AccountState);

                entity.HasIndex(e => e.ActivationDate);

                entity.HasIndex(e => e.Active);

                entity.HasIndex(e => e.BranchAssignedId);

                entity.HasIndex(e => e.CentreAssignedId);

                entity.HasIndex(e => e.ClientId);

                entity.HasIndex(e => e.CreatedAt);

                entity.HasIndex(e => e.DateClosed);

                entity.HasIndex(e => e.LoanProductId);

                entity.HasIndex(e => e.Number)
                    .HasName("index_loan_accounts_on_number")
                    .IsUnique();

                entity.HasIndex(e => e.Primary);

                entity.HasIndex(e => e.Title);

                entity.HasIndex(e => e.UpdatedAt);

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AccountCurrencyId).HasColumnName("account_currency_id");

                entity.Property(e => e.AccountOfficerId).HasColumnName("account_officer_id");

                entity.Property(e => e.AccountOwnerId).HasColumnName("account_owner_id");

                entity.Property(e => e.AccountState).HasColumnName("account_state");

                entity.Property(e => e.AccruedInterest).HasColumnName("accrued_interest");

                entity.Property(e => e.AccruedPenalty).HasColumnName("accrued_penalty");

                entity.Property(e => e.ActivationDate)
                    .HasColumnName("activation_date")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.ActivationTransactionId).HasColumnName("activation_transaction_id");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasColumnName("active")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.ApprovedDate)
                    .HasColumnName("approved_date")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.BranchAssignedId).HasColumnName("branch_assigned_id");

                entity.Property(e => e.CentreAssignedId).HasColumnName("centre_assigned_id");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.DateClosed)
                    .HasColumnName("date_closed")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.FeesBalance).HasColumnName("fees_balance");

                entity.Property(e => e.FeesDue).HasColumnName("fees_due");

                entity.Property(e => e.FeesPaid).HasColumnName("fees_paid");

                entity.Property(e => e.HasCustomSchedule).HasColumnName("has_custom_schedule");

                entity.Property(e => e.InterestBalance).HasColumnName("interest_balance");

                entity.Property(e => e.InterestCommission).HasColumnName("interest_commission");

                entity.Property(e => e.InterestDue).HasColumnName("interest_due");

                entity.Property(e => e.InterestPaid).HasColumnName("interest_paid");

                entity.Property(e => e.InterestRate).HasColumnName("interest_rate");

                entity.Property(e => e.InterestSpread).HasColumnName("interest_spread");

                entity.Property(e => e.LoanAmount).HasColumnName("loan_amount");

                entity.Property(e => e.LoanName).HasColumnName("loan_name");

                entity.Property(e => e.LoanProductId).HasColumnName("loan_product_id");

                entity.Property(e => e.Meta)
                    .HasColumnName("meta")
                    .HasColumnType("jsonb");

                entity.Property(e => e.Number).HasColumnName("number");

                entity.Property(e => e.PenaltyBalance).HasColumnName("penalty_balance");

                entity.Property(e => e.PenaltyDue).HasColumnName("penalty_due");

                entity.Property(e => e.PenaltyRate).HasColumnName("penalty_rate");

                entity.Property(e => e.Primary).HasColumnName("primary");

                entity.Property(e => e.PrincipalDue).HasColumnName("principal_due");

                entity.Property(e => e.PrincipalPaid).HasColumnName("principal_paid");

                entity.Property(e => e.RepaymentInstallments).HasColumnName("repayment_installments");

                entity.Property(e => e.Title).HasColumnName("title");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("timestamp with time zone");

                entity.HasOne(d => d.AccountCurrency)
                    .WithMany(p => p.LoanAccounts)
                    .HasForeignKey(d => d.AccountCurrencyId);

                entity.HasOne(d => d.AccountOfficer)
                    .WithMany(p => p.LoanAccounts)
                    .HasForeignKey(d => d.AccountOfficerId);

                entity.HasOne(d => d.AccountOwner)
                    .WithMany(p => p.LoanAccounts)
                    .HasForeignKey(d => d.AccountOwnerId);

                entity.HasOne(d => d.BranchAssigned)
                    .WithMany(p => p.LoanAccounts)
                    .HasForeignKey(d => d.BranchAssignedId);

                entity.HasOne(d => d.CentreAssigned)
                    .WithMany(p => p.LoanAccounts)
                    .HasForeignKey(d => d.CentreAssignedId);

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.LoanAccounts)
                    .HasForeignKey(d => d.ClientId);

                entity.HasOne(d => d.LoanProduct)
                    .WithMany(p => p.LoanAccounts)
                    .HasForeignKey(d => d.LoanProductId);
            });

            modelBuilder.Entity<LoanProducts>(entity =>
            {
                entity.ToTable("loan_products");

                entity.HasIndex(e => e.AccountLinkingEnabled);

                entity.HasIndex(e => e.AccountingMethod);

                entity.HasIndex(e => e.Active);

                entity.HasIndex(e => e.AllowAccountOpening);

                entity.HasIndex(e => e.AllowSelfService);

                entity.HasIndex(e => e.AllowTransactions);

                entity.HasIndex(e => e.ClientId);

                entity.HasIndex(e => e.Code)
                    .HasName("index_loan_products_on_code")
                    .IsUnique();

                entity.HasIndex(e => e.CreatedAt);

                entity.HasIndex(e => e.CurrencyId);

                entity.HasIndex(e => e.ForCorporates);

                entity.HasIndex(e => e.ForGroups);

                entity.HasIndex(e => e.ForIndividuals);

                entity.HasIndex(e => e.Name);

                entity.HasIndex(e => e.ProductType);

                entity.HasIndex(e => e.UpdatedAt);

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AccountLinkingEnabled).HasColumnName("account_linking_enabled");

                entity.Property(e => e.AccountingMethod).HasColumnName("accounting_method");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasColumnName("active")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.AllowAccountOpening).HasColumnName("allow_account_opening");

                entity.Property(e => e.AllowSelfService).HasColumnName("allow_self_service");

                entity.Property(e => e.AllowTransactions).HasColumnName("allow_transactions");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.Code).HasColumnName("code");

                entity.Property(e => e.CommissionPercentage).HasColumnName("commission_percentage");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.CurrencyId).HasColumnName("currency_id");

                entity.Property(e => e.DefaultFirstRepaymentDueDateOffset).HasColumnName("default_first_repayment_due_date_offset");

                entity.Property(e => e.DefaultGracePeriod).HasColumnName("default_grace_period");

                entity.Property(e => e.DefaultLoanAmount).HasColumnName("default_loan_amount");

                entity.Property(e => e.DefaultNumInstallments).HasColumnName("default_num_installments");

                entity.Property(e => e.DefaultPenaltyRate).HasColumnName("default_penalty_rate");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.DormancyPeriodDays).HasColumnName("dormancy_period_days");

                entity.Property(e => e.ForCorporates).HasColumnName("for_corporates");

                entity.Property(e => e.ForGroups).HasColumnName("for_groups");

                entity.Property(e => e.ForIndividuals).HasColumnName("for_individuals");

                entity.Property(e => e.InterestRate).HasColumnName("interest_rate");

                entity.Property(e => e.LoanLimit).HasColumnName("loan_limit");

                entity.Property(e => e.LoanPenaltyGracePeriod).HasColumnName("loan_penalty_grace_period");

                entity.Property(e => e.LockPeriodDays).HasColumnName("lock_period_days");

                entity.Property(e => e.MaxFirstRepaymentDueDateOffset).HasColumnName("max_first_repayment_due_date_offset");

                entity.Property(e => e.MaxGracePeriod).HasColumnName("max_grace_period");

                entity.Property(e => e.MaxLoanAmount).HasColumnName("max_loan_amount");

                entity.Property(e => e.MaxNumInstallments).HasColumnName("max_num_installments");

                entity.Property(e => e.MaxPenaltyRate).HasColumnName("max_penalty_rate");

                entity.Property(e => e.MinFirstRepaymentDueDateOffset).HasColumnName("min_first_repayment_due_date_offset");

                entity.Property(e => e.MinGracePeriod).HasColumnName("min_grace_period");

                entity.Property(e => e.MinLoanAmount).HasColumnName("min_loan_amount");

                entity.Property(e => e.MinNumInstallments).HasColumnName("min_num_installments");

                entity.Property(e => e.MinPenaltyRate).HasColumnName("min_penalty_rate");

                entity.Property(e => e.MinimumBalance).HasColumnName("minimum_balance");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.ProcessingFeeRate).HasColumnName("processing_fee_rate");

                entity.Property(e => e.ProductType).HasColumnName("product_type");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("timestamp with time zone");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.LoanProducts)
                    .HasForeignKey(d => d.ClientId);

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.LoanProducts)
                    .HasForeignKey(d => d.CurrencyId);
            });

            modelBuilder.Entity<MaritalDetails>(entity =>
            {
                entity.ToTable("marital_details");

                entity.HasIndex(e => e.SpouseId);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.MaritalStatus).HasColumnName("marital_status");

                entity.Property(e => e.SpouseId).HasColumnName("spouse_id");

                entity.HasOne(d => d.Spouse)
                    .WithMany(p => p.MaritalDetails)
                    .HasForeignKey(d => d.SpouseId);
            });

            modelBuilder.Entity<MerchantContracts>(entity =>
            {
                entity.HasKey(e => new { e.MerchantId, e.ClientId });

                entity.ToTable("merchant_contracts");

                entity.HasIndex(e => e.ClientId);

                entity.Property(e => e.MerchantId).HasColumnName("merchant_id");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.ContractInitiated)
                    .HasColumnName("contract_initiated")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.ContractModified)
                    .HasColumnName("contract_modified")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.MerchantCommission).HasColumnName("merchant_commission");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.MerchantContractsClient)
                    .HasForeignKey(d => d.ClientId);

                entity.HasOne(d => d.Merchant)
                    .WithMany(p => p.MerchantContractsMerchant)
                    .HasForeignKey(d => d.MerchantId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Notes>(entity =>
            {
                entity.ToTable("notes");

                entity.HasIndex(e => e.ActivityId);

                entity.HasIndex(e => e.AgentContractId);

                entity.HasIndex(e => e.CentreId);

                entity.HasIndex(e => e.ClientId);

                entity.HasIndex(e => e.CreatedById);

                entity.HasIndex(e => e.LoanAccountId);

                entity.HasIndex(e => e.PersonId);

                entity.HasIndex(e => e.SavingsAccountId);

                entity.HasIndex(e => e.TransactionDetailId);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ActivityId).HasColumnName("activity_id");

                entity.Property(e => e.AgentContractId).HasColumnName("agent_contract_id");

                entity.Property(e => e.CentreId).HasColumnName("centre_id");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.CreatedById).HasColumnName("created_by_id");

                entity.Property(e => e.LoanAccountId).HasColumnName("loan_account_id");

                entity.Property(e => e.PersonId).HasColumnName("person_id");

                entity.Property(e => e.SavingsAccountId).HasColumnName("savings_account_id");

                entity.Property(e => e.Text).HasColumnName("text");

                entity.Property(e => e.TransactionDetailId).HasColumnName("transaction_detail_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("timestamp with time zone");

                entity.HasOne(d => d.Activity)
                    .WithMany(p => p.Notes)
                    .HasForeignKey(d => d.ActivityId);

                entity.HasOne(d => d.AgentContract)
                    .WithMany(p => p.Notes)
                    .HasForeignKey(d => d.AgentContractId);

                entity.HasOne(d => d.Centre)
                    .WithMany(p => p.Notes)
                    .HasForeignKey(d => d.CentreId);

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.Notes)
                    .HasForeignKey(d => d.ClientId);

                entity.HasOne(d => d.CreatedBy)
                    .WithMany(p => p.Notes)
                    .HasForeignKey(d => d.CreatedById);

                entity.HasOne(d => d.LoanAccount)
                    .WithMany(p => p.Notes)
                    .HasForeignKey(d => d.LoanAccountId);

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.Notes)
                    .HasForeignKey(d => d.PersonId);

                entity.HasOne(d => d.SavingsAccount)
                    .WithMany(p => p.Notes)
                    .HasForeignKey(d => d.SavingsAccountId);

                entity.HasOne(d => d.TransactionDetail)
                    .WithMany(p => p.Notes)
                    .HasForeignKey(d => d.TransactionDetailId);
            });

            modelBuilder.Entity<OauthAccessGrants>(entity =>
            {
                entity.ToTable("oauth_access_grants");

                entity.HasIndex(e => e.ApplicationId)
                    .HasName("index_oauth_access_grants_on_application_id");

                entity.HasIndex(e => e.Token)
                    .HasName("index_oauth_access_grants_on_token")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ApplicationId).HasColumnName("application_id");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.ExpiresIn).HasColumnName("expires_in");

                entity.Property(e => e.RedirectUri)
                    .IsRequired()
                    .HasColumnName("redirect_uri");

                entity.Property(e => e.ResourceOwnerId).HasColumnName("resource_owner_id");

                entity.Property(e => e.RevokedAt).HasColumnName("revoked_at");

                entity.Property(e => e.Scopes)
                    .HasColumnName("scopes")
                    .HasColumnType("character varying");

                entity.Property(e => e.Token)
                    .IsRequired()
                    .HasColumnName("token")
                    .HasColumnType("character varying");

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.OauthAccessGrants)
                    .HasForeignKey(d => d.ApplicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_b4b53e07b8");

                entity.HasOne(d => d.ResourceOwner)
                    .WithMany(p => p.OauthAccessGrants)
                    .HasForeignKey(d => d.ResourceOwnerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_rails_330c32d8d9");
            });

            modelBuilder.Entity<OauthAccessTokens>(entity =>
            {
                entity.ToTable("oauth_access_tokens");

                entity.HasIndex(e => e.ApplicationId)
                    .HasName("index_oauth_access_tokens_on_application_id");

                entity.HasIndex(e => e.RefreshToken)
                    .HasName("index_oauth_access_tokens_on_refresh_token")
                    .IsUnique();

                entity.HasIndex(e => e.ResourceOwnerId)
                    .HasName("index_oauth_access_tokens_on_resource_owner_id");

                entity.HasIndex(e => e.Token)
                    .HasName("index_oauth_access_tokens_on_token")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ApplicationId).HasColumnName("application_id");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.ExpiresIn).HasColumnName("expires_in");

                entity.Property(e => e.PreviousRefreshToken)
                    .IsRequired()
                    .HasColumnName("previous_refresh_token")
                    .HasColumnType("character varying")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.RefreshToken)
                    .HasColumnName("refresh_token")
                    .HasColumnType("character varying");

                entity.Property(e => e.ResourceOwnerId).HasColumnName("resource_owner_id");

                entity.Property(e => e.RevokedAt).HasColumnName("revoked_at");

                entity.Property(e => e.Scopes)
                    .HasColumnName("scopes")
                    .HasColumnType("character varying");

                entity.Property(e => e.Token)
                    .IsRequired()
                    .HasColumnName("token")
                    .HasColumnType("character varying");

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.OauthAccessTokens)
                    .HasForeignKey(d => d.ApplicationId)
                    .HasConstraintName("fk_rails_732cb83ab7");

                entity.HasOne(d => d.ResourceOwner)
                    .WithMany(p => p.OauthAccessTokens)
                    .HasForeignKey(d => d.ResourceOwnerId)
                    .HasConstraintName("fk_rails_ee63f25419");
            });

            modelBuilder.Entity<OauthApplications>(entity =>
            {
                entity.ToTable("oauth_applications");

                entity.HasIndex(e => e.Uid)
                    .HasName("index_oauth_applications_on_uid")
                    .IsUnique();

                entity.HasIndex(e => new { e.OwnerId, e.OwnerType })
                    .HasName("index_oauth_applications_on_owner_id_and_owner_type");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("character varying");

                entity.Property(e => e.OwnerId).HasColumnName("owner_id");

                entity.Property(e => e.OwnerType)
                    .HasColumnName("owner_type")
                    .HasColumnType("character varying");

                entity.Property(e => e.RedirectUri)
                    .IsRequired()
                    .HasColumnName("redirect_uri");

                entity.Property(e => e.Scopes)
                    .IsRequired()
                    .HasColumnName("scopes")
                    .HasColumnType("character varying")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.Secret)
                    .IsRequired()
                    .HasColumnName("secret")
                    .HasColumnType("character varying");

                entity.Property(e => e.Uid)
                    .IsRequired()
                    .HasColumnName("uid")
                    .HasColumnType("character varying");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
            });

            modelBuilder.Entity<Organizations>(entity =>
            {
                entity.ToTable("organizations");

                entity.HasIndex(e => e.AddressId);

                entity.HasIndex(e => e.BusinessName);

                entity.HasIndex(e => e.ContactDetailsId);

                entity.HasIndex(e => e.CreatedAt);

                entity.HasIndex(e => e.ManagerId);

                entity.HasIndex(e => e.OrganizationType);

                entity.HasIndex(e => e.TradeName);

                entity.HasIndex(e => e.UpdatedAt);

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AddressId).HasColumnName("address_id");

                entity.Property(e => e.BusinessName).HasColumnName("business_name");

                entity.Property(e => e.BusinessRegistrationNumber).HasColumnName("business_registration_number");

                entity.Property(e => e.ContactDetailsId).HasColumnName("contact_details_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.Industry).HasColumnName("industry");

                entity.Property(e => e.ManagerId).HasColumnName("manager_id");

                entity.Property(e => e.OrganizationType).HasColumnName("organization_type");

                entity.Property(e => e.Sector).HasColumnName("sector");

                entity.Property(e => e.TradeName).HasColumnName("trade_name");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("timestamp with time zone");

                entity.HasOne(d => d.Address)
                    .WithMany(p => p.Organizations)
                    .HasForeignKey(d => d.AddressId);

                entity.HasOne(d => d.ContactDetails)
                    .WithMany(p => p.Organizations)
                    .HasForeignKey(d => d.ContactDetailsId);

                entity.HasOne(d => d.Manager)
                    .WithMany(p => p.Organizations)
                    .HasForeignKey(d => d.ManagerId);
            });

            modelBuilder.Entity<OtherBankAccount>(entity =>
            {
                entity.ToTable("other_bank_account");

                entity.HasIndex(e => e.AccountCurrencyId);

                entity.HasIndex(e => e.PersonId);

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AccountCurrencyId).HasColumnName("account_currency_id");

                entity.Property(e => e.AccountNumber).HasColumnName("account_number");

                entity.Property(e => e.AccountType).HasColumnName("account_type");

                entity.Property(e => e.Branch).HasColumnName("branch");

                entity.Property(e => e.DateOpened)
                    .HasColumnName("date_opened")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.InstitutionName).HasColumnName("institution_name");

                entity.Property(e => e.PersonId).HasColumnName("person_id");

                entity.HasOne(d => d.AccountCurrency)
                    .WithMany(p => p.OtherBankAccount)
                    .HasForeignKey(d => d.AccountCurrencyId);

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.OtherBankAccount)
                    .HasForeignKey(d => d.PersonId);
            });

            modelBuilder.Entity<Partners>(entity =>
            {
                entity.ToTable("partners");

                entity.HasIndex(e => e.AddressId);

                entity.HasIndex(e => e.ContactDetailId);

                entity.HasIndex(e => e.CreatedAt);

                entity.HasIndex(e => e.Location);

                entity.HasIndex(e => e.OrganizationId);

                entity.HasIndex(e => e.UpdatedAt);

                entity.HasIndex(e => e.UserId)
                    .HasName("index_partners_on_user_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AddressId).HasColumnName("address_id");

                entity.Property(e => e.Code).HasColumnName("code");

                entity.Property(e => e.ContactDetailId).HasColumnName("contact_detail_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.Location).HasColumnName("location");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.OrganizationId).HasColumnName("organization_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.Address)
                    .WithMany(p => p.Partners)
                    .HasForeignKey(d => d.AddressId);

                entity.HasOne(d => d.ContactDetail)
                    .WithMany(p => p.Partners)
                    .HasForeignKey(d => d.ContactDetailId);

                entity.HasOne(d => d.Organization)
                    .WithMany(p => p.Partners)
                    .HasForeignKey(d => d.OrganizationId);
            });

            modelBuilder.Entity<People>(entity =>
            {
                entity.ToTable("people");

                entity.HasIndex(e => e.ContactDetailsId);

                entity.HasIndex(e => e.CreatedAt);

                entity.HasIndex(e => e.EconomicDetailsId);

                entity.HasIndex(e => e.FirstName)
                    .HasName("index_people_on_first_name");

                entity.HasIndex(e => e.MaritalDetailsId);

                entity.HasIndex(e => e.NationalityId);

                entity.HasIndex(e => e.NextOfKinId);

                entity.HasIndex(e => e.OtherNames);

                entity.HasIndex(e => e.RegionId)
                    .HasName("index_people_on_region_id");

                entity.HasIndex(e => e.Surname)
                    .HasName("index_people_on_surname");

                entity.HasIndex(e => e.UpdatedAt);

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Age).HasColumnName("age");

                entity.Property(e => e.ContactDetailsId).HasColumnName("contact_details_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.DateOfBirth).HasColumnName("date_of_birth");

                entity.Property(e => e.EconomicDetailsId).HasColumnName("economic_details_id");

                entity.Property(e => e.FirstName)
                    .HasColumnName("first_name")
                    .HasColumnType("character varying(200)");

                entity.Property(e => e.Gender).HasColumnName("gender");

                entity.Property(e => e.MaritalDetailsId).HasColumnName("marital_details_id");

                entity.Property(e => e.NationalityId).HasColumnName("nationality_id");

                entity.Property(e => e.NextOfKinId).HasColumnName("next_of_kin_id");

                entity.Property(e => e.OtherNames).HasColumnName("other_names");

                entity.Property(e => e.PlaceOfBirth).HasColumnName("place_of_birth");

                entity.Property(e => e.RegionId).HasColumnName("region_id");

                entity.Property(e => e.Surname)
                    .HasColumnName("surname")
                    .HasColumnType("character varying(500)");

                entity.Property(e => e.Title).HasColumnName("title");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("timestamp with time zone");

                entity.HasOne(d => d.ContactDetails)
                    .WithMany(p => p.People)
                    .HasForeignKey(d => d.ContactDetailsId);

                entity.HasOne(d => d.EconomicDetails)
                    .WithMany(p => p.People)
                    .HasForeignKey(d => d.EconomicDetailsId);

                entity.HasOne(d => d.MaritalDetailsNavigation)
                    .WithMany(p => p.People)
                    .HasForeignKey(d => d.MaritalDetailsId);

                entity.HasOne(d => d.Nationality)
                    .WithMany(p => p.People)
                    .HasForeignKey(d => d.NationalityId);

                entity.HasOne(d => d.NextOfKin)
                    .WithMany(p => p.People)
                    .HasForeignKey(d => d.NextOfKinId);

                entity.HasOne(d => d.Region)
                    .WithMany(p => p.People)
                    .HasForeignKey(d => d.RegionId)
                    .HasConstraintName("fk_rails_65617429b5");
            });

            modelBuilder.Entity<PhoneNumbers>(entity =>
            {
                entity.ToTable("phone_numbers");

                entity.HasIndex(e => e.Active);

                entity.HasIndex(e => e.Carrier);

                entity.HasIndex(e => e.ContactDetailId);

                entity.HasIndex(e => e.CreatedAt);

                entity.HasIndex(e => e.Number)
                    .HasName("index_phone_numbers_on_number")
                    .IsUnique();

                entity.HasIndex(e => e.NumberType);

                entity.HasIndex(e => e.Ported);

                entity.HasIndex(e => e.Primary);

                entity.HasIndex(e => e.UpdatedAt);

                entity.HasIndex(e => e.Verified);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasColumnName("active")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.Carrier).HasColumnName("carrier");

                entity.Property(e => e.ContactDetailId).HasColumnName("contact_detail_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Number)
                    .IsRequired()
                    .HasColumnName("number")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.NumberType).HasColumnName("number_type");

                entity.Property(e => e.Ported)
                    .HasColumnName("ported")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.Primary)
                    .HasColumnName("primary")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.Verified).HasColumnName("verified");

                entity.HasOne(d => d.ContactDetail)
                    .WithMany(p => p.PhoneNumbers)
                    .HasForeignKey(d => d.ContactDetailId);
            });

            modelBuilder.Entity<Pictures>(entity =>
            {
                entity.ToTable("pictures");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.FileSize).HasColumnName("file_size");

                entity.Property(e => e.Format).HasColumnName("format");

                entity.Property(e => e.LargeImage).HasColumnName("large_image");

                entity.Property(e => e.MediumImage).HasColumnName("medium_image");

                entity.Property(e => e.SmallImage).HasColumnName("small_image");

                entity.Property(e => e.Title).HasColumnName("title");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("timestamp with time zone");
            });

            modelBuilder.Entity<PlatformPrivileges>(entity =>
            {
                entity.ToTable("platform_privileges");

                entity.HasIndex(e => e.Category);

                entity.HasIndex(e => e.Name);

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Category).HasColumnName("category");

                entity.Property(e => e.Name).HasColumnName("name");
            });

            modelBuilder.Entity<Privileges>(entity =>
            {
                entity.ToTable("privileges");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasColumnType("character varying");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("character varying");

                entity.Property(e => e.PrivilegeType)
                    .HasColumnName("privilege_type")
                    .HasColumnType("character varying");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
            });

            modelBuilder.Entity<ProductAssignments>(entity =>
            {
                entity.ToTable("product_assignments");

                entity.HasIndex(e => e.AgentContractId)
                    .HasName("index_product_assignments_on_agent_id");

                entity.HasIndex(e => e.ClientId);

                entity.HasIndex(e => e.CreatedAt);

                entity.HasIndex(e => e.LoanProductId)
                    .HasName("index_product_assignments_on_loan_product_id");

                entity.HasIndex(e => e.SavingsProductId)
                    .HasName("index_product_assignments_on_savings_product_id");

                entity.HasIndex(e => e.UpdatedAt);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AgentContractId).HasColumnName("agent_contract_id");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.LoanProductId).HasColumnName("loan_product_id");

                entity.Property(e => e.SavingsProductId).HasColumnName("savings_product_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("timestamp with time zone");

                entity.HasOne(d => d.AgentContract)
                    .WithMany(p => p.ProductAssignments)
                    .HasForeignKey(d => d.AgentContractId)
                    .HasConstraintName("fk_product_assignments_agents_contracts");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.ProductAssignments)
                    .HasForeignKey(d => d.ClientId);

                entity.HasOne(d => d.SavingsProduct)
                    .WithMany(p => p.ProductAssignments)
                    .HasForeignKey(d => d.SavingsProductId)
                    .HasConstraintName("fk_product_assignments_loan_products");

                entity.HasOne(d => d.SavingsProductNavigation)
                    .WithMany(p => p.ProductAssignments)
                    .HasForeignKey(d => d.SavingsProductId)
                    .HasConstraintName("fk_product_assignments_savings_products");
            });

            modelBuilder.Entity<Products>(entity =>
            {
                entity.ToTable("products");

                entity.HasIndex(e => e.IconId);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.IconId).HasColumnName("icon_id");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("timestamp with time zone");

                entity.HasOne(d => d.Icon)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.IconId);
            });

            modelBuilder.Entity<ProductServices>(entity =>
            {
                entity.ToTable("product_services");

                entity.HasIndex(e => e.ProductId);

                entity.HasIndex(e => e.ServiceId);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.ServiceId).HasColumnName("service_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("timestamp with time zone");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductServices)
                    .HasForeignKey(d => d.ProductId);

                entity.HasOne(d => d.Service)
                    .WithMany(p => p.ProductServices)
                    .HasForeignKey(d => d.ServiceId);
            });

            modelBuilder.Entity<QuestionAnswers>(entity =>
            {
                entity.ToTable("question_answers");

                entity.HasIndex(e => e.CustomerId);

                entity.HasIndex(e => e.QuestionId);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.InsertedAt).HasColumnName("inserted_at");

                entity.Property(e => e.QuestionId).HasColumnName("question_id");

                entity.Property(e => e.Type).HasColumnName("type");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.Property(e => e.Value).HasColumnName("value");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.QuestionAnswers)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("question_answers_user_id_fkey");

                entity.HasOne(d => d.Question)
                    .WithMany(p => p.QuestionAnswers)
                    .HasForeignKey(d => d.QuestionId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("question_answers_question_id_fkey");
            });

            modelBuilder.Entity<QuestionOptions>(entity =>
            {
                entity.ToTable("question_options");

                entity.HasIndex(e => e.QuestionId);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.QuestionId).HasColumnName("question_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.Value).HasColumnName("value");

                entity.HasOne(d => d.Question)
                    .WithMany(p => p.QuestionOptions)
                    .HasForeignKey(d => d.QuestionId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("question_options_question_id_fkey");
            });

            modelBuilder.Entity<Questions>(entity =>
            {
                entity.ToTable("questions");

                entity.HasIndex(e => e.FormId);

                entity.HasIndex(e => e.QuestionTypeId);

                entity.HasIndex(e => e.SectionId);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.FormId).HasColumnName("form_id");

                entity.Property(e => e.Meta)
                    .HasColumnName("meta")
                    .HasColumnType("jsonb");

                entity.Property(e => e.Order).HasColumnName("order");

                entity.Property(e => e.QuestionTypeId).HasColumnName("question_type_id");

                entity.Property(e => e.Required).HasColumnName("required");

                entity.Property(e => e.SectionId).HasColumnName("section_id");

                entity.Property(e => e.Title).HasColumnName("title");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("timestamp with time zone");

                entity.HasOne(d => d.Form)
                    .WithMany(p => p.Questions)
                    .HasForeignKey(d => d.FormId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("questions_form_id_fkey");

                entity.HasOne(d => d.QuestionType)
                    .WithMany(p => p.Questions)
                    .HasForeignKey(d => d.QuestionTypeId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("questions_question_type_id_fkey");

                entity.HasOne(d => d.Section)
                    .WithMany(p => p.Questions)
                    .HasForeignKey(d => d.SectionId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("questions_section_id_fkey");
            });

            modelBuilder.Entity<QuestionTypes>(entity =>
            {
                entity.ToTable("question_types");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.InsertedAt)
                    .HasColumnName("inserted_at")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("timestamp with time zone");
            });

            modelBuilder.Entity<RegionalBlocs>(entity =>
            {
                entity.ToTable("regional_blocs");

                entity.HasIndex(e => e.CountryId);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Acronym).HasColumnName("acronym");

                entity.Property(e => e.CountryId).HasColumnName("country_id");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.OtherAcronyms).HasColumnName("other_acronyms");

                entity.Property(e => e.OtherNames).HasColumnName("other_names");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.RegionalBlocs)
                    .HasForeignKey(d => d.CountryId);
            });

            modelBuilder.Entity<RegionMemberships>(entity =>
            {
                entity.HasKey(e => new { e.RegionId, e.ClientId });

                entity.ToTable("region_memberships");

                entity.HasIndex(e => e.ClientId);

                entity.Property(e => e.RegionId).HasColumnName("region_id");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.RegionMemberships)
                    .HasForeignKey(d => d.ClientId);

                entity.HasOne(d => d.Region)
                    .WithMany(p => p.RegionMemberships)
                    .HasForeignKey(d => d.RegionId);
            });

            modelBuilder.Entity<Regions>(entity =>
            {
                entity.ToTable("regions");

                entity.HasIndex(e => e.PersonId);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasColumnType("character varying");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.PersonId).HasColumnName("person_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("timestamp with time zone");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.Regions)
                    .HasForeignKey(d => d.PersonId);
            });

            modelBuilder.Entity<SavingsAccounts>(entity =>
            {
                entity.ToTable("savings_accounts");

                entity.HasIndex(e => e.AccountCurrencyId);

                entity.HasIndex(e => e.AccountOfficerId);

                entity.HasIndex(e => e.AccountOwnerId);

                entity.HasIndex(e => e.AccountState);

                entity.HasIndex(e => e.ActivationDate);

                entity.HasIndex(e => e.Active);

                entity.HasIndex(e => e.AgentContractId);

                entity.HasIndex(e => e.BranchAssignedId);

                entity.HasIndex(e => e.CentreAssignedId);

                entity.HasIndex(e => e.ClientId);

                entity.HasIndex(e => e.CreatedAt);

                entity.HasIndex(e => e.DateClosed);

                entity.HasIndex(e => e.Number)
                    .HasName("index_savings_accounts_on_number")
                    .IsUnique();

                entity.HasIndex(e => e.Primary);

                entity.HasIndex(e => e.SavingsProductId);

                entity.HasIndex(e => e.Title);

                entity.HasIndex(e => e.UpdatedAt);

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AccountCurrencyId).HasColumnName("account_currency_id");

                entity.Property(e => e.AccountOfficerId).HasColumnName("account_officer_id");

                entity.Property(e => e.AccountOwnerId).HasColumnName("account_owner_id");

                entity.Property(e => e.AccountState).HasColumnName("account_state");

                entity.Property(e => e.AccruedInterest).HasColumnName("accrued_interest");

                entity.Property(e => e.ActivationDate)
                    .HasColumnName("activation_date")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasColumnName("active")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.AgentContractId).HasColumnName("agent_contract_id");

                entity.Property(e => e.Balance).HasColumnName("balance");

                entity.Property(e => e.BalanceAsAt)
                    .HasColumnName("balance_as_at")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.BranchAssignedId).HasColumnName("branch_assigned_id");

                entity.Property(e => e.CentreAssignedId).HasColumnName("centre_assigned_id");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.DateClosed)
                    .HasColumnName("date_closed")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.FeesCollected).HasColumnName("fees_collected");

                entity.Property(e => e.InterestEarned).HasColumnName("interest_earned");

                entity.Property(e => e.Meta)
                    .HasColumnName("meta")
                    .HasColumnType("jsonb");

                entity.Property(e => e.Number).HasColumnName("number");

                entity.Property(e => e.Primary)
                    .HasColumnName("primary")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.SavingsProductId).HasColumnName("savings_product_id");

                entity.Property(e => e.Title).HasColumnName("title");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("timestamp with time zone");

                entity.HasOne(d => d.AccountCurrency)
                    .WithMany(p => p.SavingsAccounts)
                    .HasForeignKey(d => d.AccountCurrencyId);

                entity.HasOne(d => d.AccountOfficer)
                    .WithMany(p => p.SavingsAccounts)
                    .HasForeignKey(d => d.AccountOfficerId);

                entity.HasOne(d => d.AccountOwner)
                    .WithMany(p => p.SavingsAccounts)
                    .HasForeignKey(d => d.AccountOwnerId)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(d => d.AgentContract)
                    .WithMany(p => p.SavingsAccounts)
                    .HasForeignKey(d => d.AgentContractId);

                entity.HasOne(d => d.BranchAssigned)
                    .WithMany(p => p.SavingsAccounts)
                    .HasForeignKey(d => d.BranchAssignedId);

                entity.HasOne(d => d.CentreAssigned)
                    .WithMany(p => p.SavingsAccounts)
                    .HasForeignKey(d => d.CentreAssignedId);

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.SavingsAccounts)
                    .HasForeignKey(d => d.ClientId);

                entity.HasOne(d => d.SavingsProduct)
                    .WithMany(p => p.SavingsAccounts)
                    .HasForeignKey(d => d.SavingsProductId);
            });

            modelBuilder.Entity<SavingsProducts>(entity =>
            {
                entity.ToTable("savings_products");

                entity.HasIndex(e => e.AccountingMethod);

                entity.HasIndex(e => e.Active);

                entity.HasIndex(e => e.AllowAccountOpening);

                entity.HasIndex(e => e.AllowArbitraryFees);

                entity.HasIndex(e => e.AllowDeposits);

                entity.HasIndex(e => e.AllowOverdraft);

                entity.HasIndex(e => e.AllowSelfService);

                entity.HasIndex(e => e.AllowTransactions);

                entity.HasIndex(e => e.AllowWithdrawals);

                entity.HasIndex(e => e.CreatedAt);

                entity.HasIndex(e => e.CurrencyId);

                entity.HasIndex(e => e.ForCorporates);

                entity.HasIndex(e => e.ForGroups);

                entity.HasIndex(e => e.ForIndividuals);

                entity.HasIndex(e => e.InterestPaidIntoAccount);

                entity.HasIndex(e => e.IsBankingProduct);

                entity.HasIndex(e => e.IsCommissionProduct);

                entity.HasIndex(e => e.IsInsuranceProduct);

                entity.HasIndex(e => e.IsSettlementProduct);

                entity.HasIndex(e => e.Name);

                entity.HasIndex(e => e.ProductType);

                entity.HasIndex(e => e.UpdatedAt);

                entity.HasIndex(e => new { e.ClientId, e.Code })
                    .HasName("index_savings_products_on_code")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AccountingMethod).HasColumnName("accounting_method");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasColumnName("active")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.AllowAccountOpening).HasColumnName("allow_account_opening");

                entity.Property(e => e.AllowArbitraryFees).HasColumnName("allow_arbitrary_fees");

                entity.Property(e => e.AllowDeposits).HasColumnName("allow_deposits");

                entity.Property(e => e.AllowOverdraft).HasColumnName("allow_overdraft");

                entity.Property(e => e.AllowSelfService).HasColumnName("allow_self_service");

                entity.Property(e => e.AllowTransactions).HasColumnName("allow_transactions");

                entity.Property(e => e.AllowWithdrawals).HasColumnName("allow_withdrawals");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.Code).HasColumnName("code");

                entity.Property(e => e.CommissionPercentage).HasColumnName("commission_percentage");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.CurrencyId).HasColumnName("currency_id");

                entity.Property(e => e.DailyTransactionLimit).HasColumnName("daily_transaction_limit");

                entity.Property(e => e.DefaultOpeningBalance).HasColumnName("default_opening_balance");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.DormancyPeriodDays).HasColumnName("dormancy_period_days");

                entity.Property(e => e.ForCorporates).HasColumnName("for_corporates");

                entity.Property(e => e.ForGroups).HasColumnName("for_groups");

                entity.Property(e => e.ForIndividuals).HasColumnName("for_individuals");

                entity.Property(e => e.InterestCalculationBalance).HasColumnName("interest_calculation_balance");

                entity.Property(e => e.InterestPaidIntoAccount).HasColumnName("interest_paid_into_account");

                entity.Property(e => e.InterestPaymentPoint).HasColumnName("interest_payment_point");

                entity.Property(e => e.InterestRate).HasColumnName("interest_rate");

                entity.Property(e => e.IsBankingProduct).HasColumnName("is_banking_product");

                entity.Property(e => e.IsCommissionProduct).HasColumnName("is_commission_product");

                entity.Property(e => e.IsInsuranceProduct).HasColumnName("is_insurance_product");

                entity.Property(e => e.IsSettlementProduct).HasColumnName("is_settlement_product");

                entity.Property(e => e.MaxDepositAmount).HasColumnName("max_deposit_amount");

                entity.Property(e => e.MaxOpeningBalance).HasColumnName("max_opening_balance");

                entity.Property(e => e.MaxOverdraftLimit).HasColumnName("max_overdraft_limit");

                entity.Property(e => e.MaxWidthdrawalAmount).HasColumnName("max_widthdrawal_amount");

                entity.Property(e => e.MinDepositAmount).HasColumnName("min_deposit_amount");

                entity.Property(e => e.MinOpeningBalance).HasColumnName("min_opening_balance");

                entity.Property(e => e.MinWidthdrawalAmount).HasColumnName("min_widthdrawal_amount");

                entity.Property(e => e.MinimumBalance).HasColumnName("minimum_balance");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.PercentageCharge).HasColumnName("percentage_charge");

                entity.Property(e => e.ProductType).HasColumnName("product_type");

                entity.Property(e => e.TransactionThreshold).HasColumnName("transaction_threshold");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("timestamp with time zone");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.SavingsProducts)
                    .HasForeignKey(d => d.ClientId);

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.SavingsProducts)
                    .HasForeignKey(d => d.CurrencyId);
            });

            modelBuilder.Entity<SchemaMigrations>(entity =>
            {
                entity.HasKey(e => e.Version);

                entity.ToTable("schema_migrations");

                entity.Property(e => e.Version)
                    .HasColumnName("version")
                    .HasColumnType("character varying")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<ScreenTypes>(entity =>
            {
                entity.ToTable("screen_types");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.InsertedAt)
                    .HasColumnName("inserted_at")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("timestamp with time zone");
            });

            modelBuilder.Entity<ServiceProviders>(entity =>
            {
                entity.ToTable("service_providers");

                entity.HasIndex(e => e.CountryId);

                entity.HasIndex(e => e.LogoId);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CountryId).HasColumnName("country_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.LogoId).HasColumnName("logo_id");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.Tagline).HasColumnName("tagline");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("timestamp with time zone");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.ServiceProviders)
                    .HasForeignKey(d => d.CountryId);

                entity.HasOne(d => d.Logo)
                    .WithMany(p => p.ServiceProviders)
                    .HasForeignKey(d => d.LogoId);
            });

            modelBuilder.Entity<ServiceProviderships>(entity =>
            {
                entity.ToTable("service_providerships");

                entity.HasIndex(e => e.ServiceId);

                entity.HasIndex(e => e.ServiceProviderId);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.ServiceId).HasColumnName("service_id");

                entity.Property(e => e.ServiceProviderId).HasColumnName("service_provider_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("timestamp with time zone");

                entity.HasOne(d => d.Service)
                    .WithMany(p => p.ServiceProviderships)
                    .HasForeignKey(d => d.ServiceId);

                entity.HasOne(d => d.ServiceProvider)
                    .WithMany(p => p.ServiceProviderships)
                    .HasForeignKey(d => d.ServiceProviderId);
            });

            modelBuilder.Entity<Services>(entity =>
            {
                entity.ToTable("services");

                entity.HasIndex(e => e.Category);

                entity.HasIndex(e => e.Code);

                entity.HasIndex(e => e.CreatedAt);

                entity.HasIndex(e => e.Name);

                entity.HasIndex(e => e.UpdatedAt);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Branding).HasColumnName("branding");

                entity.Property(e => e.Category).HasColumnName("category");

                entity.Property(e => e.Code).HasColumnName("code");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("timestamp with time zone");
            });

            modelBuilder.Entity<Tasks>(entity =>
            {
                entity.ToTable("tasks");

                entity.HasIndex(e => e.BackOfficerAssignedId);

                entity.HasIndex(e => e.ClientId);

                entity.HasIndex(e => e.TaskCreatorId);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BackOfficerAssignedId).HasColumnName("back_officer_assigned_id");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.CompletedAt)
                    .HasColumnName("completed_at")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.DueAt)
                    .HasColumnName("due_at")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.TaskCreatorId).HasColumnName("task_creator_id");

                entity.Property(e => e.Title).HasColumnName("title");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("timestamp with time zone");

                entity.HasOne(d => d.BackOfficerAssigned)
                    .WithMany(p => p.TasksBackOfficerAssigned)
                    .HasForeignKey(d => d.BackOfficerAssignedId);

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.Tasks)
                    .HasForeignKey(d => d.ClientId);

                entity.HasOne(d => d.TaskCreator)
                    .WithMany(p => p.TasksTaskCreator)
                    .HasForeignKey(d => d.TaskCreatorId);
            });

            modelBuilder.Entity<Till>(entity =>
            {
                entity.ToTable("till");

                entity.HasIndex(e => e.ClientId);

                entity.HasIndex(e => e.OpenedById);

                entity.HasIndex(e => e.TellerId);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Balance).HasColumnName("balance");

                entity.Property(e => e.BalanceConstraint).HasColumnName("balance_constraint");

                entity.Property(e => e.BalanceDifference).HasColumnName("balance_difference");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.ClosedDate)
                    .HasColumnName("closed_date")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.ClosingBalance).HasColumnName("closing_balance");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.MaximumBalance).HasColumnName("maximum_balance");

                entity.Property(e => e.MinimumBalance).HasColumnName("minimum_balance");

                entity.Property(e => e.OpenedById).HasColumnName("opened_by_id");

                entity.Property(e => e.OpenedDate)
                    .HasColumnName("opened_date")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.OriginalTillId).HasColumnName("original_till_id");

                entity.Property(e => e.TellerId).HasColumnName("teller_id");

                entity.Property(e => e.TillState).HasColumnName("till_state");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.VaultAmount).HasColumnName("vault_amount");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.Till)
                    .HasForeignKey(d => d.ClientId);

                entity.HasOne(d => d.OpenedBy)
                    .WithMany(p => p.TillOpenedBy)
                    .HasForeignKey(d => d.OpenedById);

                entity.HasOne(d => d.Teller)
                    .WithMany(p => p.TillTeller)
                    .HasForeignKey(d => d.TellerId);
            });

            modelBuilder.Entity<TransactionAuthorizations>(entity =>
            {
                entity.ToTable("transaction_authorizations");

                entity.HasIndex(e => e.Active);

                entity.HasIndex(e => e.AuthorizationCode);

                entity.HasIndex(e => e.CreatedAt);

                entity.HasIndex(e => e.TransactionId);

                entity.HasIndex(e => e.UpdatedAt);

                entity.HasIndex(e => e.Verified);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.AuthorizationCode).HasColumnName("authorization_code");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.TransactionId).HasColumnName("transaction_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.Verified).HasColumnName("verified");

                entity.HasOne(d => d.Transaction)
                    .WithMany(p => p.TransactionAuthorizations)
                    .HasForeignKey(d => d.TransactionId);
            });

            modelBuilder.Entity<TransactionBatches>(entity =>
            {
                entity.ToTable("transaction_batches");

                entity.HasIndex(e => e.BackOfficerId);

                entity.HasIndex(e => e.BranchId);

                entity.HasIndex(e => e.ClientId);

                entity.HasIndex(e => e.CreatedAt);

                entity.HasIndex(e => e.CurrencyId);

                entity.HasIndex(e => e.DonationId);

                entity.HasIndex(e => e.FieldTellerId);

                entity.HasIndex(e => e.Reference);

                entity.HasIndex(e => e.State);

                entity.HasIndex(e => e.TransactionReportId);

                entity.HasIndex(e => e.UpdatedAt);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BackOfficerId).HasColumnName("back_officer_id");

                entity.Property(e => e.BranchId).HasColumnName("branch_id");

                entity.Property(e => e.CashOnHand).HasColumnName("cash_on_hand");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.CurrencyId).HasColumnName("currency_id");

                entity.Property(e => e.CustomerCount).HasColumnName("customer_count");

                entity.Property(e => e.DonationId).HasColumnName("donation_id");

                entity.Property(e => e.FieldTellerId).HasColumnName("field_teller_id");

                entity.Property(e => e.NetAmount).HasColumnName("net_amount");

                entity.Property(e => e.Reference).HasColumnName("reference");

                entity.Property(e => e.State).HasColumnName("state");

                entity.Property(e => e.TotalAmount)
                    .HasColumnName("total_amount")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TransactionCount).HasColumnName("transaction_count");

                entity.Property(e => e.TransactionDate)
                    .HasColumnName("transaction_date")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.TransactionReportId).HasColumnName("transaction_report_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("timestamp with time zone");

                entity.HasOne(d => d.BackOfficer)
                    .WithMany(p => p.TransactionBatches)
                    .HasForeignKey(d => d.BackOfficerId);

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.TransactionBatches)
                    .HasForeignKey(d => d.BranchId)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.TransactionBatches)
                    .HasForeignKey(d => d.ClientId);

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.TransactionBatches)
                    .HasForeignKey(d => d.CurrencyId);

                entity.HasOne(d => d.Donation)
                    .WithMany(p => p.TransactionBatches)
                    .HasForeignKey(d => d.DonationId);

                entity.HasOne(d => d.FieldTeller)
                    .WithMany(p => p.TransactionBatches)
                    .HasForeignKey(d => d.FieldTellerId)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(d => d.TransactionReport)
                    .WithMany(p => p.TransactionBatches)
                    .HasForeignKey(d => d.TransactionReportId)
                    .HasConstraintName("FK_transaction_batches_transaction_reports_transaction_report_i");
            });

            modelBuilder.Entity<TransactionBatchPostings>(entity =>
            {
                entity.ToTable("transaction_batch_postings");

                entity.HasIndex(e => e.CheckedAt);

                entity.HasIndex(e => e.CheckedById);

                entity.HasIndex(e => e.ClientId);

                entity.HasIndex(e => e.CreatedAt);

                entity.HasIndex(e => e.Error);

                entity.HasIndex(e => e.FailedTransactionId);

                entity.HasIndex(e => e.PostedAt);

                entity.HasIndex(e => e.PostedById);

                entity.HasIndex(e => e.State);

                entity.HasIndex(e => e.TransactionBatchId);

                entity.HasIndex(e => e.UpdatedAt);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CheckedAt)
                    .HasColumnName("checked_at")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.CheckedById).HasColumnName("checked_by_id");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.Error).HasColumnName("error");

                entity.Property(e => e.FailedTransactionId).HasColumnName("failed_transaction_id");

                entity.Property(e => e.PostedAt)
                    .HasColumnName("posted_at")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.PostedById).HasColumnName("posted_by_id");

                entity.Property(e => e.State).HasColumnName("state");

                entity.Property(e => e.TransactionBatchId).HasColumnName("transaction_batch_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("timestamp with time zone");

                entity.HasOne(d => d.CheckedBy)
                    .WithMany(p => p.TransactionBatchPostingsCheckedBy)
                    .HasForeignKey(d => d.CheckedById);

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.TransactionBatchPostings)
                    .HasForeignKey(d => d.ClientId);

                entity.HasOne(d => d.FailedTransaction)
                    .WithMany(p => p.TransactionBatchPostings)
                    .HasForeignKey(d => d.FailedTransactionId)
                    .HasConstraintName("FK_transaction_batch_postings_transactions_failed_transaction_i");

                entity.HasOne(d => d.PostedBy)
                    .WithMany(p => p.TransactionBatchPostingsPostedBy)
                    .HasForeignKey(d => d.PostedById);

                entity.HasOne(d => d.TransactionBatch)
                    .WithMany(p => p.TransactionBatchPostings)
                    .HasForeignKey(d => d.TransactionBatchId)
                    .HasConstraintName("FK_transaction_batch_postings_transaction_batches_transaction_b");
            });

            modelBuilder.Entity<TransactionDetails>(entity =>
            {
                entity.ToTable("transaction_details");

                entity.HasIndex(e => e.BranchId);

                entity.HasIndex(e => e.Channel);

                entity.HasIndex(e => e.ChequeImageId);

                entity.HasIndex(e => e.ChequeNumber);

                entity.HasIndex(e => e.CustomerId);

                entity.HasIndex(e => e.DonorId);

                entity.HasIndex(e => e.FarmerId);

                entity.HasIndex(e => e.FieldTellerId);

                entity.HasIndex(e => e.GeoCoordinateId);

                entity.HasIndex(e => e.LoanAccountId);

                entity.HasIndex(e => e.LoanProductId);

                entity.HasIndex(e => e.PaymentMode);

                entity.HasIndex(e => e.SavingsAccountId);

                entity.HasIndex(e => e.SavingsProductId);

                entity.HasIndex(e => e.ServiceId);

                entity.HasIndex(e => e.TillId);

                entity.HasIndex(e => e.TransactionAuthorizationId);

                entity.HasIndex(e => e.TransactionId)
                    .IsUnique();

                entity.HasIndex(e => e.TransactionPhoneNumberId);

                entity.HasIndex(e => new { e.GroupMemberPersonId, e.GroupMemberGroupId })
                    .HasName("IX_transaction_details_group_member_person_id_group_member_grou");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BranchId).HasColumnName("branch_id");

                entity.Property(e => e.Channel).HasColumnName("channel");

                entity.Property(e => e.ChequeImageId).HasColumnName("cheque_image_id");

                entity.Property(e => e.ChequeNumber).HasColumnName("cheque_number");

                entity.Property(e => e.CommissionId).HasColumnName("commission_id");

                entity.Property(e => e.CreditResponse).HasColumnName("credit_response");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.DebitResponse).HasColumnName("debit_response");

                entity.Property(e => e.DonorId).HasColumnName("donor_id");

                entity.Property(e => e.FarmerId).HasColumnName("farmer_id");

                entity.Property(e => e.FeeId).HasColumnName("fee_id");

                entity.Property(e => e.FieldTellerId).HasColumnName("field_teller_id");

                entity.Property(e => e.GeoCoordinateId).HasColumnName("geo_coordinate_id");

                entity.Property(e => e.GroupMemberGroupId).HasColumnName("group_member_group_id");

                entity.Property(e => e.GroupMemberPersonId).HasColumnName("group_member_person_id");

                entity.Property(e => e.LoanAccountId).HasColumnName("loan_account_id");

                entity.Property(e => e.LoanId).HasColumnName("loan_id");

                entity.Property(e => e.LoanProductId).HasColumnName("loan_product_id");

                entity.Property(e => e.Meta)
                    .HasColumnName("meta")
                    .HasColumnType("jsonb");

                entity.Property(e => e.PaymentMode).HasColumnName("payment_mode");

                entity.Property(e => e.SavingsAccountId).HasColumnName("savings_account_id");

                entity.Property(e => e.SavingsProductId).HasColumnName("savings_product_id");

                entity.Property(e => e.ServiceId).HasColumnName("service_id");

                entity.Property(e => e.TillId).HasColumnName("till_id");

                entity.Property(e => e.TransactionAuthorizationId).HasColumnName("transaction_authorization_id");

                entity.Property(e => e.TransactionId).HasColumnName("transaction_id");

                entity.Property(e => e.TransactionPhoneNumberId).HasColumnName("transaction_phone_number_id");

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.TransactionDetails)
                    .HasForeignKey(d => d.BranchId);

                entity.HasOne(d => d.ChequeImage)
                    .WithMany(p => p.TransactionDetails)
                    .HasForeignKey(d => d.ChequeImageId);

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.TransactionDetails)
                    .HasForeignKey(d => d.CustomerId);

                entity.HasOne(d => d.Donor)
                    .WithMany(p => p.TransactionDetails)
                    .HasForeignKey(d => d.DonorId);

                entity.HasOne(d => d.Farmer)
                    .WithMany(p => p.TransactionDetails)
                    .HasForeignKey(d => d.FarmerId);

                entity.HasOne(d => d.FieldTeller)
                    .WithMany(p => p.TransactionDetails)
                    .HasForeignKey(d => d.FieldTellerId);

                entity.HasOne(d => d.GeoCoordinate)
                    .WithMany(p => p.TransactionDetails)
                    .HasForeignKey(d => d.GeoCoordinateId);

                entity.HasOne(d => d.LoanAccount)
                    .WithMany(p => p.TransactionDetails)
                    .HasForeignKey(d => d.LoanAccountId);

                entity.HasOne(d => d.LoanProduct)
                    .WithMany(p => p.TransactionDetails)
                    .HasForeignKey(d => d.LoanProductId);

                entity.HasOne(d => d.SavingsAccount)
                    .WithMany(p => p.TransactionDetails)
                    .HasForeignKey(d => d.SavingsAccountId);

                entity.HasOne(d => d.SavingsProduct)
                    .WithMany(p => p.TransactionDetails)
                    .HasForeignKey(d => d.SavingsProductId);

                entity.HasOne(d => d.Service)
                    .WithMany(p => p.TransactionDetails)
                    .HasForeignKey(d => d.ServiceId);

                entity.HasOne(d => d.Till)
                    .WithMany(p => p.TransactionDetails)
                    .HasForeignKey(d => d.TillId);

                entity.HasOne(d => d.TransactionAuthorization)
                    .WithMany(p => p.TransactionDetails)
                    .HasForeignKey(d => d.TransactionAuthorizationId)
                    .HasConstraintName("FK_transaction_details_transaction_authorizations_transaction_a");

                entity.HasOne(d => d.Transaction)
                    .WithOne(p => p.TransactionDetails)
                    .HasForeignKey<TransactionDetails>(d => d.TransactionId);

                entity.HasOne(d => d.TransactionPhoneNumber)
                    .WithMany(p => p.TransactionDetails)
                    .HasForeignKey(d => d.TransactionPhoneNumberId)
                    .HasConstraintName("FK_transaction_details_phone_numbers_transaction_phone_number_i");

                entity.HasOne(d => d.GroupMember)
                    .WithMany(p => p.TransactionDetails)
                    .HasForeignKey(d => new { d.GroupMemberPersonId, d.GroupMemberGroupId })
                    .HasConstraintName("FK_transaction_details_group_membership_group_member_person_id_");
            });

            modelBuilder.Entity<TransactionReports>(entity =>
            {
                entity.ToTable("transaction_reports");

                entity.HasIndex(e => e.ClientId);

                entity.HasIndex(e => e.DocumentId);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.Current).HasColumnName("current");

                entity.Property(e => e.DocumentId).HasColumnName("document_id");

                entity.Property(e => e.Title).HasColumnName("title");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("timestamp with time zone");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.TransactionReports)
                    .HasForeignKey(d => d.ClientId);

                entity.HasOne(d => d.Document)
                    .WithMany(p => p.TransactionReports)
                    .HasForeignKey(d => d.DocumentId);
            });

            modelBuilder.Entity<Transactions>(entity =>
            {
                entity.ToTable("transactions");

                entity.HasIndex(e => e.BatchId);

                entity.HasIndex(e => e.ClientId);

                entity.HasIndex(e => e.CreatedAt);

                entity.HasIndex(e => e.CreditAccount);

                entity.HasIndex(e => e.CreditReceipt);

                entity.HasIndex(e => e.CurrencyId);

                entity.HasIndex(e => e.DebitAccount);

                entity.HasIndex(e => e.DebitReceipt);

                entity.HasIndex(e => e.Reference)
                    .IsUnique();

                entity.HasIndex(e => e.RelatedTransactionId)
                    .IsUnique();

                entity.HasIndex(e => e.ReversalTransactionId)
                    .IsUnique();

                entity.HasIndex(e => e.SequenceNumber);

                entity.HasIndex(e => e.ServiceId);

                entity.HasIndex(e => e.Signature)
                    .HasName("index_contributions_on_signature")
                    .IsUnique();

                entity.HasIndex(e => e.State);

                entity.HasIndex(e => e.Timestamp)
                    .HasName("index_contributions_on_collection_date");

                entity.HasIndex(e => e.TransactionType);

                entity.HasIndex(e => e.UpdatedAt);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.BatchId).HasColumnName("batch_id");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.CommissionAmount).HasColumnName("commission_amount");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.CreditAccount).HasColumnName("credit_account");

                entity.Property(e => e.CreditReceipt).HasColumnName("credit_receipt");

                entity.Property(e => e.CurrencyId).HasColumnName("currency_id");

                entity.Property(e => e.DebitAccount).HasColumnName("debit_account");

                entity.Property(e => e.DebitReceipt).HasColumnName("debit_receipt");

                entity.Property(e => e.FeeAmount).HasColumnName("fee_amount");

                entity.Property(e => e.GrossAmount).HasColumnName("gross_amount");

                entity.Property(e => e.InterestAmount).HasColumnName("interest_amount");

                entity.Property(e => e.Meta)
                    .HasColumnName("meta")
                    .HasColumnType("jsonb");

                entity.Property(e => e.Narration).HasColumnName("narration");

                entity.Property(e => e.OverDraftAmount).HasColumnName("over_draft_amount");

                entity.Property(e => e.OverdraftFeesAmount).HasColumnName("overdraft_fees_amount");

                entity.Property(e => e.OverdraftInterestAmount).HasColumnName("overdraft_interest_amount");

                entity.Property(e => e.Reference).HasColumnName("reference");

                entity.Property(e => e.RelatedTransactionId).HasColumnName("related_transaction_id");

                entity.Property(e => e.ReversalTransactionId).HasColumnName("reversal_transaction_id");

                entity.Property(e => e.SequenceNumber)
                    .HasColumnName("sequence_number")
                    .HasDefaultValueSql("nextval('\"TransactionSequence\"'::regclass)");

                entity.Property(e => e.ServiceId).HasColumnName("service_id");

                entity.Property(e => e.Signature).HasColumnName("signature");

                entity.Property(e => e.State).HasColumnName("state");

                entity.Property(e => e.Timestamp)
                    .HasColumnName("timestamp")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.TransactionType).HasColumnName("transaction_type");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("timestamp with time zone");

                entity.HasOne(d => d.Batch)
                    .WithMany(p => p.Transactions)
                    .HasForeignKey(d => d.BatchId);

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.Transactions)
                    .HasForeignKey(d => d.ClientId);

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.Transactions)
                    .HasForeignKey(d => d.CurrencyId);

                entity.HasOne(d => d.RelatedTransaction)
                    .WithOne(p => p.InverseRelatedTransaction)
                    .HasForeignKey<Transactions>(d => d.RelatedTransactionId);

                entity.HasOne(d => d.ReversalTransaction)
                    .WithOne(p => p.InverseReversalTransaction)
                    .HasForeignKey<Transactions>(d => d.ReversalTransactionId);

                entity.HasOne(d => d.Service)
                    .WithMany(p => p.Transactions)
                    .HasForeignKey(d => d.ServiceId);
            });

            modelBuilder.Entity<TransactionStates>(entity =>
            {
                entity.ToTable("transaction_states");

                entity.HasIndex(e => e.CreatedAt);

                entity.HasIndex(e => e.InitiatorId);

                entity.HasIndex(e => e.State);

                entity.HasIndex(e => e.Successful);

                entity.HasIndex(e => e.TransactionId);

                entity.HasIndex(e => e.UpdatedAt);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.InitiatorId).HasColumnName("initiator_id");

                entity.Property(e => e.Response).HasColumnName("response");

                entity.Property(e => e.State).HasColumnName("state");

                entity.Property(e => e.Successful).HasColumnName("successful");

                entity.Property(e => e.TransactionId).HasColumnName("transaction_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("timestamp with time zone");

                entity.HasOne(d => d.Initiator)
                    .WithMany(p => p.TransactionStates)
                    .HasForeignKey(d => d.InitiatorId);

                entity.HasOne(d => d.Transaction)
                    .WithMany(p => p.TransactionStates)
                    .HasForeignKey(d => d.TransactionId);
            });

            modelBuilder.Entity<UserActions>(entity =>
            {
                entity.ToTable("user_actions");

                entity.HasIndex(e => e.Action);

                entity.HasIndex(e => e.ActionSourceId);

                entity.HasIndex(e => e.ActionSourceType);

                entity.HasIndex(e => e.AuditLogId);

                entity.HasIndex(e => e.BackOfficerId);

                entity.HasIndex(e => e.CustomerId);

                entity.HasIndex(e => e.PaperTrailVersion);

                entity.HasIndex(e => e.Subject);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Action).HasColumnName("action");

                entity.Property(e => e.ActionSourceId).HasColumnName("action_source_id");

                entity.Property(e => e.ActionSourceType).HasColumnName("action_source_type");

                entity.Property(e => e.AuditLogId).HasColumnName("audit_log_id");

                entity.Property(e => e.BackOfficerId).HasColumnName("back_officer_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.PaperTrailVersion).HasColumnName("paper_trail_version");

                entity.Property(e => e.Subject).HasColumnName("subject");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("timestamp with time zone");

                entity.HasOne(d => d.AuditLog)
                    .WithMany(p => p.UserActions)
                    .HasForeignKey(d => d.AuditLogId);

                entity.HasOne(d => d.BackOfficer)
                    .WithMany(p => p.UserActions)
                    .HasForeignKey(d => d.BackOfficerId);

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.UserActions)
                    .HasForeignKey(d => d.CustomerId);
            });

            modelBuilder.Entity<UserGroupPrivileges>(entity =>
            {
                entity.ToTable("user_group_privileges");

                entity.HasIndex(e => e.ClientId);

                entity.HasIndex(e => e.CreatedAt);

                entity.HasIndex(e => e.Enabled);

                entity.HasIndex(e => e.GroupId);

                entity.HasIndex(e => e.PrivilegeId);

                entity.HasIndex(e => e.UpdatedAt);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.Enabled).HasColumnName("enabled");

                entity.Property(e => e.GroupId).HasColumnName("group_id");

                entity.Property(e => e.Meta)
                    .HasColumnName("meta")
                    .HasColumnType("jsonb");

                entity.Property(e => e.PrivilegeId).HasColumnName("privilege_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("timestamp with time zone");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.UserGroupPrivileges)
                    .HasForeignKey(d => d.ClientId);

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.UserGroupPrivileges)
                    .HasForeignKey(d => d.GroupId);

                entity.HasOne(d => d.Privilege)
                    .WithMany(p => p.UserGroupPrivileges)
                    .HasForeignKey(d => d.PrivilegeId);
            });

            modelBuilder.Entity<UsergroupPrivileges1>(entity =>
            {
                entity.ToTable("usergroup_privileges");

                entity.HasIndex(e => e.PrivilegeId)
                    .HasName("index_usergroup_privileges_on_privilege_id");

                entity.HasIndex(e => e.UserGroupId)
                    .HasName("index_usergroup_privileges_on_user_group_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.PrivilegeId).HasColumnName("privilege_id");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.Property(e => e.UserGroupId).HasColumnName("user_group_id");
            });

            modelBuilder.Entity<UserGroups>(entity =>
            {
                entity.ToTable("user_groups");

                entity.HasIndex(e => e.ClientId);

                entity.HasIndex(e => e.CreatedAt);

                entity.HasIndex(e => e.Name);

                entity.HasIndex(e => e.PartnerId)
                    .HasName("index_user_groups_on_partner_id");

                entity.HasIndex(e => e.UpdatedAt);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.PartnerId).HasColumnName("partner_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("timestamp with time zone");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.UserGroups)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.ToTable("users");

                entity.HasIndex(e => e.ClientId);

                entity.HasIndex(e => e.CreatedAt);

                entity.HasIndex(e => e.EmailId);

                entity.HasIndex(e => e.IsAgent);

                entity.HasIndex(e => e.IsBackofficer);

                entity.HasIndex(e => e.IsCustomer);

                entity.HasIndex(e => e.IsPlatformAdmin);

                entity.HasIndex(e => e.PersonId);

                entity.HasIndex(e => e.PhoneNumberId)
                    .HasName("index_users_on_phone_number_id");

                entity.HasIndex(e => e.ProfilePictureId);

                entity.HasIndex(e => e.ResetPasswordToken)
                    .HasName("index_users_on_reset_password_token")
                    .IsUnique();

                entity.HasIndex(e => e.State);

                entity.HasIndex(e => e.UnlockToken)
                    .HasName("index_users_on_unlock_token")
                    .IsUnique();

                entity.HasIndex(e => e.UpdatedAt);

                entity.HasIndex(e => e.UserGroupId);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.CurrentSignInAt)
                    .HasColumnName("current_sign_in_at")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.CurrentSignInIp).HasColumnName("current_sign_in_ip");

                entity.Property(e => e.EmailId).HasColumnName("email_id");

                entity.Property(e => e.EncryptedPassword)
                    .IsRequired()
                    .HasColumnName("encrypted_password")
                    .HasDefaultValueSql("''::character varying");

                entity.Property(e => e.FailedAttempts).HasColumnName("failed_attempts");

                entity.Property(e => e.HashedPin).HasColumnName("hashed_pin");

                entity.Property(e => e.IsAgent).HasColumnName("is_agent");

                entity.Property(e => e.IsBackofficer).HasColumnName("is_backofficer");

                entity.Property(e => e.IsClient).HasColumnName("is_client");

                entity.Property(e => e.IsCustomer).HasColumnName("is_customer");

                entity.Property(e => e.IsNotified)
                    .HasColumnName("is_notified")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.IsPlatformAdmin).HasColumnName("is_platform_admin");

                entity.Property(e => e.IsSuperClient).HasColumnName("is_super_client");

                entity.Property(e => e.LastSignInAt)
                    .HasColumnName("last_sign_in_at")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.LastSignInIp).HasColumnName("last_sign_in_ip");

                entity.Property(e => e.LockedAt)
                    .HasColumnName("locked_at")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.Meta)
                    .HasColumnName("meta")
                    .HasColumnType("jsonb");

                entity.Property(e => e.PasswordDigest).HasColumnName("password_digest");

                entity.Property(e => e.PersonId).HasColumnName("person_id");

                entity.Property(e => e.PhoneNumberId).HasColumnName("phone_number_id");

                entity.Property(e => e.ProfilePictureId).HasColumnName("profile_picture_id");

                entity.Property(e => e.RememberCreatedAt)
                    .HasColumnName("remember_created_at")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.ResetPasswordSentAt)
                    .HasColumnName("reset_password_sent_at")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.ResetPasswordToken).HasColumnName("reset_password_token");

                entity.Property(e => e.Role).HasColumnName("role");

                entity.Property(e => e.Salt).HasColumnName("salt");

                entity.Property(e => e.SignInCount).HasColumnName("sign_in_count");

                entity.Property(e => e.State).HasColumnName("state");

                entity.Property(e => e.Title).HasColumnName("title");

                entity.Property(e => e.UnlockToken).HasColumnName("unlock_token");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.UserGroupId).HasColumnName("user_group_id");

                entity.Property(e => e.Username).HasColumnName("username");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(d => d.Email)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.EmailId);

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.PersonId);

                entity.HasOne(d => d.ProfilePicture)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.ProfilePictureId);

                entity.HasOne(d => d.UserGroup)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.UserGroupId);
            });

            modelBuilder.Entity<UssdActions>(entity =>
            {
                entity.ToTable("ussd_actions");

                entity.HasIndex(e => e.ClientId);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("timestamp with time zone");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.UssdActions)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("ussd_actions_client_id_fkey");
            });

            modelBuilder.Entity<UssdFlows>(entity =>
            {
                entity.ToTable("ussd_flows");

                entity.HasIndex(e => e.ClientId);

                entity.HasIndex(e => e.InitialScreenId);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.InitialScreenId).HasColumnName("initial_screen_id");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("timestamp with time zone");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.UssdFlows)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("ussd_flows_client_id_fkey");

                entity.HasOne(d => d.InitialScreen)
                    .WithMany(p => p.UssdFlows)
                    .HasForeignKey(d => d.InitialScreenId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("ussd_flows_initial_screen_id_fkey");
            });

            modelBuilder.Entity<UssdScreenOptions>(entity =>
            {
                entity.ToTable("ussd_screen_options");

                entity.HasIndex(e => e.NextScreenId);

                entity.HasIndex(e => e.ScreenId);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.NextScreenId).HasColumnName("next_screen_id");

                entity.Property(e => e.Option).HasColumnName("option");

                entity.Property(e => e.ScreenId).HasColumnName("screen_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("timestamp with time zone");

                entity.HasOne(d => d.NextScreen)
                    .WithMany(p => p.UssdScreenOptionsNextScreen)
                    .HasForeignKey(d => d.NextScreenId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("ussd_screen_options_next_screen_id_fkey");

                entity.HasOne(d => d.Screen)
                    .WithMany(p => p.UssdScreenOptionsScreen)
                    .HasForeignKey(d => d.ScreenId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("ussd_screen_options_screen_id_fkey");
            });

            modelBuilder.Entity<UssdScreenResponses>(entity =>
            {
                entity.ToTable("ussd_screen_responses");

                entity.HasIndex(e => e.AnswerId);

                entity.HasIndex(e => e.CustomerId);

                entity.HasIndex(e => e.ScreenId);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AnswerId).HasColumnName("answer_id");

                entity.Property(e => e.AnswerText).HasColumnName("answer_text");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.ScreenId).HasColumnName("screen_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("timestamp with time zone");

                entity.HasOne(d => d.Answer)
                    .WithMany(p => p.UssdScreenResponses)
                    .HasForeignKey(d => d.AnswerId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("ussd_responses_answer_id_fkey");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.UssdScreenResponses)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("ussd_responses_customer_id_fkey");

                entity.HasOne(d => d.Screen)
                    .WithMany(p => p.UssdScreenResponses)
                    .HasForeignKey(d => d.ScreenId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("ussd_responses_screen_id_fkey");
            });

            modelBuilder.Entity<UssdScreens>(entity =>
            {
                entity.ToTable("ussd_screens");

                entity.HasIndex(e => e.ActionId);

                entity.HasIndex(e => e.ScreenTypeId);

                entity.HasIndex(e => e.UssdFlowId);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ActionId).HasColumnName("action_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.Meta)
                    .HasColumnName("meta")
                    .HasColumnType("jsonb");

                entity.Property(e => e.Required).HasColumnName("required");

                entity.Property(e => e.ScreenTypeId).HasColumnName("screen_type_id");

                entity.Property(e => e.Title).HasColumnName("title");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.UssdFlowId).HasColumnName("ussd_flow_id");

                entity.HasOne(d => d.Action)
                    .WithMany(p => p.UssdScreens)
                    .HasForeignKey(d => d.ActionId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("screens_action_id_fkey");

                entity.HasOne(d => d.ScreenType)
                    .WithMany(p => p.UssdScreens)
                    .HasForeignKey(d => d.ScreenTypeId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("screens_screen_type_id_fkey");

                entity.HasOne(d => d.UssdFlow)
                    .WithMany(p => p.UssdScreens)
                    .HasForeignKey(d => d.UssdFlowId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("screens_ussd_flow_id_fkey");
            });

            modelBuilder.HasSequence("AgentHiloSequence").IncrementsBy(10);

            modelBuilder.HasSequence("BackofficerHiloSequence").IncrementsBy(10);

            modelBuilder.HasSequence("BranchHiloSequence").IncrementsBy(10);

            modelBuilder.HasSequence("ClientHiloSequence").IncrementsBy(10);

            modelBuilder.HasSequence("contact_detail_id_seq");

            modelBuilder.HasSequence("ContractHiloSequence").IncrementsBy(10);

            modelBuilder.HasSequence("CustomerHiloSequence").IncrementsBy(10);

            modelBuilder.HasSequence("DeviceHiloSequence").IncrementsBy(10);

            modelBuilder.HasSequence("GroupHiloSequence").IncrementsBy(10);

            modelBuilder.HasSequence("JournalEntriesSequence");

            modelBuilder.HasSequence("LoanAccountHiloSequence").IncrementsBy(10);

            modelBuilder.HasSequence("LoanProductHiloSequence").IncrementsBy(10);

            modelBuilder.HasSequence("OrganizationHiloSequence").IncrementsBy(10);

            modelBuilder.HasSequence("PersonHiloSequence").IncrementsBy(10);

            modelBuilder.HasSequence("SavingsAccountHiloSequence").IncrementsBy(10);

            modelBuilder.HasSequence("SavingsProductHiloSequence").IncrementsBy(10);

            modelBuilder.HasSequence("TransactionSequence").StartsAt(100000000);

            modelBuilder.HasSequence("UserHiloSequence").IncrementsBy(10);
        }
    }
}
