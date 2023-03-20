using system;
using System.Collections.Generic;
namespace bank
{
class bankaccount
{
     private double balance=0;

     public bankaccount()
     {

     }

     public double Balance()_
     {
      return balance;
     }

     public void Deposit(double amount)
     {
     balance=amount;
     }
  
}


    public class Program
    {
        static void Main(string[] args)
        {
        bankaccount bob=new bankaccount();
        bob.balance=300;
        
        bob.deposit(500);

        }
     
    }
}
