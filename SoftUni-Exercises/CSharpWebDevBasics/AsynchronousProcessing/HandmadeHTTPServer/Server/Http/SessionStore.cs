using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.Concurrent;

namespace HandmadeHTTPServer.Server.Http
{
    public static class SessionStore
    {
        public const string SessionCookieKey = "MY_SID";

        private static readonly ConcurrentDictionary<string, HttpSession> sessions = new ConcurrentDictionary<string, HttpSession>();

        public static HttpSession Get(string id)
            => sessions.GetOrAdd(id, _ => new HttpSession(id));
    }
}
