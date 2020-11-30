using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanoBank2
{
    class BankAccount
    {
        public int Number { get; set; }
        public string Owner { get; set; }
        public decimal Balance {
            get
            {
                decimal balance = 0;
                foreach (var item in allTransaction)
                {
                    balance += item.Amount;
                }
                return balance;
            }
        }

        private static int accountNumberSeed = 1234567890;

        public BankAccount(string name, decimal initialBalance)
        {
            this.Number = accountNumberSeed;
            accountNumberSeed++;

            this.Owner = name;
            MakeDeposit(initialBalance, DateTime.Now, "Initial Balance");
        }

        private List<Transaction> allTransaction = new List<Transaction>();


        public void MakeDeposit(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount must be positive.");
            }
            var deposit = new Transaction(amount, DateTime.Now, "Deposited amount.");
            allTransaction.Add(deposit);
        }
        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        {
            if (amount > Balance)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Not enough fund available.");
            }
            var withdraw = new Transaction(-amount, DateTime.Now, note);
            allTransaction.Add(withdraw);
        }

        // GET ACCOUNT HISTORY
        public string GetAccountHistory()
        {
            var report = new StringBuilder();

            decimal balance = 0;
            report.AppendLine("Date\t\tAmount\tBalance\tNote");

            foreach (var item in allTransaction)
            {
                balance += item.Amount;
                report.AppendLine($"{item.Date.ToShortDateString()}\t{item.Amount}\t{balance}\t{item.Note}");
            }

            return report.ToString();
        }

    }
}
