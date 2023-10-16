using System.Collections.Generic;

namespace _02._Average_Student_Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var inputs = int.Parse(Console.ReadLine());

            var studentGrades = new Dictionary<string, List<decimal>>();

            for (int i = 0; i < inputs; i++)
            {
                var input = Console.ReadLine().Split();

                var student = input[0];
                var grade = decimal.Parse(input[1]);

                if (studentGrades.ContainsKey(student) == false)
                {
                    studentGrades[student] = new List<decimal>();
                }

                studentGrades[student].Add(grade);
            }

            foreach (var (nameKey, gradeValues) in studentGrades)
            {
                var allGrades = string.Join(" ", gradeValues);
                var avgGrade = gradeValues.Average();

                Console.WriteLine($"{nameKey} -> {allGrades} (avg: {avgGrade:f2})");
            }
        }
    }
}