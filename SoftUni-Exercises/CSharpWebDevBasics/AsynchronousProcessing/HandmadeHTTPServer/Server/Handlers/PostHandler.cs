using System;
using System.Collections.Generic;
using System.Text;
using HandmadeHTTPServer.Server.Http.Contracts;

namespace HandmadeHTTPServer.Server.Handlers
{
    public class PostHandler : RequestHandler
    {
        public PostHandler(Func<IHttpRequest, IHttpResponse> handlingFunc) : base(handlingFunc) { }
    }
}
