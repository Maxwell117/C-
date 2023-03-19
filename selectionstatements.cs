using system;
using random;
namespace MethodExercise
{
    public class Program
    {
        static void Main(string[] args)
        {

         int slotmachine=new random();
         int rand=slotmachine.Next(1,100);
         int n=5;
         if(rand>n)
         {
         Console.writeline("Too high");
         }
         else if(rand<n)
         {
         Console.writeline("Too low");
         }
         else
         {
         Console.writeline("You found it!");
         }

        }
    }
}
