using System;
using System.Collections.Generic;
using System.Text;

namespace HandmadeHTTPServer.Server.Http.Contracts
{
    public interface IHttpContext
    {
        IHttpRequest Request { get; }
    }
}
