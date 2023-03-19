using system;
namespace MethodExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
           
 
            Console.writeline("please enter 2 numbers");
            string a=console.readline();
            string b=console.readline();
            int reala=convert.Toint32(a);
            int realb=convert.Toint32(b);
            int result= add(a,b);
            int result2= mult(a,b);
             
            public static int add(int a,int b)
            {
            return a+b;
            }

            public static int mult(int a,int b)
            {
            return a*b;
            }
           
        }
    }
}
