using System;
using System.Security.Cryptography;

namespace ClassesTuts 
{
    
    class Program {

        public static void Main(string[] args) {

            var hello = DSAOpenSsl.Create();
            Console.WriteLine(DSAOpenSsl.Create());



//            var account = new BankAccount("saviour gidi", 50000);
//            account.MakeWithdrawal(500, DateTime.Now, "saviour", "rent payment");
//            Console.WriteLine(account.Balance);
//
//            account.MakeDeposit(100, DateTime.Now, "friend paid me back");
//            Console.WriteLine(account.Balance);
//
//            Console.WriteLine(account.GetAccountHistory());
//
            // try
            // {
            //     var InvalidAccount = new BankAccount("invalidl", -45);
            // }
            // catch (System.Exception e)
            // {
            //     Console.WriteLine("exception caught ");
            //     Console.WriteLine(e.ToString());
            // }
            
            /*test for negative balance */
            // try
            // {
            //     account.MakeWithdrawal(750, DateTime.Now, "saviour", "attemp to withdraw");
            // }
            // catch (System.Exception e)
            // {
            //     Console.WriteLine("Exception caught trying to overdraw");
            //     Console.WriteLine(e.ToString());
            // }

        }
    }
}
