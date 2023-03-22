using System;
namespace MethodExercise
{
    public class Program
    {
            public static int add(int a,int b)
            {
            return a+b;
            }

            public static int mult(int a,int b)
            {
            return a*b;
            }
            
            public static int sub(int a,int b)
            {
            return a-b;
            }
            
            public static double div(int a,int b)
            {
            return a/b;
            }
            
            public static double mod(int a,int b)
            {
            return a%b;
            }
        
        static void Main(string[] args)
        {
        
            Console.WriteLine("please enter 2 numbers");
            var a=Convert.ToInt32(Console.ReadLine());
            var b=Convert.ToInt32(Console.ReadLine());
      
            var result= add(a,b);
            Console.WriteLine(result);
            var result2= mult(a,b);
              Console.WriteLine(result2);
            var result3= sub(a,b);
              Console.WriteLine(result3);
            var result4= mod(a,b);
               Console.WriteLine(result4);
            var result5= div(a,b);
               Console.WriteLine(result5);
            
             
        }
    }
}
