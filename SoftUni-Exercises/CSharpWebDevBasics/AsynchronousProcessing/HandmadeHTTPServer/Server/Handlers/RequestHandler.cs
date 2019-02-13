using HandmadeHTTPServer.Server.Handlers.Contracts;
using HandmadeHTTPServer.Server.Http;
using HandmadeHTTPServer.Server.Http.Contracts;
using HandmadeHTTPServer.Server.Http.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace HandmadeHTTPServer.Server.Handlers
{
    public class RequestHandler : IRequestHandler
    {
        private readonly Func<IHttpRequest, IHttpResponse> handlingFunc;

        protected RequestHandler(Func<IHttpRequest, IHttpResponse> handlingFunc)
        {
            CoreValidator.ThrowIfNull(handlingFunc, nameof(handlingFunc));

            this.handlingFunc = handlingFunc;
        }

        public IHttpResponse Handle(IHttpContext context)
        {
            var response = this.handlingFunc(context.Request);

            response.Headers.Add(new HttpHeader("Content-Type", "text/plain"));

            return response;
        }
    }
}
