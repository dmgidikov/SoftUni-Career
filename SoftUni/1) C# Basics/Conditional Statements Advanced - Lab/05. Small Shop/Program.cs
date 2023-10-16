using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Small_Shop
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string product = Console.ReadLine();
			string city = Console.ReadLine();
			double quantity = double.Parse(Console.ReadLine());

			double productPrice = 0;

			if (city == "Sofia")
			{
				switch (product)
				{
					case "coffee": productPrice = 0.5; break;
					case "water": productPrice = 0.8; break;
					case "beer": productPrice = 1.20; break;
					case "sweets": productPrice = 1.45; break;
					default:
						productPrice = 1.6; break;
						break;
				}
			}
			else if (city == "Plovdiv")
			{
				switch (product)
				{
					case "coffee": productPrice = 0.4; break;
					case "water": productPrice = 0.7; break;
					case "beer": productPrice = 1.15; break;
					case "sweets": productPrice = 1.30; break;
					default:
						productPrice = 1.5; break;
						break;
				}
			}
			else
			{
				switch (product)
				{
					case "coffee": productPrice = 0.45; break;
					case "water": productPrice = 0.7; break;
					case "beer": productPrice = 1.10; break;
					case "sweets": productPrice = 1.35; break;
					default:
						productPrice = 1.55; break;
						break;
				}
			}

			double spentMoney = quantity * productPrice;

			Console.WriteLine(spentMoney);
		}
	}
}
