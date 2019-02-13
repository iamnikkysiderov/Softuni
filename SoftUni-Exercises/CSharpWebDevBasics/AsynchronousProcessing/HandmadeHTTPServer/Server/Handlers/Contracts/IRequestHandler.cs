using HandmadeHTTPServer.Server.Http.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace HandmadeHTTPServer.Server.Handlers.Contracts
{
    public interface IRequestHandler
    {
        IHttpResponse Handle(IHttpContext context);
    }
}
