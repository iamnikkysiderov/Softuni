using HandmadeHTTPServer.Server.Routing.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace HandmadeHTTPServer.Server.Contracts
{
    public interface IApplication
    {
        void Configure(IAppRouteConfig appRouteConfig);
    }
}
