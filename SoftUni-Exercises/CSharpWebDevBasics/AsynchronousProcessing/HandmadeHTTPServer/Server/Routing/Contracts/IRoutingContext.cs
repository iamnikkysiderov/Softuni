using HandmadeHTTPServer.Server.Handlers;
using System;
using System.Collections.Generic;
using System.Text;

namespace HandmadeHTTPServer.Server.Routing.Contracts
{
    public interface IRoutingContext
    {
        IEnumerable<string> Parameters { get; }

        RequestHandler Handler { get; }
    }
}
