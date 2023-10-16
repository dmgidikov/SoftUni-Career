using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Old_Books
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string anneBook = Console.ReadLine();

			int counter = 0;

			while (true)
			{
				string randomBook = Console.ReadLine();

				if (randomBook == "No More Books")
				{
					Console.WriteLine("The book you search is not here!");
					Console.WriteLine($"You checked {counter} books.");
					break;
				}
				else if (randomBook == anneBook)
				{
					Console.WriteLine($"You checked {counter} books and found it.");
					break;
				}
				else
				{
					counter++;
				}
			}
		}
	}
}
