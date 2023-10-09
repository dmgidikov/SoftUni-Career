using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Fishing_Boat
{
	internal class Program
	{
		static void Main(string[] args)
		{
			double budget = double.Parse(Console.ReadLine());
			string season = Console.ReadLine();
			int fisherman = int.Parse(Console.ReadLine());

			double pricePerShip = 0;

			switch (season)
			{
				case "Spring": pricePerShip = 3000; break;
				case "Winter": pricePerShip = 2600; break;
				default:
					pricePerShip = 4200; 
					break;
			}

			double discount = 0;

			if (fisherman >= 12)
				discount = pricePerShip * 0.25;
			else if (fisherman > 6 && fisherman <= 11)
				discount = pricePerShip * 0.15;
			else
				discount = pricePerShip * 0.1;

			double normalDiscountPrice = pricePerShip - discount;
			double additionalDiscount = 0;

			if (season != "Autumn")
			{
				if (fisherman % 2 == 0)
				{
					additionalDiscount = normalDiscountPrice * 0.05;
				}
			}

			double additionalDiscountPrice = normalDiscountPrice - additionalDiscount;

			if (budget >= additionalDiscountPrice)
			{
				budget -= additionalDiscountPrice;
				Console.WriteLine($"Yes! You have {budget:f2} leva left.");
			}
			else
			{
				additionalDiscountPrice -= budget;
				Console.WriteLine($"Not enough money! You need {additionalDiscountPrice:f2} leva.");
			}
		}
	}
}
