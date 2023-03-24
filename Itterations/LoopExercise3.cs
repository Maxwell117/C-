using System;

namespace LoopExercise
{
	public class Program
	{

        public static void meth1()
        {
            for (int i = -1000; i < 1000; i++)
            {
                Console.WriteLine($"{i}");
            }
        }

        public static void meth2()
        {
            for (int i = 3; i < 999; i += 3)
            {
                Console.WriteLine($"{i}");
                Console.WriteLine($"{i}");
                Console.WriteLine($"{i}");
            }
        }

        public static void meth3()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            if (a == b)
            {
                Console.WriteLine("equal");
            }
            else
            {
                Console.WriteLine("not equal");
            }
        }

        public static void meth4(int n)
        {
      
            if(n%2==0)
            {
                Console.WriteLine("even");
            }
            else
            {
                Console.WriteLine("odd");
            }
        }

        public static void meth5(int n)
        {

            if(n>0)
            {
                Console.WriteLine("positive");
            }
            else
            {
                Console.WriteLine("negative");
            }
        }

        public static void meth6()
        {
            int age=Convert.ToInt32(Console.ReadLine());

            if (age>=18)
            {
                Console.WriteLine("You can vote");
            }
            else
            {
                Console.WriteLine("You cant vote");
            }
        }

        public static void meth7()
        {
            int a = Convert.ToInt32(Console.ReadLine());

            if (a>=-10&&a<=10)
            {
                Console.WriteLine("In range");
            }
            else
            {
                Console.WriteLine("Not in range");
            }
        }

        public static void meth8()
        {
            
           for(int i=1;i<12;i++)
            {
               for(int j=12;j>1;j--)
                {
                    Console.WriteLine(i * j);
                }
            }
          
        }

        static void main(string[] args)
		{
            meth1();
            meth2();
            meth3();
            meth4(6);
            meth5(2);
            meth6();
            meth7();
            meth8();
		}
	}
}