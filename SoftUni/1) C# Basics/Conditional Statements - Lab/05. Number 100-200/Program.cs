using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Number_100_200
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int randomNumber = int.Parse(Console.ReadLine());

			if (randomNumber > 200)
			{
				Console.WriteLine("Greater than 200");
			}
			else if (randomNumber >= 100 && randomNumber <= 200)
			{
				Console.WriteLine("Between 100 and 200");
			}
			else
			{
				Console.WriteLine("Less than 100");
			}
		}
	}
}
