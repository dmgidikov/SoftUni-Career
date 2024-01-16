namespace Login
{
    public class Program
    {
        public static void Main()
        {
            string userName = Console.ReadLine();
            string password = string.Empty;

            for (int i = 0; i < userName.Length; i++)
            {
                password += userName[userName.Length - i - 1];
            }

            var counter = 0;

            while (true)
            {
                var input = Console.ReadLine();

                if (input == password)
                {
                    Console.WriteLine($"User {userName} logged in.");
                    break;
                }
                else if (input != password)
                {

                    counter++;
                    if (counter > 3)
                    {
                        Console.WriteLine($"User {userName} blocked!");
                        break;
                    }

                    Console.WriteLine("Incorrect password. Try again.");
                }
            }
        }
    }
}
