using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Exam_Preparation
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int badMarks = int.Parse(Console.ReadLine());

			string lastSubject = string.Empty;
			int numberOfSubjects = 0;
			double avarageGrade = 0;
			double countBadMarks = 0;

			while (true)
			{
				string subject = Console.ReadLine();

				if (subject == "Enough")
				{
					Console.WriteLine($"Average score: {Math.Round((avarageGrade / numberOfSubjects), 2)}");
					Console.WriteLine($"Number of problems: {numberOfSubjects}");
					Console.WriteLine($"Last problem: {lastSubject}");
					break;
				}
				else
				{
					int mark = int.Parse(Console.ReadLine());

					if (mark <= 4.00)
					{
						countBadMarks++;
						numberOfSubjects++;
						avarageGrade += mark;

						if (countBadMarks == badMarks)
						{
							Console.WriteLine("You need a break, 2 poor grades.");
							break;
						}
					}
					else
					{
						numberOfSubjects++;
						avarageGrade += mark;
					}
				}
					lastSubject = subject;
			}
		}
	}
}
