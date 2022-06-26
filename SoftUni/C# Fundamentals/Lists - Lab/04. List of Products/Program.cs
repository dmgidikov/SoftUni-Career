using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.List_of_Products
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int randomNum = int.Parse(Console.ReadLine());

			List<string> products = new List<string>();

			for (int i = 0; i < randomNum; i++)
			{
				string temp = Console.ReadLine();
				products.Add(temp);
			}

			products.Sort();

			for (int i = 0; i < randomNum; i++)
			{
				Console.WriteLine($"{i + 1}.{products[i]}");
			}
		}
	}
}
