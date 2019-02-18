using System;
using System.Collections.Generic;
using System.Text;

namespace Logger
{
    public interface IAppender
    {
        void Append(string dateTime, string reportLevel, string message);
    }
}
