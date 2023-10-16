using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Sort_Numbers
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int a = int.Parse(Console.ReadLine());
			int b = int.Parse(Console.ReadLine());
			int c = int.Parse(Console.ReadLine());

			int maxNumber = Math.Max(a, Math.Max(b, c));
			int minNumber = Math.Min(a, Math.Min(b, c));

			if (maxNumber == a && minNumber == b)
			{
				Console.WriteLine(a);
				Console.WriteLine(c);
				Console.WriteLine(b);
			}
			else if (maxNumber == a && minNumber == c)
			{
				Console.WriteLine(a);
				Console.WriteLine(b);
				Console.WriteLine(c);
			}
			else if (maxNumber == b && minNumber == a)
			{
				Console.WriteLine(b);
				Console.WriteLine(c);
				Console.WriteLine(a);
			}
			else if (maxNumber == b && minNumber == c)
			{
				Console.WriteLine(b);
				Console.WriteLine(a);
				Console.WriteLine(c);
			}
			else if (maxNumber == c && minNumber == a)
			{
				Console.WriteLine(c);
				Console.WriteLine(b);
				Console.WriteLine(a);
			}
			else
			{
				Console.WriteLine(c);
				Console.WriteLine(a);
				Console.WriteLine(b);
			}
		}
	}
}
