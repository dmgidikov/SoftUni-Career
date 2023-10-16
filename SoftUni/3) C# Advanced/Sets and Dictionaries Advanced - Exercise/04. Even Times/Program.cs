namespace _04._Even_Times
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var rotations = int.Parse(Console.ReadLine());

            var dict = new Dictionary<double, double>();

            for (int i = 0; i < rotations; i++)
            {
                var num = int.Parse(Console.ReadLine());

                if (dict.ContainsKey(num) == false)
                {
                    dict[num] = 0;
                }

                dict[num]++;
            }

            foreach (var num in dict)
            {
                if (num.Value % 2 == 0)
                {
                    Console.WriteLine(num.Key);
                }
            }
        }
    }
}