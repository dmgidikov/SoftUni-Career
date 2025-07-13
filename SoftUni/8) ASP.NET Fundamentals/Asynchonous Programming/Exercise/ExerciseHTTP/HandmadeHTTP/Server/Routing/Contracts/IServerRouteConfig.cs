namespace HandmadeHTTP.Server.Routing.Contracts
{
    using Enums;

    public interface IServerRouteConfig
    {
        IDictionary<HttpRequestMethod, IDictionary<string, IRoutingContext>> Routes { get; }

        ICollection<string> AnonymousPaths { get; }
    }
}