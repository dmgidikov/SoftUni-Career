namespace Vacation
{
    public class StartUp
    {
        public static void Main()
        {
            var groupMembers = int.Parse(Console.ReadLine());
            var groupType = Console.ReadLine();
            var dayOfTheWeek = Console.ReadLine();

            var ticketPrice = 0m;

            if (dayOfTheWeek == "Friday")
            {
                if (groupType == "Students")
                {
                    ticketPrice = 8.45m;
                }
                else if (groupType == "Business")
                {
                    ticketPrice = 10.9m;
                }
                else if (groupType == "Regular")
                {
                    ticketPrice = 15m;
                }
            }
            else if (dayOfTheWeek == "Saturday")
            {
                if (groupType == "Students")
                {
                    ticketPrice = 9.8m;
                }
                else if (groupType == "Business")
                {
                    ticketPrice = 15.6m;
                }
                else if (groupType == "Regular")
                {
                    ticketPrice = 20m;
                }
            }
            else if (dayOfTheWeek == "Sunday")
            {
                if (groupType == "Students")
                {
                    ticketPrice = 10.46m;
                }
                else if (groupType == "Business")
                {
                    ticketPrice = 16m;
                }
                else if (groupType == "Regular")
                {
                    ticketPrice = 22.5m;
                }
            }

            var ticketsMoney = groupMembers * ticketPrice;

            if (groupType == "Students" && groupMembers >= 30)
            {
                ticketsMoney -= ticketsMoney * 0.15m;
            }
            else if (groupType == "Business" && groupMembers >= 100)
            {
                ticketsMoney -= 10 * ticketPrice;
            }
            else if (groupType == "Regular" && (groupMembers >= 10 && groupMembers <= 20))
            {
                ticketsMoney -= ticketsMoney * 0.10m;
            }

            Console.WriteLine($"Total price: {ticketsMoney:f2}");

        }
    }
}
