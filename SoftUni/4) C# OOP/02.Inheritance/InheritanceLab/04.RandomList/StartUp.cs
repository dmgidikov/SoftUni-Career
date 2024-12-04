namespace _04.RandomList
{
    public class StartUp
    {
        public static void Main()
        {
            var randomList = new RandomList();

            for (int i = 0; i < 10; i++)
            {
                randomList.Add($"{i + 1}");
            }

            randomList.RandomString();

            foreach (var item in randomList)
            {
                Console.WriteLine(item);
            }
        }
    }
}