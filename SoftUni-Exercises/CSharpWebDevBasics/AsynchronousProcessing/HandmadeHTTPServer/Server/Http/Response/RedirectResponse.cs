using HandmadeHTTPServer.Server.Http.Exceptions;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace HandmadeHTTPServer.Server.Http.Response
{
    public class RedirectResponse : HttpResponse
    {
        public RedirectResponse(string redirectUrl)
        {
            CoreValidator.ThrowIfNullOrEmpty(redirectUrl, nameof(redirectUrl));

            this.StatusCode = HttpStatusCode.Found;
            this.Headers.Add(new HttpHeader("Location", redirectUrl));
        }
    }
}
