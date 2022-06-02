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
			int randomNumber = int.Parse(Console.ReadLine());

			if (randomNumber == 1)
				Console.WriteLine("Monday");
			else if (randomNumber == 2)
				Console.WriteLine("Tuesday");
			else if (randomNumber == 3)
				Console.WriteLine("Wednesday");
			else if (randomNumber == 4)
				Console.WriteLine("Thursday");
			else if (randomNumber == 5)
				Console.WriteLine("Friday");
			else if (randomNumber == 6)
				Console.WriteLine("Saturday");
			else if (randomNumber == 7)
				Console.WriteLine("Sunday");
			else			
				Console.WriteLine("Error");
		}
	}
}
