using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Day_of_Week
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int someNumber = int.Parse(Console.ReadLine());

			string[] weekDays = new string[] 
			{ "Monday", "Tuesday", "Wednesday", "Thursday",
				"Friday", "Saturday", "Sunday"
			};

			if (someNumber > 0 && someNumber < 8) 
			{
				Console.WriteLine(weekDays[someNumber-1]);
			}
			else
			{
				Console.WriteLine("Invalid day!");
			}
		}
	}
}
