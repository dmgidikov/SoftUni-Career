namespace ExtractSpecialBytes
{
    internal class ExtractSpecialBytes
    {
        static void Main()
        {
            string binaryFilePath = @"..\..\..\Files\example.png";
            string bytesFilePath = @"..\..\..\Files\bytes.txt";
            string outputPath = @"..\..\..\Files\output.bin";

            var binaryFile = File.ReadAllBytes(@"..\..\..\Files\example.png");

        }
    }
}