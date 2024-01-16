namespace Messages
{
    public class StartUp
    {
        public static void Main()
        {
            int inputNumbers = int.Parse(Console.ReadLine());

            string output = string.Empty;

            for (int i = 0; i < inputNumbers; i++)
            {
                string currentNum = Console.ReadLine();

                int digitNumber = currentNum.Length;
                int currentNumAsInt = int.Parse(currentNum);
                int mainDigit = currentNumAsInt % 10;

                if (mainDigit == 0)
                {
                    output += " ";
                }
                else
                {
                    int offset = (mainDigit - 2) * 3;

                    if (mainDigit == 8 || mainDigit == 9)
                    {
                        offset++;
                    }

                    int current = offset + (digitNumber - 1);
                    int total = current + 97;
                    char totalAsChar = (char)total;
                    output += totalAsChar;
                }
            }

            Console.WriteLine(output);
        }
    }
}
