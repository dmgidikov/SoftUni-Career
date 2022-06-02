using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.On_Time_for_the_Exam
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int examHour = int.Parse(Console.ReadLine());
			int examMinutes = int.Parse(Console.ReadLine());
			int arriveHour = int.Parse(Console.ReadLine());
			int arriveMinutes = int.Parse(Console.ReadLine());

			if (examHour > arriveHour)
			{
				int temp = examMinutes + 60;

				if (temp - arriveMinutes > 30)
				{
					if (examHour - arriveHour >= 1)
					{
						Console.WriteLine("Early");
						Console.WriteLine($"{examMinutes - arriveMinutes} " +
							$"hours before the start");
					}
					else
					{
						Console.WriteLine("Early");
						Console.WriteLine($"{examHour - arriveHour}:{(examMinutes - arriveMinutes)} " +
						$"hours before the start");
					}
				}
				else if (temp - arriveMinutes <= 30 || temp - arriveMinutes >= 0)
				{
					Console.WriteLine("On time");
					Console.WriteLine($"{(arriveMinutes - examMinutes)} minutes before the start");
				}
				else
				{
					if (examHour - arriveHour > 1)
					{
						Console.WriteLine("Late");
						Console.WriteLine($"{arriveMinutes - examMinutes:f2}hours after the start");

					}
					else
					{
						Console.WriteLine("Late");
						Console.WriteLine($"{arriveMinutes - examMinutes:f2}minutes after the start");
					}
				}
			}
			else if (examHour == arriveHour)
			{
				if (examMinutes < arriveMinutes)
				{
					Console.WriteLine("Late");
					Console.WriteLine($"{arriveMinutes - examMinutes} minutes after the start");
				}
				else if (examMinutes - arriveMinutes > 30)
				{
					Console.WriteLine("Early");
					Console.WriteLine($"{examMinutes - arriveMinutes} minutes before the start");
				}
				else
				{
					if (arriveMinutes == examMinutes)
					{
						Console.WriteLine("On time");
					}
					else
					{
						Console.WriteLine("On time");
						Console.WriteLine($"{examMinutes - arriveMinutes} before the start");
					}
				}
			}
			else
			{
				if (arriveHour - examHour < 0)
				{
					Console.WriteLine("Late");
					Console.WriteLine($"{arriveMinutes - examMinutes:f2} minutes after the start");
				}
				else
				{
					Console.WriteLine("Late");
					Console.WriteLine($"{arriveHour - examHour}:{arriveMinutes - examMinutes} hours after the start");
				}
			}
		}
	}
}      