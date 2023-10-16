using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.List_Manipulation_Advanced
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<int> randomNums = Console.ReadLine().Split().Select(int.Parse).ToList();

			List<int> copyOfRandomNumbersList = randomNums.ToList();

			while (true)
			{
				string[] command = Console.ReadLine().Split();

				if (command[0] == "end")
				{
					int originalNumsCount = randomNums.Count;
					int copyNumsCount = copyOfRandomNumbersList.Count;
					int rotations = Math.Min(originalNumsCount, copyNumsCount);
					bool areEquals = true;

					for (int i = 0; i < rotations; i++)
					{
						if (randomNums[i] != copyOfRandomNumbersList[i])
						{
							areEquals = false;
							break;
						}						
					}

					if (areEquals == false)
					{
						Console.WriteLine(String.Join(" ", randomNums));
					}
					else
					{
						break;
					}
				}
				else
				{
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

						else if (command[0] == "GetSum")
						{
							int sum = randomNums.Sum();
							Console.WriteLine(sum);
						}
						else if (command[0] == "Contains")
						{
							int checkForNumber = int.Parse(command[1]);

							if (randomNums.Contains(checkForNumber))
							{
								Console.WriteLine("Yes");
							}
							else
							{
								Console.WriteLine("No such number");
							}
						}
						else if (command[0] == "PrintEven")
						{
							for (int i = 0; i < randomNums.Count; i++)
							{
								if (randomNums[i] % 2 == 0)
								{
									Console.Write(randomNums[i] + " "); ;
								}
							}
							Console.WriteLine();
						}
						else if (command[0] == "PrintOdd")
						{
							for (int i = 0; i < randomNums.Count; i++)
							{
								if (randomNums[i] % 2 == 1)
								{
									Console.Write(randomNums[i] + " ");
								}
							}
							Console.WriteLine();
						}
						else if (command[0] == "Filter")
						{
							string condition = command[1];
							int num = int.Parse(command[2]);

							for (int i = 0; i < randomNums.Count; i++)
							{
								if (condition == ">")
								{
									if (randomNums[i] > num)
									{
										Console.Write(randomNums[i] + " ");
									}
								}
								else if (condition == "<")
								{
									if (randomNums[i] < num)
									{
										Console.Write(randomNums[i] + " ");
									}
								}
								else if (condition == ">=")
								{
									if (randomNums[i] >= num)
									{
										Console.Write(randomNums[i] + " ");
									}
								}
								else if (condition == "<=")
								{
									if (randomNums[i] <= num)
									{
										Console.Write(randomNums[i] + " ");
									}
								}
							}
							Console.WriteLine();
						}
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



