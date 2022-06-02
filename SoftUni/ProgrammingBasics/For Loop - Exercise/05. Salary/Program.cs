using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Salary
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int openTabs = int.Parse(Console.ReadLine());
			double sollary = double.Parse(Console.ReadLine());

			for (int i = 0; i < openTabs; i++)
			{
				string openTab = Console.ReadLine();

				switch (openTab)
				{
					case "Facebook": sollary -= 150; break;
					case "Instagram": sollary -= 100; break;
					case "Reddit": sollary -= 50; break;
					default:
						break;
				}

				if (sollary <= 0)
				{
					Console.WriteLine("You have lost your salary.");
					break;
				}
			}

			if (sollary > 0)
			{
				Console.WriteLine(sollary);
			}
		}
	}
}
