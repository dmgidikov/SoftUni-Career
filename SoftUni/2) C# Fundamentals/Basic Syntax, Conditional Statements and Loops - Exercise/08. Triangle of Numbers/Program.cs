using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Triangle_of_Numbers
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int randomN = int.Parse(Console.ReadLine());

			for (int i = 1; i <= randomN; i++)
			{
				Console.Write(i + " ");

				for (int j = 2; j <= i; j++)
				{
					Console.Write(i + " ");
				}

				Console.WriteLine();
				
			}
		}
	}
}
