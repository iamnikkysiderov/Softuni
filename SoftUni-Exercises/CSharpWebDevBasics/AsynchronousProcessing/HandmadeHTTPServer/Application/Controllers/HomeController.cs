using HandmadeHTTPServer.Server.Http.Contracts;
using HandmadeHTTPServer.Server.Http.Response;
using System;
using System.Collections.Generic;
using System.Text;
using HandmadeHTTPServer.Application.Views.Home;

namespace HandmadeHTTPServer.Application.Controllers
{
    public class HomeController
    {
        public IHttpResponse Index()
        {
            return new ViewResponse(System.Net.HttpStatusCode.OK, new IndexView());
        }
    }
}
