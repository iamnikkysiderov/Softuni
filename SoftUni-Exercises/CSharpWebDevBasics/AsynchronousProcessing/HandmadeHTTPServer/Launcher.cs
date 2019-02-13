using HandmadeHTTPServer.Application;
using HandmadeHTTPServer.Server;
using HandmadeHTTPServer.Server.Contracts;
using HandmadeHTTPServer.Server.Routing;
using System;

namespace HandmadeHTTPServer
{
    class Launcher : IRunnable
    {
        static void Main(string[] args)
        {
            new Launcher().Run();
        }

        public void Run()
        {
            var mainApplication = new MainApplication();
            var appRouteConfig = new AppRouteConfig();
            mainApplication.Configure(appRouteConfig);
            var webServer = new WebServer(8080, appRouteConfig);
            webServer.Run();
        }
    }
}
