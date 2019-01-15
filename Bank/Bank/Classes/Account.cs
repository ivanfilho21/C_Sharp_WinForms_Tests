using Bank.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    class Account
    {
        public int Number { get; set; }
        public double Balance { get; set; }
        public Client Client { get; set; }

        public Account() { }

        public void Deposit(double amount)
        {
            Balance = amount;
        }

        public bool Withdraw(double amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
                return true;
            }
            return false;
        }
    }
}
