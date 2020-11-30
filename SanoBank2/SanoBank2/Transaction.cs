using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanoBank2
{
    class Transaction
    {
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public string Note { get; set; }


        public Transaction(decimal amount, DateTime date, string note) {
            this.Amount = amount;
            this.Date = date;
            this.Note = note;
        }

        public static implicit operator Transaction(List<Transaction> v)
        {
            throw new NotImplementedException();
        }
    }
}
