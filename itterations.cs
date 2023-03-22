using System;

namespace itterations
{
    public class Program
    {
        static void Main(string[] args)
        {

         for(int i=0;i<15;i++)
         {
            Console.WriteLine($"{i}");
         }


        }

        public static void meth1()
        {
         for(int i=-1000;i<1000;i++)
         {
            Console.WriteLine($"{i}");
         }
        }
        
        public static void meth2()
        {
         for(int i=3;i<999;i+=3)
         {
            Console.WriteLine($"{i}");
               Console.WriteLine($"{i}");
                  Console.WriteLine($"{i}");
         }
        }

          public static void meth3()
        {
           int a=Convert.ToInt32(Console.ReadLine());
           int b=Convert.ToInt32(Console.ReadLine());

         if(a==b)
         {
          Console.WriteLine("equal");  
         }
         else
         {
          Console.WriteLine("not equal"); 
         }
        }

        public static void meth4()
        {
        int a=Convert.ToInt32(Console.ReadLine());
         
         if(a<0)
         {
          Console.WriteLine("negative");  
         }
         else
         {
          Console.WriteLine("positive");  
         }
        }
    }
}

