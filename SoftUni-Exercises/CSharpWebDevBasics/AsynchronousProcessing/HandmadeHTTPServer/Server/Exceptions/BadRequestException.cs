using System;
using System.Collections.Generic;
using System.Text;

namespace HandmadeHTTPServer.Server.Exceptions
{
    public class BadRequestException : Exception
    {
        private const string invalidRequestMessage = "Request is not valid.";

        public static object ThrowFromInvalidRequest()
            => throw new BadRequestException(invalidRequestMessage);

        public BadRequestException(string message) : base(message) { }
    }
}
