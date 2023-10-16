using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Moving
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int a = int.Parse(Console.ReadLine());
			int b = int.Parse(Console.ReadLine());
			int c = int.Parse(Console.ReadLine());

			int size = a * b * c;

			while (true)
			{
				string command = Console.ReadLine();

				if (command == "Done")
				{
					Console.WriteLine($"{size} Cubic meters left.");
					break;
				}
				else
				{
					int itemSize = int.Parse(command);

					if (size >= itemSize)
					{
						size -= itemSize;
					}
					else
					{
						int result = itemSize - size;
						Console.WriteLine($"No more free space! You need {result} Cubic meters more.");
						break;
					}
				}
			}
		}
	}
}
