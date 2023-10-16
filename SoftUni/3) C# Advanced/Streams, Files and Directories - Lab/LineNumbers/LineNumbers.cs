namespace LineNumbers
{
    public class LineNumbers
    {
        static void Main()
        {
            using var reader = new StreamReader(@"..\..\..\Files\input.txt");
            using var writer = new StreamWriter(@"..\..\..\Files\output.txt");

            var counter = 1;

            while (true)
            {
                var line = reader.ReadLine();

                if (line == null)
                {
                    break;
                }

                var newLine = $"{counter}. {line}";
                writer.WriteLine(newLine);

                counter++;
            }
        }
    }
}