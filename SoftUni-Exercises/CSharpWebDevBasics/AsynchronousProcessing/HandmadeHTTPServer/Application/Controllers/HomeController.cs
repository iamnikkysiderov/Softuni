using HandmadeHTTPServer.Server.Http.Contracts;
using HandmadeHTTPServer.Server.Http.Response;
using HandmadeHTTPServer.Server.Http;
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
            var response = new ViewResponse(System.Net.HttpStatusCode.OK, new IndexView());

            response.Cookies.Add(new HttpCookie("lang", "en"));

            return response;
        }

        // Get /testsession
        public IHttpResponse SessionTest(IHttpRequest req)
        {
            var session = req.Session;

            const string sessionDateKey = "saved_date";

            if (session.Get(sessionDateKey) == null)
            {
                session.Add(sessionDateKey, DateTime.UtcNow);
            }

            return new ViewResponse(System.Net.HttpStatusCode.OK, new SessionTestView(session.Get<DateTime>(sessionDateKey)));
        }
    }
}
