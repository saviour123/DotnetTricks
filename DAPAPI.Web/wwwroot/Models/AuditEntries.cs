using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class AuditEntries
    {
        public int AuditEntryID { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string EntitySetName { get; set; }
        public string EntityTypeName { get; set; }
        public int State { get; set; }
        public string StateName { get; set; }
    }
}
