using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Tennis_Ranklist
{
	internal class Program
	{
		static void Main(string[] args)
		{
			double tournamentNumbers = int.Parse(Console.ReadLine());
			double startingPoints = int.Parse(Console.ReadLine());

			double grishoPoints = startingPoints;
			double counter = 0;

			for (int i = 0; i < tournamentNumbers; i++)
			{
				string tournamentPoint = Console.ReadLine();

				switch (tournamentPoint)
				{
					case "W": grishoPoints += 2000; counter++; break;
					case "F": grishoPoints += 1200; break;
					case "SF": grishoPoints += 720; break;
				}
			}

			double averagePoints = (grishoPoints - startingPoints) / tournamentNumbers;
			double winningMargen = (counter * 100) / tournamentNumbers;

			Console.WriteLine($"Final points: {grishoPoints}");
			Console.WriteLine($"Average points: {(int)averagePoints}");
			Console.WriteLine($"{winningMargen:f2}%");
		}
	}
}
