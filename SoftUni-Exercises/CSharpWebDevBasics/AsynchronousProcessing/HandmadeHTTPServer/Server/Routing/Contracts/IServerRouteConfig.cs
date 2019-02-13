using HandmadeHTTPServer.Server.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace HandmadeHTTPServer.Server.Routing.Contracts
{
    public interface IServerRouteConfig
    {
        IDictionary<HttpRequestMethod, IDictionary<string, IRoutingContext>> Routes { get; }
    }
}
