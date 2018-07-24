using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class Privileges
    {
        public long Id { get; set; }
        public string PrivilegeType { get; set; }
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string Code { get; set; }
    }
}
