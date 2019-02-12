using System;
using System.Collections.Generic;
using System.Text;

namespace HandmadeHTTPServer.Server.Http.Exceptions
{
    public class CoreValidator
    {
        public static void ThrowIfNull(object obj, string name)
        {
            if (obj is null)
            {
                throw new ArgumentException(name);
            }
        }

        public static void ThrowIfNullOrEmpty(string text, string name)
        {
            if (string.IsNullOrEmpty(text))
            {
                throw new ArgumentException($"{name} cannot be null or empty.", name);
            }
        }
    }
}
