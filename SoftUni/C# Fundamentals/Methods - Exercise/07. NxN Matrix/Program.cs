using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.NxN_Matrix
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int randomNum = int.Parse(Console.ReadLine());
			
			PrintElement(randomNum);
		}

		static void PrintElement(int num)
		{
			for (int i = 0; i < num; i++)
			{
				for (int j = 0; j < num - 1; j++)
				{
					Console.Write(num + " ");
				}
				Console.WriteLine(num);
			}
		}
	}
}
