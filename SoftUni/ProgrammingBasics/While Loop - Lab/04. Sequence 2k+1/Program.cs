using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Sequence_2k_1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int someInt = int.Parse(Console.ReadLine());

			int start = 0;

			while (true)
			{
				start = (start * 2) + 1;

				if (start <= someInt)
					Console.WriteLine(start);
				else break;
			}
		}
	}
}
