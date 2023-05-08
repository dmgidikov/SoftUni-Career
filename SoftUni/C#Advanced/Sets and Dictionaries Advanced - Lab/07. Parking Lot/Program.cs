namespace _07._Parking_Lot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var licensePlates = new HashSet<string>();

            while (true)
            {
                var input = Console.ReadLine().Split(", ");

                if (input[0] == "END")
                {
                    if (licensePlates.Any())
                    {
                        foreach (var plate in licensePlates)
                        {
                            Console.WriteLine(plate);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Parking Lot is Empty");
                    }

                    break;
                }
                else
                {
                    var commnad = input[0];
                    var licensePlate = input[1];

                    if (commnad == "IN")
                    {
                        licensePlates.Add(licensePlate);
                    }
                    else if (commnad == "OUT")
                    {
                        if (licensePlates.Contains(licensePlate))
                        {
                            licensePlates.Remove(licensePlate);
                        }
                    }
                }
            }
        }
    }
}