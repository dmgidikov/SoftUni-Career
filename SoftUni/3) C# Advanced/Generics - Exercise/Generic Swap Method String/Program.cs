namespace Generic_Swap_Method_String
{
    public class Program
    {
        static void Main()
        {
            var rotations = int.Parse(Console.ReadLine());

            var list = new List<string>();

            for (int i = 0; i < rotations; i++)
            {
                var input = Console.ReadLine();
                list.Add(input);
            }

            var slapList = new Slap<string>(list);

            var command = Console.ReadLine().Split();

            var first = int.Parse(command[0]);
            var second = int.Parse(command[1]);

            slapList.Swap(list, first, second);

            Console.WriteLine(slapList);
        }
    }
}