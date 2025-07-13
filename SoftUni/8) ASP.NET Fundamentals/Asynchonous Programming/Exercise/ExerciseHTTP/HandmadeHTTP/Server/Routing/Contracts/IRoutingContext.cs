namespace HandmadeHTTP.Server.Routing.Contracts
{
    using Handlers;

    public interface IRoutingContext
    {
        IEnumerable<string> Parameters { get; }

        RequestHandler Handler { get; }
    }
}