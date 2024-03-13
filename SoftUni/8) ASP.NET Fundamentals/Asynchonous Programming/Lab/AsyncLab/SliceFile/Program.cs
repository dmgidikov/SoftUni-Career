namespace SliceFile
{
    public class Program
    {
        public static void Main()
        {

        }

        static void Slice(string sourceFile, string destinationPath, int parts)
        {
            if (Directory.Exists(destinationPath) == false)
            {
                Directory.CreateDirectory(destinationPath);
            }

            using (var source = new FileStream(sourceFile, FileMode.Open))
            {
                FileInfo fileInfo = new FileInfo(sourceFile);

                var parthLenght = (source.Length / parts) + 1;
                var currentByte = 0;

                for (int currentPart = 1; currentPart <= parts; currentPart++)
                {
                    var filePath = $"{destinationPath}/Part-{currentPart}{fileInfo.Extension}";

                    using (var destination = new FileStream(filePath, FileMode.Create))
                    {
                        var buffer = new byte[parthLenght];
                    }
                }
            }           
        }
    }
}
