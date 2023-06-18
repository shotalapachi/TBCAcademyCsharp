using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    public struct Currency
    {
        public string cur { get; }
        public double amount { get; set; }

        public Currency()
        {
            cur = "USD";
            amount = 0;
        }
    }

    internal partial class BankAccount
    {
        private string? _accountNumber;
        private string? _accountHolderName;
        private Currency _currency;
    
        public string? AccountNumber { get; set; }
        public string? AccountHolderName { set; get; }
        public Currency Currency { get { return _currency; } set { _currency = value; } }

        public void Deposit(Currency currency)
        {
            if (this._currency.cur == currency.cur)
            {
                this._currency.amount += currency.amount;
            }
        }

        public void Withdraw(Currency currency)
        {
            if (_currency.cur == currency.cur && this._currency.amount >= currency.amount)
                this._currency.amount -= currency.amount;
        }

        public double BalanceCheck()
        {
            return this._currency.amount;
        }
    }
}
