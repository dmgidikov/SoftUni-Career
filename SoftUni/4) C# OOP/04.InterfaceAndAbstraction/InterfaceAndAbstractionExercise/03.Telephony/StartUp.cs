namespace _03.Telephony
{
    using Models;

    public class StartUp
    {
        public static void Main()
        {
            var numbersToCall = Console.ReadLine().Split().ToArray();
            var sitesToVisit = Console.ReadLine().Split().ToArray();

            var smartphone = new Smartphone();
            var stationaryPhone = new StationaryPhone();

            try
            {
                foreach (var number in numbersToCall)
                {
                    if (number.Length == 10)
                    {
                        smartphone.Call(number);
                        Console.WriteLine(smartphone.Call(number));
                    }
                    else if (number.Length == 7)
                    {
                        stationaryPhone.Call(number);
                        Console.WriteLine(stationaryPhone.Call(number));
                    }
                }

                foreach (var site in sitesToVisit)
                {
                    smartphone.Browse(site);
                    Console.WriteLine(smartphone.Browse(site));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}