

using System;
using System.Collections.Generic;
namespace bankaccount
{
class bankaccount 
{
 
 private double balance=0;

     public bankaccount()
     {

     }

     public double Balance()
     {
      return balance;
     }

     public void Deposit(double amount)
     {
     balance=amount;
     }



}
}

