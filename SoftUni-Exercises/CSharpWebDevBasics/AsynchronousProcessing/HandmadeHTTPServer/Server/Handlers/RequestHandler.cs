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
            Object sendSessionId = null;

            if (!context.Request.Cookies.ContainsKey(SessionStore.SessionCookieKey))
            {
                var sessionId = Guid.NewGuid().ToString();

                context.Request.Session = SessionStore.Get(sessionId);

                sendSessionId = sessionId;
            }

            var response = this.handlingFunc(context.Request);

            if (sendSessionId != null)
            {
                response.Headers.Add("Set-Cookie", $"{SessionStore.SessionCookieKey}={sendSessionId}; HttpOnly; path=/");
            }

            response.Headers.Add(new HttpHeader("Content-Type", "text/html"));

            foreach (var cookie in response.Cookies)
            {
                response.Headers.Add("Set-Cookie", cookie.ToString());
            }

            return response;
        }
    }
}
