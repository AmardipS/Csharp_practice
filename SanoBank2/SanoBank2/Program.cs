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

            acc.MakeDeposit(-500, DateTime.Now, "Negative");
            Console.WriteLine(acc.Balance);

            acc.MakeDeposit(200, DateTime.Now, "Save save");

            Console.WriteLine();


        }
    }
}
