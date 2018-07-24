using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class Branches
    {
        public Branches()
        {
            Activities = new HashSet<Activities>();
            AgentContracts = new HashSet<AgentContracts>();
            Backofficers = new HashSet<Backofficers>();
            Centre = new HashSet<Centre>();
            Customers = new HashSet<Customers>();
            GlAccounts = new HashSet<GlAccounts>();
            InverseParentBranch = new HashSet<Branches>();
            LoanAccounts = new HashSet<LoanAccounts>();
            SavingsAccounts = new HashSet<SavingsAccounts>();
            TransactionBatches = new HashSet<TransactionBatches>();
            TransactionDetails = new HashSet<TransactionDetails>();
        }

        public int Id { get; set; }
        public bool? Active { get; set; }
        public int ClientId { get; set; }
        public string BranchCode { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsHeadOffice { get; set; }
        public bool IsSubBranch { get; set; }
        public string Name { get; set; }
        public int? ParentBranchId { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public Clients Client { get; set; }
        public Branches ParentBranch { get; set; }
        public BranchConfigurations BranchConfigurations { get; set; }
        public ICollection<Activities> Activities { get; set; }
        public ICollection<AgentContracts> AgentContracts { get; set; }
        public ICollection<Backofficers> Backofficers { get; set; }
        public ICollection<Centre> Centre { get; set; }
        public ICollection<Customers> Customers { get; set; }
        public ICollection<GlAccounts> GlAccounts { get; set; }
        public ICollection<Branches> InverseParentBranch { get; set; }
        public ICollection<LoanAccounts> LoanAccounts { get; set; }
        public ICollection<SavingsAccounts> SavingsAccounts { get; set; }
        public ICollection<TransactionBatches> TransactionBatches { get; set; }
        public ICollection<TransactionDetails> TransactionDetails { get; set; }
    }
}
