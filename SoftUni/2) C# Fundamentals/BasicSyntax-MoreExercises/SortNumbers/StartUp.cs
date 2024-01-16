namespace SortNumbers
{
    public class StartUp
    {
        public static void Main()
        {
            var nums = new int[3];

            for (int i = 0; i < nums.Length; i++) 
            {
                nums[i] = int.Parse(Console.ReadLine());    
            }

            Array.Sort(nums);
            var result = nums.Reverse();

            foreach (var num in result)
            {
                Console.WriteLine(num);
            }
        }
    }
}
