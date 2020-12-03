using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniBank
{
    class GiftCardAccount : BankAccount
    {
        private decimal _monthlyDeposit = 0;
        public GiftCardAccount(string name, decimal initialBalance, decimal monthlyDeposit = 0) : base(name, initialBalance) 
            => _monthlyDeposit = monthlyDeposit;

        public override void PerformMonthEndTransactions()
        {
            if (_monthlyDeposit > 0)
            {
                AmountDeposit(_monthlyDeposit, DateTime.Now, "Add monthly deposit.");
            }
        }
    }
}
