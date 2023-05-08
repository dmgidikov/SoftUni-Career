namespace OddLines
{
    internal class OddLines
    {
        static void Main()
        {
            var inputFilePath = @"..\..\..\Files\input.txt";
            string outputFilePath = @"..\..\..\Files\output.txt";

            var reader = new StreamReader(inputFilePath);
            var writer = new StreamWriter(outputFilePath);
            var counter = 0;

            while (true)
            {
                var line = reader.ReadLine();                

                if (counter % 2 == 1)
                {
                    writer.WriteLine(line);
                }

                counter++;
            }
        }
    }
}