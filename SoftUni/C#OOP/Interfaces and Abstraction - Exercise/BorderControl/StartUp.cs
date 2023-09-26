namespace BorderControl
{
    public class StartUp
    {
        public static void Main()
        {
            var invaders = new List<Invaders>();

            while (true)
            {
                var input = Console.ReadLine().Split();

                if (input[0] == "End")
                {
                    break;
                } 
                else if(input[0] == "Robot")
                {
                    var robot = new Robot(input[1], input[2]);
                    invaders.Add(robot);
                }
                else if (input[0] == "Pet")
                {
                    var pet = new Pet(input[1], input[2]);
                    invaders.Add(pet);
                }
                else 
                {
                    var citizen = new Citizen(input[1], int.Parse(input[2]), input[3], input[4]);
                    invaders.Add(citizen);
                }
            }

            var year = Console.ReadLine();

            foreach (var invader in invaders)
            {
                var birthdayYear = invader.Birthday.Split('/');

                if (birthdayYear[2] == year)
                {
                    Console.WriteLine(invader.Birthday);
                }
            }
        }
    }
}