namespace ListyIterator
{
    public class StartUp
    {
        static void Main()
        {
            var data = new List<ListyIterator<string>>();

            while (true)
            {
                var input = Console.ReadLine().Split();

                if (input[0] == "Create")
                {
                    for (int i = 1; i < input.Length; i++)
                    {
                        var element = new ListyIterator<string>(input[i]);
                        data.Add(element);


                    }
                }
                else if (input[0] == "End")
                {
                    break;
                }
                else if (input[0] == "HasNext")
                {

                }
                else if (input[0] == "Print")
                {

                }
                else if (input[0] == "Move")
                {

                }
            }
        }
    }
}