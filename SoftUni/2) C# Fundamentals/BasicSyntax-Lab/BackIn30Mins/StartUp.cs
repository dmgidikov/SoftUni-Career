namespace BackIn30Mins
{
    public class StartUp
    {
        public static void Main()
        {
            var hours = int.Parse(Console.ReadLine());
            var minutes = int.Parse(Console.ReadLine()) + 30;

            if(minutes > 60)
            {
                minutes -= 60;
                hours++;
            }

            if(hours > 23)
            {
                hours -= 24;
            }

            Console.WriteLine($"{hours}:{minutes:d2}");
        }
    }
}
