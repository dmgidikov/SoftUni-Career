using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Walking
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int sumSteps = 0;

			while (true)
			{
				string input = Console.ReadLine();

				if (input != "Going home")
				{
					int steps = int.Parse(input);
					sumSteps += steps;

					if (sumSteps >= 10000)
					{
						Console.WriteLine($"Goal reached! Good job!");
						Console.WriteLine($"{sumSteps - 10000} steps over the goal!");
						break;
					}
				}
				else
				{
					int finalSteps = int.Parse(Console.ReadLine());
					sumSteps += finalSteps;

					if (sumSteps >= 10000)
					{
						Console.WriteLine($"Goal reached! Good job!");
						Console.WriteLine($"{sumSteps - 10000} steps over the goal!");
						break;
					}
					else
					{
						Console.WriteLine($"{10000 - sumSteps} more steps to reach goal.");
						break;
					}
				}
			}
		}
	}
}
