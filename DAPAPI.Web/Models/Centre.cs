using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class Centre
    {
        public Centre()
        {
            LoanAccounts = new HashSet<LoanAccounts>();
            Notes = new HashSet<Notes>();
            SavingsAccounts = new HashSet<SavingsAccounts>();
        }

        public int Id { get; set; }
        public bool Active { get; set; }
        public int? AssignedToBranchId { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Name { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public Branches AssignedToBranch { get; set; }
        public ICollection<LoanAccounts> LoanAccounts { get; set; }
        public ICollection<Notes> Notes { get; set; }
        public ICollection<SavingsAccounts> SavingsAccounts { get; set; }
    }
}
