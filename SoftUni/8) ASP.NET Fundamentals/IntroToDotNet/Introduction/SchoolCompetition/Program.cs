namespace SchoolCompetition
{
    public class Program
    {
        public static void Main()
        {
            var studentSubject = new Dictionary<string, SortedSet<string>>();
            var studentPoints = new Dictionary<string, int>();

            while (true)
            {
                var input = Console.ReadLine();

                if (input == "END")
                {
                    break;
                }

                var data = input.Split();

                var studentName = data[0];
                var subject = data[1];
                var points = int.Parse(data[2]);

                if (studentSubject.ContainsKey(studentName) == false)
                {
                    studentSubject[studentName] = new SortedSet<string>();
                }

                studentSubject[studentName].Add(subject);

                if (studentPoints.ContainsKey(studentName) == false)
                {
                    studentPoints[studentName] = 0;
                }

                studentPoints[studentName] += points;
            }

            var orderedStudents = studentPoints
                .OrderByDescending(kvp => kvp.Value)
                .ThenBy(kvp => kvp.Key);

            foreach (var student in orderedStudents)
            {
                var studentName = student.Key;

                var subjecs = string.Join(", ", studentSubject[studentName]);

                Console.WriteLine($"{student.Key}: {student.Value} [{subjecs}]");
            }
        }
    }
}
