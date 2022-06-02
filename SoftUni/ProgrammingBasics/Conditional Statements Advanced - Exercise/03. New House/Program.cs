using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.New_House
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string flowerType = Console.ReadLine();
			int flowerNumber = int.Parse(Console.ReadLine());
			double budget = double.Parse(Console.ReadLine());

			double pricePerOneFlower = 0;

			switch (flowerType)
			{
				case "Roses": pricePerOneFlower = 5;
					if (flowerNumber > 80)
						pricePerOneFlower -= pricePerOneFlower * 0.1; break;					
				case "Dahlias": pricePerOneFlower = 3.8;
					if (flowerNumber > 90)
						pricePerOneFlower -= pricePerOneFlower * 0.15; break;
				case "Tulips": pricePerOneFlower = 2.8;
					if (flowerNumber > 80)
						pricePerOneFlower -= pricePerOneFlower * 0.15; break;
				case "Narcissus": pricePerOneFlower = 3;
					if (flowerNumber < 120)
						pricePerOneFlower *= 1.15; break;
				case "Gladiolus": pricePerOneFlower = 2.5;
					if (flowerNumber < 80)
						pricePerOneFlower *= 1.2; break; 
				default:
					break;
			}

			double finalPrice = flowerNumber * pricePerOneFlower;

				if (budget >= finalPrice)
				{
					budget -= finalPrice;
					Console.WriteLine($"Hey, you have a great garden with {flowerNumber} {flowerType} " +
						$"and {budget:f2} leva left.");
				}
				else
				{
					finalPrice -= budget;
					Console.WriteLine($"Not enough money, you need {finalPrice:f2} leva more.");
				}
		}
	}
}
