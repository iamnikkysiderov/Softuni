using System;
using System.Collections.Generic;
using System.Text;

namespace HandmadeHTTPServer.Server.Http.Exceptions
{
    public class InvalidResponseException : Exception
    {
        public InvalidResponseException(string message) : base(message) { }
    }
}
