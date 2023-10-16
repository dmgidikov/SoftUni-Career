using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Vacation
{
	internal class Program
	{
		static void Main(string[] args)
		{
			double vacationMoney = double.Parse(Console.ReadLine());
			double leftMoney = double.Parse(Console.ReadLine());

			int spendDays = 0;
			int totalDays = 0;

			while (true)
			{
				string spentOrSave = Console.ReadLine();
				double currentMoney = double.Parse(Console.ReadLine());

				if (spentOrSave == "spend")
				{
					leftMoney -= currentMoney;

					if (leftMoney < 0)
						leftMoney = 0;

					spendDays++;
					totalDays++;

					if (spendDays == 5)
					{
						Console.WriteLine("You can't save the money.");
						Console.WriteLine(totalDays);
						break;
					}
				}
				else
				{
					leftMoney += currentMoney;

					spendDays = 0;
					totalDays++;

					if (leftMoney >= vacationMoney)
					{
						Console.WriteLine($"You saved the money for {totalDays} days.");
						break;
					}
				}
			}
		}
	}
}
