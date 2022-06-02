using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Padawan_Equipment
{
	internal class Program
	{
		static void Main(string[] args)
		{
			double amountOfMoney = double.Parse(Console.ReadLine());
			int students = int.Parse(Console.ReadLine());
			double lightsabersPrice = double.Parse(Console.ReadLine());
			double robersPrice = double.Parse(Console.ReadLine());
			double beltsPrice = double.Parse(Console.ReadLine());

			double studentsPlus = Math.Ceiling(students + (students * 0.1));

			double moneyForLightsabers = lightsabersPrice * studentsPlus;
			double regularPrice = students * (robersPrice + beltsPrice) + moneyForLightsabers;
						
			double discoontPrice = 0;

			if (students > 5)
			{
				int freeBelts = students / 6;
				discoontPrice += freeBelts * beltsPrice;
			}

			regularPrice -= discoontPrice;

			if (amountOfMoney >= regularPrice)
			{
				Console.WriteLine($"The money is enough - it would cost {regularPrice:f2}lv.");
			}
			else
			{
				Console.WriteLine($"John will need {regularPrice - amountOfMoney:f2}lv more.");
			}
		}
	}
}
