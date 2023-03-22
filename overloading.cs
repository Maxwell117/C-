using System;

namespace overloading
{
    public class Program
    {
        static void Main(string[] args)
        {
          int a=add(1,5);
            Console.WriteLine(a);
         decimal b = add(0.5m,0.3m);
         Console.WriteLine(b);
          add(1,5,true);
        
        }

        static int add(int x, int y)
        {
        return x + y;
        }

        static decimal add(decimal x, decimal y)
        {
        return x + y;
        }

        static void add(int x, int y,bool flag)
        {
             int z=x+y;
            if(flag==true&&z==1)
            {
            Console.WriteLine(z+"dollar");
            }
            else
            {
                Console.WriteLine(z+"dollars");
            }

        }

    }
}

