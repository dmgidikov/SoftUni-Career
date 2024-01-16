namespace StrongNumber
{
    public class StartUp
    {
        public static void Main()
        {
            var num = int.Parse(Console.ReadLine());
            string numAsString = num.ToString();

            var factorialSum = 0;

            for (int i = 0; i < numAsString.Length; i++)
            {
                string temp = numAsString[i].ToString();
                int tempInt = int.Parse(temp);

                var sum = 0;

                if (tempInt == 0 || tempInt == 1)
                {
                    sum += 1;
                }
                else if (tempInt == 2)
                {
                    sum += 2;
                }
                else
                {
                    for (int j = tempInt - 1; j > 0; j--)
                    {
                        sum += j;
                    }
                    sum *= tempInt;
                }

                factorialSum += sum;
            }

            if (factorialSum == num)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
