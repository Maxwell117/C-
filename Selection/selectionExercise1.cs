using System;

namespace MethodExercise
{
	public class Program
	{
		static void main(string[] args)
		{
			var n = int.Parse(Console.ReadLine());
			var slotmachine = new Random();
			Console.WriteLine("Please enter a number");
			int rand = slotmachine.Next(1, 100);
			if (rand > n)
			{
				Console.WriteLine("Too high");
			}
			else if (rand < n)
			{
				Console.WriteLine("Too low");
			}
			else
			{
				Console.WriteLine("You found it!");
			}
		}
	}
}