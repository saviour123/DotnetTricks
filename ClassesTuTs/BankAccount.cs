using System;
using System.Collections.Generic;

namespace ClassesTuts
{
    public class BankAccount
    {
        private List<Transaction> allTransactions = new List<Transaction>();

        public string Number { get; }
        public string Owner { get; set; }

        // how we get our balance.. history of all transactions
        public decimal Balance
        { 
            get 
            {
                decimal balance = 0;
                foreach(var item in allTransactions)
                    balance += item.Amount;
                return balance;
            }
        }


        private static int accountNumberSeed = 1234567890;
        
        public void MakeDeposit(decimal amount, DateTime date, string note){
            if (amount <= 0)
                throw new ArgumentOutOfRangeException(nameof(amount), "amount of deposit much be possitive");
            var deposit = new Transaction(amount, date, note);
            allTransactions.Add(deposit);
        }

        public void MakeWithdrawal(decimal amount, DateTime date, string payee, string note){

            if (amount <= 0)
                throw new ArgumentOutOfRangeException(nameof(amount), "amount of withdrawal cannot be less than zero.");
            if (Balance - amount < 0)
                throw new InvalidOperationException("Not sufficient funds for this transaction");
            var withdrawal = new Transaction(-amount, date, note);
            allTransactions.Add(withdrawal);
        }

        public string GetAccountHistory()
        {
            var report = new System.Text.StringBuilder();
            
            report.AppendLine("Date\t\tAmount\tNote");

            foreach (var item in allTransactions)
                report.AppendLine($"{item.Date.ToShortDateString()}\t{item.Amount}\t{item.Notes}");
            
            return report.ToString();
        }

        // constructor class
        public BankAccount(string name, decimal initialBalance){
            this.Number = accountNumberSeed.ToString();
            accountNumberSeed++;
            
            this.Owner = name;
            MakeDeposit(initialBalance, DateTime.Now, "InitialBalance");
        }
    
    }

}