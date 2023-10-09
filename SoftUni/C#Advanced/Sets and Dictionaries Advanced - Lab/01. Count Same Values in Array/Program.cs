namespace _01._Count_Same_Values_in_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split().Select(double.Parse).ToArray();

            var countValues = new Dictionary<double, int>();

            foreach (var num in nums)
            {
                if (countValues.ContainsKey(num) == false)
                {
                    countValues[num] = 0;
                }

                countValues[num]++;
            }

            foreach (var kvp in countValues)
            {
                var num = kvp.Key;
                var values = kvp.Value;

                Console.WriteLine($"{num} - {values} times");
            }
        }
    }
}