using HandmadeHTTPServer.Server.Enums;
using HandmadeHTTPServer.Server.Handlers;
using System;
using System.Collections.Generic;
using System.Text;

namespace HandmadeHTTPServer.Server.Routing.Contracts
{
    public interface IAppRouteConfig
    {
        IReadOnlyDictionary<HttpRequestMethod, IDictionary<string, RequestHandler>> Routes { get; }

        void AddRoute(string route, RequestHandler handler);
    }
}
