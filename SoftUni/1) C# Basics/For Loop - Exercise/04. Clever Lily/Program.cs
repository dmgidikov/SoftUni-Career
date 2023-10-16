using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Clever_Lily
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int lilysAge = int.Parse(Console.ReadLine());
			double wandermachinePrice = double.Parse(Console.ReadLine());
			int pricePerToy = int.Parse(Console.ReadLine());

			int totalCashMoney = 0;
			int totalToys = 0;
			int counter = 1;

			for (int i = 1; i <= lilysAge; i++)
			{
				if (i % 2 == 0) 
				{
					totalCashMoney += counter * 10;
					counter++;
				}
				else
				{
					totalToys++;
				}
			}

			double totalToysMoney = totalToys * pricePerToy;
			double finalCashMoney = totalCashMoney - counter + 1;

			double totalMoney = totalToysMoney + finalCashMoney;

			if (totalMoney >= wandermachinePrice)
			{
				Console.WriteLine($"Yes! {totalMoney - wandermachinePrice:f2}");
			}
			else
			{
				Console.WriteLine($"No! {wandermachinePrice - totalMoney:f2}");
			}
		}
	}
}
