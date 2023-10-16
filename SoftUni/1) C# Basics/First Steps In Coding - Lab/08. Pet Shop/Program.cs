using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetSHop
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int numberOfDogFood = int.Parse(Console.ReadLine());
			int numberOfCatFood = int.Parse(Console.ReadLine());

			double dogFoodPrice = numberOfDogFood * 2.5;
			int catFoodPrice = numberOfCatFood * 4;

			double result = dogFoodPrice + catFoodPrice;

			Console.WriteLine(result + " lv.");
		}
	}
}
