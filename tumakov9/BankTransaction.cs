using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tumakov9
{
    internal class BankTransaction
    {
        public readonly double sum;
        public readonly DateTime date;
        public BankTransaction()
        {

        }
        public BankTransaction(double sum)
        {
            this.sum = sum;
            date = DateTime.Now;
        }
    }
}
