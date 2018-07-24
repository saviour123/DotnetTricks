using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class People
    {
        public People()
        {
            Addresses = new HashSet<Addresses>();
            Agents = new HashSet<Agents>();
            Backofficers = new HashSet<Backofficers>();
            Beneficiaries = new HashSet<Beneficiaries>();
            Customers = new HashSet<Customers>();
            Donors = new HashSet<Donors>();
            EmploymentDetails = new HashSet<EmploymentDetails>();
            ExternalLinks = new HashSet<ExternalLinks>();
            Farmers = new HashSet<Farmers>();
            FingerPrints = new HashSet<FingerPrints>();
            GroupMembership = new HashSet<GroupMembership>();
            IdentityDocuments = new HashSet<IdentityDocuments>();
            MaritalDetails = new HashSet<MaritalDetails>();
            Notes = new HashSet<Notes>();
            Organizations = new HashSet<Organizations>();
            OtherBankAccount = new HashSet<OtherBankAccount>();
            Regions = new HashSet<Regions>();
            Users = new HashSet<Users>();
        }

        public int Id { get; set; }
        public int? ContactDetailsId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public int? EconomicDetailsId { get; set; }
        public string FirstName { get; set; }
        public string Gender { get; set; }
        public int? MaritalDetailsId { get; set; }
        public int? NationalityId { get; set; }
        public int? NextOfKinId { get; set; }
        public string OtherNames { get; set; }
        public string PlaceOfBirth { get; set; }
        public string Surname { get; set; }
        public string Title { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? Age { get; set; }
        public int? RegionId { get; set; }

        public Contacts ContactDetails { get; set; }
        public EconomicDetails EconomicDetails { get; set; }
        public MaritalDetails MaritalDetailsNavigation { get; set; }
        public Countries Nationality { get; set; }
        public Beneficiaries NextOfKin { get; set; }
        public Regions Region { get; set; }
        public ICollection<Addresses> Addresses { get; set; }
        public ICollection<Agents> Agents { get; set; }
        public ICollection<Backofficers> Backofficers { get; set; }
        public ICollection<Beneficiaries> Beneficiaries { get; set; }
        public ICollection<Customers> Customers { get; set; }
        public ICollection<Donors> Donors { get; set; }
        public ICollection<EmploymentDetails> EmploymentDetails { get; set; }
        public ICollection<ExternalLinks> ExternalLinks { get; set; }
        public ICollection<Farmers> Farmers { get; set; }
        public ICollection<FingerPrints> FingerPrints { get; set; }
        public ICollection<GroupMembership> GroupMembership { get; set; }
        public ICollection<IdentityDocuments> IdentityDocuments { get; set; }
        public ICollection<MaritalDetails> MaritalDetails { get; set; }
        public ICollection<Notes> Notes { get; set; }
        public ICollection<Organizations> Organizations { get; set; }
        public ICollection<OtherBankAccount> OtherBankAccount { get; set; }
        public ICollection<Regions> Regions { get; set; }
        public ICollection<Users> Users { get; set; }
    }
}
