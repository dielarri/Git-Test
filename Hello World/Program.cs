using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_World
{
	class Program
	{
		static void Main(string[] args)
		{
			var random = new Random();

			int answer = random.Next(101);

			Console.WriteLine("Im thinking about a number between 0 and 100");
			int guess;
			guess = int.Parse(Console.ReadLine());
			
			Console.WriteLine("Your guess is " + guess);

			bool win = false;
			while (!win) {
				if (guess == answer)
				{
					win = true;
				}
				if (guess > answer)
				{
					Console.WriteLine("Too High");
					Console.WriteLine("Try Again");
					guess = int.Parse(Console.ReadLine());
				}
				if (guess < answer)
				{
					Console.WriteLine("Too Low");
					Console.WriteLine("Try Again");
					guess = int.Parse(Console.ReadLine());
				}
			}

			Console.WriteLine("The correct answer is " + answer);

			Console.ReadLine();

		}
	}
}
