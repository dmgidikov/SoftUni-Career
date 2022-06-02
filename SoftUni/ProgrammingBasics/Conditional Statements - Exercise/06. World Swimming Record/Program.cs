using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.World_Swimming_Record
{
	internal class Program
	{
		static void Main(string[] args)
		{
			double swimmingRecord = double.Parse(Console.ReadLine());
			double swimmingRange = double.Parse(Console.ReadLine());
			double timeInSeconds = double.Parse(Console.ReadLine());

			double ivanchoTime = swimmingRange * timeInSeconds;
			double additionalTime = Math.Floor(swimmingRange / 15) * 12.5;

			double totalTime = ivanchoTime + additionalTime;

			if (totalTime < swimmingRecord)
			{
				Console.WriteLine($"Yes, he succeeded! The new world record is {totalTime:f2} seconds.");
			}
			else
			{
				Console.WriteLine($"No, he failed! He was {totalTime - swimmingRecord:f2} seconds slower.");
			}
		}
	}
}
