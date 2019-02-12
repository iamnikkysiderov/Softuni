using HandmadeHTTPServer.Server.Http.Contracts;
using HandmadeHTTPServer.Server.Http.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace HandmadeHTTPServer.Server.Http
{
    public class HttpContext : IHttpContext
    {
        private readonly IHttpRequest request;

        public HttpContext(IHttpRequest request)
        {
            CoreValidator.ThrowIfNull(request, nameof(request));

            this.request = request;
        }

        public IHttpRequest Request => this.request;
    }
}
