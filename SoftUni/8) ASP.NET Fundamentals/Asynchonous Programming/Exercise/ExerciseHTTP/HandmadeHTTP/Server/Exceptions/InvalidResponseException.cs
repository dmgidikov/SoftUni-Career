namespace HandmadeHTTP.Server.Exeptions
{
    public class InvalidResponseException : Exception
    {
        public InvalidResponseException(string message)
            : base(message)
        {
        }
    }
}