using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class Currencies
    {
        public Currencies()
        {
            Clients = new HashSet<Clients>();
            ExchangeRatesFromCurrency = new HashSet<ExchangeRates>();
            ExchangeRatesToCurrency = new HashSet<ExchangeRates>();
            GlAccounts = new HashSet<GlAccounts>();
            JournalEntries = new HashSet<JournalEntries>();
            JournalPostings = new HashSet<JournalPostings>();
            LoanAccounts = new HashSet<LoanAccounts>();
            LoanProducts = new HashSet<LoanProducts>();
            OtherBankAccount = new HashSet<OtherBankAccount>();
            SavingsAccounts = new HashSet<SavingsAccounts>();
            SavingsProducts = new HashSet<SavingsProducts>();
            TransactionBatches = new HashSet<TransactionBatches>();
            Transactions = new HashSet<Transactions>();
        }

        public int Id { get; set; }
        public string Code { get; set; }
        public int? CountryId { get; set; }
        public string Name { get; set; }
        public string Symbol { get; set; }

        public Countries Country { get; set; }
        public ICollection<Clients> Clients { get; set; }
        public ICollection<ExchangeRates> ExchangeRatesFromCurrency { get; set; }
        public ICollection<ExchangeRates> ExchangeRatesToCurrency { get; set; }
        public ICollection<GlAccounts> GlAccounts { get; set; }
        public ICollection<JournalEntries> JournalEntries { get; set; }
        public ICollection<JournalPostings> JournalPostings { get; set; }
        public ICollection<LoanAccounts> LoanAccounts { get; set; }
        public ICollection<LoanProducts> LoanProducts { get; set; }
        public ICollection<OtherBankAccount> OtherBankAccount { get; set; }
        public ICollection<SavingsAccounts> SavingsAccounts { get; set; }
        public ICollection<SavingsProducts> SavingsProducts { get; set; }
        public ICollection<TransactionBatches> TransactionBatches { get; set; }
        public ICollection<Transactions> Transactions { get; set; }
    }
}
