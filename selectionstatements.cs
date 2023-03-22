using System;

namespace MethodExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
         var n = int.Parse(Console.ReadLine());
         var slotmachine= new Random();
         int rand=slotmachine.Next(1,100);
         if(rand>n)
         {
         Console.WriteLine("Too high");
         }
         else if(rand<n)
         {
         Console.WriteLine("Too low");
         }
         else
         {
         Console.WriteLine("You found it!");
         }

		 Console.WriteLine("What is your favorite subject in school?");
	     var sub=Console.ReadLine();
		
	     switch(sub)
		 {
			 case "math":
				 Console.WriteLine("torture");
				 break;
		     case "english":
				 Console.WriteLine("drama");
				  break;
		     case "chemistry":
				 Console.WriteLine("breaking bad");
				  break;
			 case "art":
				 Console.WriteLine("fun");
				  break;
	         case "history":
				 Console.WriteLine("boring");
				  break;
			 default:
				  Console.WriteLine("Never heard of it");
		          break;
          }
		}
	}
}
