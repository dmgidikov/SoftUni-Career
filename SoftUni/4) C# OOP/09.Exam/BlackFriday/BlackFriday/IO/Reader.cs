namespace BlackFriday.IO
{
    using Contracts;

    public class Reader : IReader
    {
        public string ReadLine() => Console.ReadLine();
    }
}