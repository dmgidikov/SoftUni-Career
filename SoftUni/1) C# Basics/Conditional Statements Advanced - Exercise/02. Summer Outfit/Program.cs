using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Summer_Outfit
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int celsius = int.Parse(Console.ReadLine());
			string dayPart = Console.ReadLine();

			string clothes = string.Empty;

			switch (dayPart)
			{
				case "Morning":

					if (celsius >= 10 && celsius <= 18)
						clothes = "Sweatshirt and Sneakers";
					else if (celsius > 18 && celsius <= 24) 
						clothes = "Shirt and Moccasins";
					else
						clothes = "T-Shirt and Sandals";
					break;

				case "Afternoon":

					if (celsius >= 10 && celsius <= 18)
						clothes = "Shirt and Moccasins";
					else if (celsius > 18 && celsius <= 24)
						clothes = "T-Shirt and Sandals";
					else
						clothes = "Swim Suit and Barefoot";
					break;

				default:

					if (celsius >= 10 && celsius <= 18)
						clothes = "Shirt and Moccasins";
					else if (celsius > 18 && celsius <= 24)
						clothes = "Shirt and Moccasins";
					else
						clothes = "Shirt and Moccasins";
					break;
			}

			Console.WriteLine($"It's {celsius} degrees, get your {clothes}.");
		}
	}
}