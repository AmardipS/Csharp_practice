using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniBank
{
    class BankAccount
    {
        public string Number { get; set; }
        public string Owner { get; set; }
        public decimal Balance {
            get
            {
                decimal balance = 0;
                foreach (var item in allTransactions)
                {
                    balance += item.Amount;
                }
                return balance;
            }
        }

        int AccountNumberSeed = 1234567890;

        public BankAccount(string name, decimal initialBalance)
        {
            // AUTO INCREMENTED ACCOUNT NUMBER
            this.Number = AccountNumberSeed.ToString();
            AccountNumberSeed++;

            this.Owner = name;
            // INITIAL BALANCE AS DEPOSIT
            AmountDeposit(initialBalance, DateTime.Now, "Initial Deposit");
        }

        // CREATING TRANSACTIONS LIST
        List<Transaction> allTransactions = new List<Transaction>();

        // DEPOSIT
        public void AmountDeposit(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Deposit amount must be positive value.");
            }
            allTransactions.Add(new Transaction(amount, DateTime.Now, note));
        }

        // WITHDRAW
        public void AmountWithdrawal(decimal amount, DateTime date, string note)
        {
            if (amount > Balance)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Not enough fund.");
            }
            allTransactions.Add(new Transaction(-amount, DateTime.Now, note));
        }

        // GET ALL TRANSACTIONS
        public string GetTransactionHistory()
        {
            var report = new StringBuilder();
            report.AppendLine("Date\t\tAmount\tBalance\tNote");
            decimal balance = 0;

            foreach (var item in allTransactions)
            {
                balance += item.Amount;
                report.AppendLine($"{item.Date.ToShortDateString()}\t{item.Amount}\t{balance}\t{item.Note}");
            }

            return report.ToString();
        }

        // CALCULATION AT THE END OF THE MONTH
        public virtual void PerformMonthEndTransactions()
        {

        }


    }
}
