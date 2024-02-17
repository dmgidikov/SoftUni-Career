using System.Net;

namespace URLDecode
{
    public class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var urlDecode = WebUtility.UrlDecode(input);
            Console.WriteLine(urlDecode);
        }
    }
}
