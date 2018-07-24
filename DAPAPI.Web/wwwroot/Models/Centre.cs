using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class Centre
    {
        public long Id { get; set; }
        public bool Active { get; set; }
        public long? AssignedToBranchId { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Name { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
