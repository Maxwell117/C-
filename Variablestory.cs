using System;
namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
           
            string s;
            string ss;
            int age;
            string place;
 
            Console.WriteLine("Please enter your name,age,a decimal and your best friend's name");
            s= Console.ReadLine();
           age=Convert.ToInt32(Console.ReadLine());
            place=Console.ReadLine();
           ss= Console.ReadLine();
            
            Console.WriteLine(s+" age" + age + "met "+ss+"at the "+place);
           
        }
    }
}
