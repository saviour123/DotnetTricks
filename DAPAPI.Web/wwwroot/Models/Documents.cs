using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class Documents
    {
        public long Id { get; set; }
        public long ClientId { get; set; }
        public DateTime CreatedAt { get; set; }
        public long? CreatedById { get; set; }
        public string DocumentType { get; set; }
        public string FileName { get; set; }
        public string FileType { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
