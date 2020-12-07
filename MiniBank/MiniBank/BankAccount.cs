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
        private readonly decimal minimumBalance;
        // The constructor that takes 2 params uses : this(name, initialBalance, 0){} as its implementation.
        // : this() expression calls the other constructor, the one with three params.
        public BankAccount(string name, decimal initialBalance) : this(name, initialBalance, 0) { }

        public BankAccount(string name, decimal initialBalance, decimal minimumBalance)
        {
            // AUTO INCREMENTED ACCOUNT NUMBER
            this.Number = AccountNumberSeed.ToString();
            AccountNumberSeed++;

            this.Owner = name;
            this.minimumBalance = minimumBalance;
            // INITIAL BALANCE AS DEPOSIT
            if (initialBalance > 0)
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
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawal must be positive");
            }
            var overdraftTransaction = CheckWithdrawalLimit(Balance - amount < minimumBalance);
            var withdrawal = new Transaction(-amount, date, note);
            allTransactions.Add(withdrawal);
            if (overdraftTransaction != null)
                allTransactions.Add(overdraftTransaction);
        }

        protected virtual Transaction? CheckWithdrawalLimit(bool isOverdrawn)
        {
            if (isOverdrawn)
            {
                throw new InvalidOperationException("Not sufficient funds for this withdrawal");
            }
            else
            {
                return default;
            }
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
        public virtual void PerformMonthEndTransactions() { }

    }
}

    

