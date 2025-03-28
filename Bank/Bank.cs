using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    internal class Bank
    {
        BankAccount[] accounts;
        public Bank(int maxAccountCount) 
        {
            accounts = new BankAccount[maxAccountCount];
        }
        public BankAccount NewAccount(Owner owner, double creditLimit)
        {
            if (creditLimit == 0)
            {
                return new SavingsAccount(owner);
            }
            return new CreditAccount(owner, creditLimit);
        }
        public double TotalBalance(Owner owner)
        {
            return accounts.Sum(account => account.Balance);
        }
        public BankAccount MaximalBalanceAccount(Owner owner) 
        {
            double maxBalance = accounts.Max(account => account.Balance);
            foreach (var item in accounts)
            {
                if (item.Balance == maxBalance)
                {
                    return item;
                }
            }
            return accounts[0];
        }
        public double TotalCreditLimit()
        {
            double osszeg = 0;
            foreach (var item in accounts)
            {
                if (item is CreditAccount)
                {
                    osszeg += (item as CreditAccount).CreditLimit;
                }
            }
            return osszeg;
        }
    }
}
