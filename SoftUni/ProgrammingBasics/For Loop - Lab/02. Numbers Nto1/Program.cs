using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Numbers_Nto1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int someRandomNumber = int.Parse(Console.ReadLine());

			for (int i = someRandomNumber; i >= 1; i--)
			{
				Console.WriteLine(i);
			}
		}
	}
}
