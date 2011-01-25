﻿using System;

namespace Common.Logging
{
    public class LogManager
    {
        public static ILog GetLogger(Type type)
        {
            return new BrowserConsoleLogger(type.FullName, LogLevel.All, true, true, true, "u");
        }
    }
}
