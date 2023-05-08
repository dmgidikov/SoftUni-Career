namespace _05._Count_Symbols
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();

            var dict = new SortedDictionary<char, int>();

            foreach (var sym in text)
            {
                if (dict.ContainsKey(sym) == false)
                {
                    dict[sym] = 0;
                }

                dict[sym]++;
            }

            foreach (var sym in dict)
            {
                Console.WriteLine($"{sym.Key}: {sym.Value} time/s");
            }
        }
    }
}