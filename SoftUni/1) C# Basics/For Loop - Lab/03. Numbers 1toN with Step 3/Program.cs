﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Numbers_1toN_with_Step_3
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int someRandomNumber = int.Parse(Console.ReadLine());

			for (int i = 1; i <= someRandomNumber; i+=3)
			{
				Console.WriteLine(i);
			}
		}
	}
}
