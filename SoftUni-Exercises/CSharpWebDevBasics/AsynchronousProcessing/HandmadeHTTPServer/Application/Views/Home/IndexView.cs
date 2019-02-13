using HandmadeHTTPServer.Server.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace HandmadeHTTPServer.Application.Views.Home
{
    public class IndexView : IView
    {
        public string View() => "<h1>Welcome!<h1>";
    }
}
