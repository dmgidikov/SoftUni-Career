using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Max_Number
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int maxNumber = int.MinValue;

			while (true)
			{
				string input = Console.ReadLine();

				if (input != "Stop")
				{
					int inputAsInt = int.Parse(input);

					if (inputAsInt > maxNumber)
					{
						maxNumber = inputAsInt;
					}
				}
				else
				{
					break;
				}
			}

			Console.WriteLine(maxNumber);
		}
	}
}
