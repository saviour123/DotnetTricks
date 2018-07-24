using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class Alias
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public DateTime CreatedAt { get; set; }
        public int? CustomerId { get; set; }
        public int? LoanAccountId { get; set; }
        public string Name { get; set; }
        public int? OrganizationId { get; set; }
        public int? SavingsAccountId { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public Clients Client { get; set; }
        public Customers Customer { get; set; }
        public LoanAccounts LoanAccount { get; set; }
        public Organizations Organization { get; set; }
        public SavingsAccounts SavingsAccount { get; set; }
    }
}
