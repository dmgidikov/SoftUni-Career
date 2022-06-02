using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Cake
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int a = int.Parse(Console.ReadLine());	
			int b = int.Parse(Console.ReadLine());

			int size = a * b;

			while (true)
			{
				string command = Console.ReadLine();

				if (command == "STOP")
				{
					Console.WriteLine($"{size} pieces are left.");
					break;
				}
				else
				{
					int piece = int.Parse(command);

					if (size >= piece)
					{
						size -= piece;
					}
					else
					{
						int result = piece - size;
						Console.WriteLine($"No more cake left! You need {result} pieces more.");
						break;
					}
				}
			}
		}
	}
}
