namespace _03_Hospital
{
    public class StartUp
    {
        public static void Main()
        {
            while (true)
            {
                var input = Console.ReadLine();

                if (input == "output")
                {

                }
                else
                {
                    var hospitalData = input.Split();

                    var departmentName = hospitalData[0];
                    var doctorName = hospitalData[1];
                    var patientName = hospitalData[2];

                }

            }
        }
    }
}
