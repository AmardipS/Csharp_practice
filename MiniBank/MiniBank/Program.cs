using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniBank
{
    class Program
    {
        static void Main(string[] args)
        {
            // BankAccount class
            // Transaction class
            // AmountWithdraw method
            // AmountDeposit method
            // Create Transaction type list
            // GetTransactionHistory method

            BankAccount acc = new BankAccount("Rajesh", 10000);
            acc.AmountDeposit(1000, DateTime.Now, "Salary");
            acc.AmountWithdrawal(1500, DateTime.Now, "Macbook");
            Console.WriteLine(acc.Balance);
            Console.WriteLine(acc.GetTransactionHistory());
        }
    }
}
