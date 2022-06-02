using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04VocationBookList
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int pagesInBook = int.Parse(Console.ReadLine());
			int pagesPer1Hour = int.Parse(Console.ReadLine());
			int daysPerReading1Book = int.Parse(Console.ReadLine());

			int hoursPer1book = pagesInBook / pagesPer1Hour;
			int hoursPerDay = hoursPer1book / daysPerReading1Book;

			Console.WriteLine(hoursPerDay);
		}
	}
}
