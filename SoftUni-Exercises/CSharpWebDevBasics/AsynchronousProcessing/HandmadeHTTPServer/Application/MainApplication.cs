using HandmadeHTTPServer.Application.Controllers;
using HandmadeHTTPServer.Server.Contracts;
using HandmadeHTTPServer.Server.Handlers;
using HandmadeHTTPServer.Server.Routing.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace HandmadeHTTPServer.Application
{
    public class MainApplication : IApplication
    {
        public void Configure(IAppRouteConfig appRouteConfig)
        {
            appRouteConfig.Get("/", request => new HomeController().Index());

            appRouteConfig.Get("/testsession", request => new HomeController().SessionTest(request));

            appRouteConfig.Get("/users/{(?<name>[a-z]+)}", request => new HomeController().Index());
        }
    }
}
