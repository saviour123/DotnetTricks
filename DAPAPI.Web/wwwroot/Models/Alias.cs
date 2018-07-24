using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class Alias
    {
        public long Id { get; set; }
        public long ClientId { get; set; }
        public DateTime CreatedAt { get; set; }
        public long? CustomerId { get; set; }
        public long? LoanAccountId { get; set; }
        public string Name { get; set; }
        public long? OrganizationId { get; set; }
        public long? SavingsAccountId { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
