using System;
using System.Collections.Generic;
namespace bankaccount
{
    class bankaccount
    {

        private double balance = 0;

        public bankaccount()
        {

        }

        public double GetBalance()
        {
            return balance;
        }

        public void SetBalance(double b)
        {
            balance = b;
        }

  
        public void Deposit(double amount)
        {
            balance += amount;
        }
    }
}
