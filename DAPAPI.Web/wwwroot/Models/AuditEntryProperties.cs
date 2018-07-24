using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class AuditEntryProperties
    {
        public int AuditEntryPropertyID { get; set; }
        public int AuditEntryID { get; set; }
        public string NewValue { get; set; }
        public string OldValue { get; set; }
        public string PropertyName { get; set; }
        public string RelationName { get; set; }
    }
}
