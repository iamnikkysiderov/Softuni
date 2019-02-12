using System;
using System.Collections.Generic;
using System.Text;

namespace HandmadeHTTPServer.Server.Enums
{
    public enum HttpStatusCode
    {
        Ok = 200,
        MovedPermanently = 301,
        Found = 302,
        MovedTemporarily = 303,
        NotAuthorized = 401,
        NotFound = 404,
        InternalServerError = 500
    }
}
