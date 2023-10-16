namespace _03._Custom_Min_Function
{
    public class Program
    {
        static void Main(string[] args)
        {
            Func<List<double>, double> minNum = x => x.Min();

            var nums = Console.ReadLine().Split().Select(double.Parse).ToList();

            Console.WriteLine(minNum(nums));
        }
    }
}