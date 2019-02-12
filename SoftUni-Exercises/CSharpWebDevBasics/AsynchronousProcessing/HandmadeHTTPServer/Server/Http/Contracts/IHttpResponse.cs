﻿using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace HandmadeHTTPServer.Server.Http.Contracts
{
    public interface IHttpResponse
    {
        HttpStatusCode StatusCode { get; }

        HttpHeaderCollection Headers { get; }
    }
}
