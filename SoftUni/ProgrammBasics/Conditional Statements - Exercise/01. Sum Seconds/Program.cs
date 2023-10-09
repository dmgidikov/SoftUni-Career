using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditional_Statements___Exercise
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int firstTime = int.Parse(Console.ReadLine());
			int secondTime = int.Parse(Console.ReadLine());
			int thirdTime = int.Parse(Console.ReadLine());

			int totalTime = firstTime + secondTime + thirdTime;

			int minites = totalTime / 60;
			int seconds = totalTime % 60;

			Console.WriteLine($"{minites}:{seconds:d2}");
		}
	}
}
