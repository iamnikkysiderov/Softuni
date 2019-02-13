using System;
using System.Collections.Generic;
using System.Text;
using System.Net;

namespace HandmadeHTTPServer.Server.Http.Response
{
    public class NotFoundResponse : HttpResponse
    {
        public NotFoundResponse()
        {
            this.StatusCode = HttpStatusCode.NotFound;
        }
    }
}
