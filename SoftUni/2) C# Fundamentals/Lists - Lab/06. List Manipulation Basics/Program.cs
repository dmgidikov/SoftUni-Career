using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.List_Manipulation_Basics
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<int> randomNums = Console.ReadLine().Split().Select(int.Parse).ToList();

			while (true)
			{
				string[] command = Console.ReadLine().Split();

				if (command[0] == "end")
				{
					Console.WriteLine(String.Join(" ", randomNums));
					break;
				}
				else
				{
					if (command[0] == "Add")
					{
						randomNums.Add(GetNum(command));
					}
					else if (command[0] == "Remove")
					{
						randomNums.Remove(GetNum(command));
					}
					else if (command[0] == "RemoveAt")
					{
						randomNums.RemoveAt(GetNum(command));
					}
					else if (command[0] == "Insert")
					{
						int index = int.Parse(command[2]);
						randomNums.Insert(index, GetNum(command));
					}
				}
			}
		}

		static int GetNum(string[] command)
		{
			int number = int.Parse(command[1]);
			return number;
		}
	}
}
