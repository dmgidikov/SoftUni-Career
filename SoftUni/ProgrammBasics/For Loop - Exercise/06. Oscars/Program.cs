using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Oscars
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string actorName = Console.ReadLine();
			double academyPoints = double.Parse(Console.ReadLine());
			int gudges = int.Parse(Console.ReadLine());

			double score = academyPoints;

			for (int i = 0; i < gudges; i++)
			{
				string currentDudge = Console.ReadLine();
				double points = double.Parse(Console.ReadLine());

				score += (currentDudge.Length * points) / 2;

				if (score >= 1250.5)
				{
					Console.WriteLine($"Congratulations, {actorName} got a nominee for leading role with {score:f1}!");
					break;
				}
			}

			if (score < 1250.5)
			{
				Console.WriteLine($"Sorry, {actorName} you need {1250.5 - score:f1} more!");
			}
		}
	}
}
