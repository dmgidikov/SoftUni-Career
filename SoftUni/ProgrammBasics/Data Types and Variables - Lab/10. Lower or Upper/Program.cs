using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Lower_or_Upper
{
	internal class Program
	{
		static void Main(string[] args)
		{
			char randomChar = char.Parse(Console.ReadLine());

			int charAsInt = (int)randomChar;

			if (charAsInt >= 65 && charAsInt <= 90)
			{
				Console.WriteLine("upper-case");
			}
			else
			{
				Console.WriteLine("lower-case");
			}
		}
	}
}
