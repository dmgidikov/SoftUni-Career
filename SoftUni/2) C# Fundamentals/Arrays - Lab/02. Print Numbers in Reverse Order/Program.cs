﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Print_Numbers_in_Reverse_Order
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int randomNumber = int.Parse(Console.ReadLine());

			int[] numbers = new int[randomNumber];

			for (int i = 0; i < numbers.Length; i++)
			{
				int currentNumber = int.Parse(Console.ReadLine());
				numbers[i] = currentNumber;
			}

			for (int i = numbers.Length-1; i >= 0; i--)
			{
				Console.Write(numbers[i] + " ");
			}
				
		}
	}
}
