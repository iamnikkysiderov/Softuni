using HandmadeHTTPServer.Server.Handlers;
using HandmadeHTTPServer.Server.Http.Exceptions;
using HandmadeHTTPServer.Server.Routing.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace HandmadeHTTPServer.Server.Routing
{
    public class RoutingContext : IRoutingContext
    {
        public RoutingContext(RequestHandler handler, IEnumerable<string> parameters)
        {
            CoreValidator.ThrowIfNull(handler, nameof(handler));
            CoreValidator.ThrowIfNull(parameters, nameof(parameters));

            this.Handler = handler;
            this.Parameters = parameters;
        }

        public IEnumerable<string> Parameters { get; private set; }

        public RequestHandler Handler { get; private set; }
    }
}
