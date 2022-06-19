using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Tribonacci_Sequence
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int num = int.Parse(Console.ReadLine());
			int[] nums = new int[Math.Max(num, 3)];

			nums[0] = 1;
			nums[1] = 1;
			nums[2] = 2;

			for (int i = 3; i < nums.Length; i++)
			{
				int temp = nums[i];

				for (int j = i; j >= i - 3; j--)
				{
					temp+= nums[j];
				}

				nums[i] = temp;
			}

			PrintElement(num, nums);
		}

		static void PrintElement(int num, int[] nums)
		{
			for (int i = 0; i < num; i++)
			{
				Console.Write(nums[i] + " ");
			}
		}
	}
}
