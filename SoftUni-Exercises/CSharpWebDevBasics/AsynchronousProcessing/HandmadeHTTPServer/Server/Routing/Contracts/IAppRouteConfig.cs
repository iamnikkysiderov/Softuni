using HandmadeHTTPServer.Server.Enums;
using HandmadeHTTPServer.Server.Handlers;
using HandmadeHTTPServer.Server.Http.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace HandmadeHTTPServer.Server.Routing.Contracts
{
    public interface IAppRouteConfig
    {
        IReadOnlyDictionary<HttpRequestMethod, IDictionary<string, RequestHandler>> Routes { get; }

        void Get(string route, Func<IHttpRequest, IHttpResponse> handler);

        void Post(string route, Func<IHttpRequest, IHttpResponse> handler);

        void AddRoute(string route, RequestHandler handler);
    }
}
