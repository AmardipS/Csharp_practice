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
            BankAccount acc = new BankAccount("Rajesh", 10000);
            acc.AmountDeposit(1000, DateTime.Now, "Salary");
            acc.AmountWithdrawal(1500, DateTime.Now, "Macbook");
            Console.WriteLine(acc.GetTransactionHistory());

            var giftCard = new GiftCardAccount("Gift card", 100, 50);
            giftCard.AmountWithdrawal(20, DateTime.Now, "Coffe");
            giftCard.AmountWithdrawal(50, DateTime.Now, "Groceries");
            giftCard.PerformMonthEndTransactions();
            Console.WriteLine(giftCard.GetTransactionHistory());

            var savings = new InterestEarningAccount("Savings account", 50000);
            savings.AmountDeposit(10000, DateTime.Now, "Monthly savings");
            savings.AmountWithdrawal(50000, DateTime.Now, "For my new house.");
            savings.PerformMonthEndTransactions();
            Console.WriteLine(savings.GetTransactionHistory());

            var lineOfCredit = new LineOfCreditAccount("line of credit", 0, 2000);
            // How much is too much to borrow?
            lineOfCredit.AmountWithdrawal(1000m, DateTime.Now, "Take out monthly advance");
            lineOfCredit.AmountDeposit(50m, DateTime.Now, "Pay back small amount");
            lineOfCredit.AmountWithdrawal(5000m, DateTime.Now, "Emergency funds for repairs");
            lineOfCredit.AmountDeposit(150m, DateTime.Now, "Partial restoration on repairs");
            lineOfCredit.PerformMonthEndTransactions();
            Console.WriteLine(lineOfCredit.GetTransactionHistory());
        }
    }
}
