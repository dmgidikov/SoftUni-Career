using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Fruit_Shop
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string fruit = Console.ReadLine();
			string weekDay = Console.ReadLine();
			double quantity = double.Parse(Console.ReadLine());

			double productPrice = 0;
			double result = 0;

			switch (weekDay)
			{
				case "Monday":
				case "Tuesday":
				case "Wednesday":
				case "Thursday":
				case "Friday":

					switch (fruit)
					{
						case "banana": productPrice = 2.5; break;
						case "apple": productPrice = 1.2; break;
						case "orange": productPrice = 0.85; break;
						case "grapefruit": productPrice = 1.45; break;
						case "kiwi": productPrice = 2.7; break;
						case "pineapple": productPrice = 5.50; break;
						case "grapes": productPrice = 3.85; break;
						default:
							Console.WriteLine("error");
							break;
					}

					if (!(fruit == "banana" || fruit == "apple" || fruit == "orange" ||
						fruit == "grapefruit" || fruit == "kiwi" || fruit == "pineapple" ||
							fruit == "grapes"))
					{
						break;
					}

					result = quantity * productPrice;
					Console.WriteLine($"{result:f2}");
					break;

				case "Saturday":
				case "Sunday":

					switch (fruit)
					{
						case "banana": productPrice = 2.7; break;
						case "apple": productPrice = 1.25; break;
						case "orange": productPrice = 0.9; break;
						case "grapefruit": productPrice = 1.6; break;
						case "kiwi": productPrice = 3; break;
						case "pineapple": productPrice = 5.6; break;
						case "grapes": productPrice = 4.2; break;
						default:
							Console.WriteLine("error");
							break;
					}

					if (!(fruit == "banana" || fruit == "apple" || fruit == "orange" ||
						fruit == "grapefruit" || fruit == "kiwi" || fruit == "pineapple" ||
							fruit == "grapes"))
					{
						break;
					}

					result = quantity * productPrice;
					Console.WriteLine($"{result:f2}");
					break;

				default:
					Console.WriteLine("error");
					break;
			}
		}
	}
}