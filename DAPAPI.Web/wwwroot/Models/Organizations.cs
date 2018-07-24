using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class Organizations
    {
        public long Id { get; set; }
        public long? AddressId { get; set; }
        public string BusinessName { get; set; }
        public string BusinessRegistrationNumber { get; set; }
        public long? ContactDetailsId { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Industry { get; set; }
        public long? ManagerId { get; set; }
        public string OrganizationType { get; set; }
        public string Sector { get; set; }
        public string TradeName { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
