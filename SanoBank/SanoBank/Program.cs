using SanoBank.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanoBank
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("Josephine", 5000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} initial balance.");
            account.MakeWithdrawal(120, DateTime.Now, "Hammock");
            account.MakeDeposit(100, DateTime.Now, "Savings deposit.");
            Console.WriteLine(account.GetAccountHistory());

            Console.WriteLine($"Total Balance = {account.Balance}");

        }
    }
}
