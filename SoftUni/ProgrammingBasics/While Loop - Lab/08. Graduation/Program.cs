using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Graduation
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string name = Console.ReadLine();

			int gradeCounter = 0;
			int markCounter = 0;
			decimal avarageGrade = 0;

			while (gradeCounter < 12)
			{
				decimal grade = decimal.Parse(Console.ReadLine());

				if (grade >= 4.00m)
				{
					avarageGrade += grade;
					gradeCounter++;
				}
				else
				{
					if (markCounter < 1)
					{
						markCounter++;
					}
					else
					{
						Console.WriteLine($"{name} has been excluded at {gradeCounter + 1} grade");
						break;
					}
				}
			}
			if (gradeCounter > 11)
			{
				Console.WriteLine($"{name} graduated. Average grade: {Math.Round((avarageGrade/12),2)}");
			}
		}
	}
}
