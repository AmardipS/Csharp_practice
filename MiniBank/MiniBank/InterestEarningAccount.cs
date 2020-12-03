using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniBank
{
    class InterestEarningAccount : BankAccount
    {

        public InterestEarningAccount(string name, decimal initialBalance) : base(name, initialBalance)
        {

        }

        public override void PerformMonthEndTransactions()
        {
            if (Balance > 500m)
            {
                var interest = Balance * 0.2m;
                AmountDeposit(interest, DateTime.Now, "Apply monthly interest.");
            }
        }
    }
}
