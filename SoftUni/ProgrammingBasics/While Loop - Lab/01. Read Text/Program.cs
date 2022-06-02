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
			while (true)
			{
				string randomWord = Console.ReadLine();

				if (randomWord != "Stop")
					Console.WriteLine(randomWord);
				else
				{
					break;
				}
			}
		}
	}
}
