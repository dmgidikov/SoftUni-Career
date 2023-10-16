using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string name = Console.ReadLine();
			string password = Console.ReadLine();

			while (true)
			{
				string input = Console.ReadLine();

				if (input != password)
				{
					continue;
				}
				else
				{
					Console.WriteLine($"Welcome {name}!");
					break;
				}
			}
		}
	}
}
