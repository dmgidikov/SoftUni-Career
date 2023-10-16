using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Refactor_Special_Numbers
{
	internal class Program
	{
		static void Main(string[] args)
		{
            int totalNumbers = int.Parse(Console.ReadLine());

            int sum = 0;
            bool isSpecialNum = false;

            for (int i = 1; i <= totalNumbers; i++)
            {
                int currentNumber = i;

                while (i > 0)
                {
                    sum += i % 10;
                    i /= 10;
                }

                isSpecialNum = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine("{0} -> {1}", currentNumber, isSpecialNum);
                sum = 0;
                i = currentNumber;
            }

        }
    }
}
