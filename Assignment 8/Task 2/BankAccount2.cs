using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal partial class BankAccount
    {
        public void TransferFunds(BankAccount bankAccount, Currency amount)
        {
            bankAccount._currency.amount += amount.amount;
            this._currency.amount -= amount.amount;
        }
    }
}
