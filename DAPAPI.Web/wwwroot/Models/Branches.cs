using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class Branches
    {
        public Branches()
        {
            InverseParentBranch = new HashSet<Branches>();
        }

        public long Id { get; set; }
        public bool? Active { get; set; }
        public long ClientId { get; set; }
        public string BranchCode { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsHeadOffice { get; set; }
        public bool IsSubBranch { get; set; }
        public string Name { get; set; }
        public long? ParentBranchId { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public Branches ParentBranch { get; set; }
        public ICollection<Branches> InverseParentBranch { get; set; }
    }
}
