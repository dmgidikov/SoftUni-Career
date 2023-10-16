using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Journey
{
	internal class Program
	{
		static void Main(string[] args)
		{
			double budget = double.Parse(Console.ReadLine());
			string season = Console.ReadLine().ToLower();

			string campOrHotel = string.Empty;

			if (season == "summer")
				campOrHotel = "Camp";
			else
				campOrHotel = "Hotel";

			string place = string.Empty;
			double expence = 0;

			if (budget > 1000)
			{
				place = "Europe";
				campOrHotel = "Hotel";
				expence = budget * 0.9;
			}
			else if (budget <= 1000 && budget > 100)
			{
				place = "Balkans";

				if (season == "summer")
					expence = budget * 0.4;
				else
					expence = budget * 0.8;
			}
			else
			{
				place = "Bulgaria";

				if (season == "summer")
					expence = budget * 0.3;
				else
					expence = budget * 0.7;
			}

			

			Console.WriteLine($"Somewhere in {place}");
			Console.WriteLine($"{campOrHotel} - {expence:f2}");

		}
	}
}
