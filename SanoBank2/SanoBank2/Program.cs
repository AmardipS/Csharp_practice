using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanoBank2
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount acc = new BankAccount("Amardip", 50000);
            Console.WriteLine($"New account {acc.Number} of customer {acc.Owner} has been activated with the initial balance of {acc.Balance}");
            
            // Test that the initial balances must be positive.
            try
            {
                var invalidAccount = new BankAccount("invalid", -55);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Exception caught creating account with negative balance");
                Console.WriteLine(e.ToString());
            }


            // Test for a negative balance.
            try
            {
                acc.MakeWithdrawal(70000, DateTime.Now, "Attempt to overdraw");
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine("Exception caught trying to overdraw");
                Console.WriteLine(e.ToString());
            }


            acc.MakeDeposit(200, DateTime.Now, "Save save");
            acc.MakeWithdrawal(2000, DateTime.Now, "PS5");

            Console.WriteLine(acc.GetAccountHistory());

            Console.WriteLine();


        }
    }
}
