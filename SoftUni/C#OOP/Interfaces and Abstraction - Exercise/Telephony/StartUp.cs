namespace Telephony
{
    public class StartUp
    {
        public static void Main()
        {
            var nums = Console.ReadLine();
            var adresses = Console.ReadLine();

            var smartphone = new Smartphone(nums, adresses);

            smartphone.Call();
            smartphone.BrowseInIntertnet();
        }
    }
}