using System.Net;

namespace ValidateURL
{
    public class Program
    {
        public static void Main()
        {
            var url = Console.ReadLine();

            var urlDecode = WebUtility.UrlDecode(url);

            var parsedUrl = new Uri(urlDecode);

            var protocol = parsedUrl.Scheme;
            var host = parsedUrl.Host;
            var port = parsedUrl.Port;
            var path = parsedUrl.AbsolutePath;
            var queryString = parsedUrl.Query;
            var fragments = parsedUrl.Fragment;

            if (string.IsNullOrEmpty(protocol) || string.IsNullOrEmpty(host) ||
                port == null || string.IsNullOrEmpty(path) || path == "/")
            {
                Console.WriteLine("Invalid URL");
            }
            else
            {
                Console.WriteLine($"Protocol: {protocol}");
                Console.WriteLine($"Host: {host}");
                Console.WriteLine($"Port: {port}");
                Console.WriteLine($"Path: {path}");
                Console.WriteLine($"Query: {queryString}");
                Console.WriteLine($"Fragments: {fragments}");
            }           
        }
    }
}
