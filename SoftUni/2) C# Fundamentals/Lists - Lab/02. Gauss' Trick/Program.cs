using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Gauss__Trick
{
	internal class Program
	{
		static void Main(string[] args)
		{
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> newNumbers = new List<int>();

            for (int i = 0; i < numbers.Count / 2; i++)
            {
                int firstNumber = numbers[i];
                int secondNumber = numbers[numbers.Count - 1 - i];
                int result = firstNumber + secondNumber;

                newNumbers.Add(result);
            }

            if (numbers.Count % 2 == 1)
            {
                int middleNumber = numbers[numbers.Count / 2];
                newNumbers.Add(middleNumber);
                Console.WriteLine(string.Join(" ", newNumbers));

            }
            else
            {
                Console.WriteLine(string.Join(" ", newNumbers));
            }
        }
	}
}
