using System;
namespace bankaccount
{
    class Program
    {
        static void Main(string[] args)
        {
            bankaccount bob = new bankaccount();
            bob.SetBalance(500);
            Console.WriteLine(bob.GetBalance());

            bob.Deposit(100);
        }
    }
}
