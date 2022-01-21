using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebsite.Core.CrossCuttingConcerns.Logging
{
    public class CustomLoggerFactory : ILoggerProvider
    {
      
        public ILogger CreateLogger(string categoryName)
        {
            return new CustomLogger();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }

    public class CustomLogger : ILogger
    {
        public IDisposable BeginScope<TState>(TState state)
        {
            return null;
        }

        public bool IsEnabled(LogLevel logLevel)
        {
            return true;
        }

        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception, string> formatter)
        {
            string logMsg = formatter(state, exception);

            logMsg = $"[{DateTime.Now:dd.MM.yyyy HH:mm:ss}] {logMsg}";
        }
    }
}
