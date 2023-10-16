using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07FoodDelivery
{
	internal class Program
	{
		static void Main(string[] args)
		{
			double moneyForChicken = double.Parse(Console.ReadLine()) * 10.35;
			double moneyForFish = double.Parse(Console.ReadLine()) * 12.40;
			double moneyForVegie = double.Parse(Console.ReadLine()) * 8.15;

			double totalSpentWithoutDesert = moneyForChicken + moneyForFish + moneyForVegie;
			double desertPrice = totalSpentWithoutDesert * 0.20;

			double totalSpent = totalSpentWithoutDesert + desertPrice + +2.5;

			Console.WriteLine(totalSpent);

		}
	}
}
