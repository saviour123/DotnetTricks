using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class OtherBankAccount
    {
        public int Id { get; set; }
        public long? AccountCurrencyId { get; set; }
        public string AccountNumber { get; set; }
        public string AccountType { get; set; }
        public string Branch { get; set; }
        public DateTime DateOpened { get; set; }
        public string InstitutionName { get; set; }
        public long? PersonId { get; set; }
    }
}
