namespace ReverseString
{
    public class Program
    {
        public static void Main()
        {
            string randomString = Console.ReadLine();

            string reversString = string.Empty;

            for (int i = randomString.Length - 1; i >= 0; i--)
            {
                char symbol = randomString[i];
                reversString += symbol;
            }

            Console.WriteLine(reversString);
        }
    }
}
