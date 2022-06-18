using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Array_Manipulator
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] randomNums = Console.ReadLine().Split().Select(int.Parse).ToArray();

			while (true)
			{
				string[] command = Console.ReadLine().Split();

				if (command[0] != "end")
				{
					if (command[0] == "exchange")
					{
						int rotations = int.Parse(command[1]);

						if (rotations > randomNums.Length)
						{
							Console.WriteLine("Invalid index");
						}
						else
						{
							RotateArray(rotations, randomNums);
						}
					}
					else if (command[0] == "max")
					{
						string sign = command[1];

						if (sign == "odd")
						{
							int current = MaxOdd(sign, randomNums);
							Console.WriteLine(current);
						}
						else
						{
							int current = MaxEven(sign, randomNums);
							Console.WriteLine(current);
						}
					}
					else if (command[0] == "min")
					{
						string sign = command[1];

						if (sign == "odd")
						{
							MinOdd(randomNums);
						}
						else
						{
							MinEven(randomNums);
						}
					}
					else if (command[0] == "first")
					{
						int elements = int.Parse(command[1]);

						if (command[2] == "even")
						{
							int[] firstTwoEven = FirstEven(elements, randomNums);

							for (int i = 0; i < 1; i++)
							{
								for (int j = 0; j < firstTwoEven.Length; j++)
								{
									Console.WriteLine($"[{firstTwoEven[0]},{firstTwoEven[1]}]");
								}
							}
						}
						else
						{
							int[] firstTwoEven = FirstOdd(elements, randomNums);

							for (int i = 0; i < 1; i++)
							{
								for (int j = 0; j < firstTwoEven.Length; j++)
								{
									Console.WriteLine($"[{firstTwoEven[0]},{firstTwoEven[1]}]");
								}
							}
						}
					}
					else if (command[0] == "last")
					{
						int elements = int.Parse(command[1]);

						if (command[2] == "even")
						{


						}
					}					
				}
				else
				{
					for (int i = 0; i < randomNums.Length; i++)
					{
						Console.Write(randomNums[i] + " ");
					}

					break;
				}
			}
		}

		static void RotateArray(int rotations, int[] randomNums)
		{
			for (int i = 0; i < rotations; i++)
			{
				int firtNum = randomNums[0];

				for (int j = 0; j < randomNums.Length - 1; j++)
				{
					randomNums[j] = randomNums[j + 1];
				}

				randomNums[randomNums.Length - 1] = firtNum;
			}
		}

		static int MaxOdd(string sign, int[] randomNums)
		{
			int maxElement = int.MinValue;
			int maxElementIndex = 0;

			for (int i = 0; i < randomNums.Length; i++)
			{
				int current = randomNums[i];

				if (i % 2 != 0)
				{
					if (current >= maxElement)
					{
						maxElement = current;
						maxElementIndex = i;
					}
				}
			}

			return maxElementIndex;
		}

		static int MaxEven(string sign, int[] randomNums)
		{
			int maxElement = int.MinValue;
			int maxElementIndex = 0;

			for (int i = 0; i < randomNums.Length; i++)
			{
				int current = randomNums[i];

				if (i % 2 == 0)
				{
					if (current >= maxElement)
					{
						maxElement = current;
						maxElementIndex = i;
					}
				}
			}

			return maxElementIndex;
		}

		static int MinOdd(int[] randomNums)
		{
			int maxElement = int.MaxValue;
			int maxElementIndex = 0;

			for (int i = 0; i < randomNums.Length; i++)
			{
				int current = randomNums[i];

				if (current % 2 != 0)
				{
					if (current <= maxElement)
					{
						maxElement = current;
						maxElementIndex = i;
					}
				}
			}

			return maxElementIndex;
		}

		static int MinEven(int[] randomNums)
		{
			int minElement = int.MaxValue;
			int minElementIndex = 0;

			for (int i = 0; i <= randomNums.Length; i++)
			{
				int current = randomNums[i];

				if (current % 2 == 0)
				{
					if (current < minElement)
					{
						minElement = current;
						minElementIndex = i;
					}
				}
			}

			return minElementIndex;
		}

		static int[] FirstOdd(int elements, int[] randomNums)
		{
			int[] oddArr = new int[elements];
			int counter = 0;

			for (int i = 0; i < randomNums.Length; i++)
			{
				int temp = randomNums[i];

				if (counter == 2)
				{
					break;
				}
				else
				{
					if (temp % 2 != 0)
					{
						oddArr[i] = temp;
						counter++;
					}
				}
			}

			return oddArr;
		}

		static int[] FirstEven(int elements, int[] randomNums)
		{
			int[] evenArr = new int[elements];
			int counter = 0;

			for (int i = 0; i < randomNums.Length; i++)
			{
				int temp = randomNums[i];

				if (counter == 2)
				{
					break;
				}
				else
				{
					if (temp % 2 == 0)
					{
						evenArr[i] = temp;
						counter++;
					}
				}
			}

			return evenArr;
		}
		

		static int[] LastOdd(int elements, int[] randomNums)
		{
			int[] oddArr = new int[elements];
			int counter = 0;

			for (int i = randomNums.Length - 1; i > 0; i--)
			{
				int temp = randomNums[i];

				if (counter == 2)
				{
					break;
				}
				else
				{
					if (temp % 2 != 0)
					{
						oddArr[i] = temp;
						counter++;
					}
				}
			}

			return oddArr;
		}

		static int[] LastEven(int elements, int[] randomNums)
		{
			int[] evenArr = new int[elements];
			int counter = 0;

			for (int i = randomNums.Length - 1; i >= 0; i--)
			{
				int temp = randomNums[i];

				if (counter == 2)
				{
					break;
				}
				else
				{
					if (temp % 2 == 0)
					{
						evenArr[i] = temp;
						counter++;
					}
				}
			}

			return evenArr;
		}		
	}
}
