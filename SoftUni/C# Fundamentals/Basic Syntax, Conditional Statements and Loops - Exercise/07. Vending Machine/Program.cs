using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Vending_Machine
{
	internal class Program
	{
		static void Main(string[] args)
		{
			double sumCoins = 0;

			while (true)
			{
				string input = Console.ReadLine().ToLower();

				if (input == "start")
				{
					break;
				}
				else
				{
					double inputAsCoins = double.Parse(input);

					switch (inputAsCoins)
					{
						case 1: sumCoins += 1; break;
						case 2: sumCoins += 2; break;
						case 0.5: sumCoins += 0.5; break;
						case 0.2: sumCoins += 0.2; break;
						case 0.1: sumCoins += 0.1; break;
						default:
							Console.WriteLine($"Cannot accept {inputAsCoins}");
							break;
					}
				}
			}

			double price = 0;

			while (true)
			{
				string product = Console.ReadLine().ToLower();

				if (product == "end")
				{
					Console.WriteLine($"Change: {sumCoins:f2}");
					break;
				}
				switch (product)
				{
					case "nuts":
						price = 2;
						if (price <= sumCoins)
						{
							sumCoins -= price;
							Console.WriteLine($"Purchased {product}");
						}
						else
						{
							Console.WriteLine($"Sorry, not enough money");
						}
						break;
					case "water":
						price = 0.7;
						if (price <= sumCoins)
						{
							sumCoins -= price;
							Console.WriteLine($"Purchased {product}");
						}
						else
						{
							Console.WriteLine($"Sorry, not enough money");
						}
						break;
					case "crisps":
						price = 1.5;
						if (price <= sumCoins)
						{
							sumCoins -= price;
							Console.WriteLine($"Purchased {product}");
						}
						else
						{
							Console.WriteLine($"Sorry, not enough money");
						}
						break;
					case "soda":
						price = 0.8;
						if (price <= sumCoins)
						{
							sumCoins -= price;
							Console.WriteLine($"Purchased {product}");
						}
						else
						{
							Console.WriteLine($"Sorry, not enough money");
						}
						break;
					case "coke":
						price = 1;
						if (price <= sumCoins)
						{
							sumCoins -= price;
							Console.WriteLine($"Purchased {product}");
						}
						else
						{
							Console.WriteLine($"Sorry, not enough money");
						}
						break;
					default:
						Console.WriteLine("Invalid product");
						break;
				}
			}
		}
	}
}
