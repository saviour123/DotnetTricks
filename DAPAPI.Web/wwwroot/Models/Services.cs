using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class Services
    {
        public long Id { get; set; }
        public string Branding { get; set; }
        public string Category { get; set; }
        public string Code { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Name { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
