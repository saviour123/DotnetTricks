using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class Partners
    {
        public long Id { get; set; }
        public long? AddressId { get; set; }
        public string Code { get; set; }
        public long? ContactDetailId { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Location { get; set; }
        public string Name { get; set; }
        public long? OrganizationId { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UserId { get; set; }
    }
}
