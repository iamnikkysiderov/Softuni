using System;
using System.Collections.Generic;
using System.Text;
using HandmadeHTTPServer.Server.Http.Contracts;

namespace HandmadeHTTPServer.Server.Handlers
{
    public class GetHandler : RequestHandler
    {
        public GetHandler(Func<IHttpRequest, IHttpResponse> handlingFunc) : base(handlingFunc) { }
    }
}
