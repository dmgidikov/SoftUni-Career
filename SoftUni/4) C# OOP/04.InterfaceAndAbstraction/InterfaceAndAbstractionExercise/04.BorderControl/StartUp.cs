namespace BorderControl
{
    public class StartUp
    {
        public static void Main()
        {
            var membersIDs = new List<string>();

            while (true)
            {
                var input = Console.ReadLine();

                if (input == "End")
                {
                    break;
                }

                var args = input.Split();

                if (args.Length == 2)
                {
                    var robot = new Robot(args[1], args[0]);
                    var robotId = robot.Id;
                    membersIDs.Add(robotId);
                }
                else if (args.Length == 3)
                {
                    var citizen = new Citizen(args[2], args[0], int.Parse(args[1]));
                    var citizenId = citizen.Id;
                    membersIDs.Add(citizenId);
                }
            }

            var magicNumber = Console.ReadLine();

            foreach (var id in membersIDs)
            {
               var membersIdLast3digits = id.Substring(id.Length - 3, 3);

                if (membersIdLast3digits.Equals(magicNumber))
                {
                    Console.WriteLine(id);
                }
            }
        }
    }
}