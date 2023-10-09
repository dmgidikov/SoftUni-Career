using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Histogram
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int inputNumbers = int.Parse(Console.ReadLine());

			decimal p1 = 0;
			decimal p2 = 0;
			decimal p3 = 0;
			decimal p4 = 0;
			decimal p5 = 0;

			for (int i = 0; i < inputNumbers; i++)
			{
				int currentNumber = int.Parse(Console.ReadLine());

				if (currentNumber >= 800)
				{
					p5++;
				}
				else if (currentNumber >= 600 && currentNumber <= 799)
				{
					p4++;
				}
				else if (currentNumber >= 400 && currentNumber <= 599)
				{
					p3++;
				}
				else if (currentNumber >= 200 && currentNumber <= 399)
				{
					p2++;
				}
				else
				{
					p1++;
				}
			}

			decimal p1InPercent = (p1 * 100) / inputNumbers;
			decimal p2InPercent = (p2 * 100) / inputNumbers;
			decimal p3InPercent = (p3 * 100) / inputNumbers;
			decimal p4InPercent = (p4 * 100) / inputNumbers;
			decimal p5InPercent = (p5 * 100) / inputNumbers;

			Console.WriteLine($"{p1InPercent:f2}%");
			Console.WriteLine($"{p2InPercent:f2}%");
			Console.WriteLine($"{p3InPercent:f2}%");
			Console.WriteLine($"{p4InPercent:f2}%");
			Console.WriteLine($"{p5InPercent:f2}%");
		}
	}
}
