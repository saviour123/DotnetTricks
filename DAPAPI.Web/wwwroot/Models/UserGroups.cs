using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class UserGroups
    {
        public long Id { get; set; }
        public long? ClientId { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Name { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string Description { get; set; }
        public int? PartnerId { get; set; }
    }
}
