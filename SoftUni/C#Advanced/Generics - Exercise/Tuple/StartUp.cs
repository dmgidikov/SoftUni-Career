namespace Tuple
{
    public class StartUp
    {
        static void Main()
        {
            var firstInfo = Console.ReadLine().Split();
            var personName = $"{firstInfo[0]} {firstInfo[1]}";
            var personAdress = firstInfo[2];
            var personTown = string.Empty;

            if (firstInfo.Length > 4)
            {
                personTown = $"{firstInfo[3]} {firstInfo[4]}";
            }
            else
            {
                personTown = firstInfo[3];
            }

            var secondInfo = Console.ReadLine().Split();
            var secondPersonName = secondInfo[0];
            var beerLeters = int.Parse(secondInfo[1]);
            var condition = secondInfo[2];

            if (condition == "drunk")
            {
                condition = "True";
            }
            else
            {
                condition = "False";
            }

            var thirdInfo = Console.ReadLine().Split();
            var thirdName = thirdInfo[0];
            var accountBalance = double.Parse(thirdInfo[1]);
            var bankName = thirdInfo[2];

            var firstPersonInfo =
                new Threeuple<string, string, string>(personName, personAdress, personTown);
            var secondPersonInfo =
                new Threeuple<string, int, string>(secondPersonName, beerLeters, condition);
            var lastInfo =
                new Threeuple<string, double, string>(thirdName, accountBalance, bankName);

            Console.WriteLine(firstPersonInfo);
            Console.WriteLine(secondPersonInfo);
            Console.WriteLine(lastInfo);
        }
    }
}