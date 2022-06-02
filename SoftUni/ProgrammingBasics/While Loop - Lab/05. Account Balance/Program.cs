using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Account_Balance
{
	internal class Program
	{
		static void Main(string[] args)
		{
			double sum = 0;

			while (true)
			{
				string command = Console.ReadLine();

				if (command != "NoMoreMoney")
				{
					double entryMoney = double.Parse(command);

					if (entryMoney >= 0)
					{
						Console.WriteLine($"Increase: {entryMoney:f2}");
						sum += entryMoney;
					}
					else
					{
						Console.WriteLine("Invalid operation!");
						break;
					}
				}
				else
				{
					break;
				}
			}
			
			Console.WriteLine("Total: " + Math.Round(sum, 2));
		}
	}
}