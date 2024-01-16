namespace StudentInformation
{
    public class StartUp
    {
        public static void Main()
        {
            var studentName = Console.ReadLine();
            var studentAge = int.Parse(Console.ReadLine()); 
            var avarageStudentGrade = double.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {studentName}, Age: {studentAge}, Grade: {avarageStudentGrade}");
        }
    }
}