using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Gaming_Store
{
	internal class Program
	{
		static void Main(string[] args)
		{
			double budget = double.Parse(Console.ReadLine());

			double startingBudget = budget;

			while (true)
			{
				string command = Console.ReadLine();

				if (command != "Game Time")
				{
					double price = 0;

					switch (command)
					{
						case "OutFall 4": price = 39.99;
							if (budget >= price)
							{
								Console.WriteLine($"Bought {command}");
								budget -= price;
							}
							else
							{
								Console.WriteLine("Too Expensive");
							}
							break;
						case "RoverWatch Origins Edition": price = 39.99;
							if (budget >= price)
							{
								Console.WriteLine($"Bought {command}");
								budget -= price;
							}
							else
							{
								Console.WriteLine("Too Expensive");
							}
							break; 
						case "CS: OG": price = 15.99;
							if (budget >= price)
							{
								Console.WriteLine($"Bought {command}");
								budget -= price;
							}
							else
							{
								Console.WriteLine("Too Expensive");
							}
							break;
						case "Zplinter Zell": price = 19.99;
							if (budget >= price)
							{
								Console.WriteLine($"Bought {command}");
								budget -= price;
							}
							else
							{
								Console.WriteLine("Too Expensive");
							}
							break;
						case "Honored 2": price = 59.99;
							if (budget >= price)
							{
								Console.WriteLine($"Bought {command}");
								budget -= price;
							}
							else
							{
								Console.WriteLine("Too Expensive");
							}
							break;
						case "RoverWatch": price = 29.99;
							if (budget >= price)
							{
								Console.WriteLine($"Bought {command}");
								budget -= price;
							}
							else
							{
								Console.WriteLine("Too Expensive");
							}
							break;
						default:
							Console.WriteLine("Not Found");
							break;

						if (budget == 0)
						{
							Console.WriteLine("Out of money!");
							break;
						}	
					}
				}
				else
				{
					double spent = startingBudget - budget;

					Console.WriteLine($"Total spent: ${spent:f2}. Remaining: ${budget:f2}");
					break;
				}
			}
		}
	}
}
