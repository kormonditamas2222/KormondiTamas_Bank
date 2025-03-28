using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    internal class CreditAccount : BankAccount
    {
        double creditLimit;
        public CreditAccount(Owner owner, double creditLimit) : base(owner)
        {
            this.creditLimit = creditLimit;
        }

        public double CreditLimit { get => creditLimit; }

        public override bool Withdraw(double amount)
        {
            if (Balance - amount < creditLimit)
            {
                Balance -= amount;
                return true;
            }
            return false;
        }
    }
}
