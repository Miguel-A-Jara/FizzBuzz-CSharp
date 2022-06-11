using System;

namespace FizzBuzz
{
	internal class Program
	{
		static void Main(string[] args)
		{
			for (int i = 1; i <= 100; i++)
			{
				/*	Solution 1	*/
				Console.Write(i + " ");

				if (i % 3 == 0)
				{
					Console.Write("Fizz");
				}

				if (i % 5 == 0)
				{
					Console.Write("Buzz");
				}

				Console.WriteLine();

				/*	Solution 2	*/
				Console.WriteLine($"{i} {(i % 3 == 0 ? "Fizz" : "")}{(i % 5 == 0 ? "Buzz" : "")}");
			}
		}
	}
}
