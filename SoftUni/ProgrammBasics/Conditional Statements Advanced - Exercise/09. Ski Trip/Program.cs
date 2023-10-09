using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Ski_Trip
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int nights = int.Parse(Console.ReadLine()) - 1;
			string roomType = Console.ReadLine();
			string feedback = Console.ReadLine();

			double roomPrice = 0;

			if (nights > 15)
			{
				switch (roomType)
				{
					case "room for one person": roomPrice = 18; break;
					case "apartment": roomPrice = 25;
							roomPrice -= roomPrice * 0.5; break;
					case "president apartment": roomPrice = 35;
						roomPrice -= roomPrice * 0.2;  break;
					default:
						break;
				}
			}
			else if (nights >= 10 && nights <= 15)
			{
				switch (roomType)
				{
					case "room for one person": roomPrice = 18; break;
					case "apartment": roomPrice = 25;
						roomPrice -= roomPrice * 0.35; break;					
					case "president apartment":
						roomPrice = 35;
						roomPrice -= roomPrice * 0.15; break;
					default:
						break;
				}
			}
			else
			{
				switch (roomType)
				{
					case "room for one person": roomPrice = 18; break;
					case "apartment":
						roomPrice = 25;
						roomPrice -= roomPrice * 0.30; break;
					case "president apartment":
						roomPrice = 35;
						roomPrice -= roomPrice * 0.1; break;
					default:
						break;
				}
			}

			double spentMoney = nights * roomPrice;

			if (feedback == "positive")
			{
				spentMoney *= 1.25;
			}
			else
			{
				spentMoney -= spentMoney * 0.1;
			}

			Console.WriteLine($"{spentMoney:f2}");
		}
	}
}
