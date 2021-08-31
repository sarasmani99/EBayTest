using NLog;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ebay.Automation.Common
{    public interface IAppLogger
    {
        void Info(string message);
        void Debug(string message);
        void Error(string message);
        void Error(string message, Exception ex);
        string Id { get; set; }
    }
    public class AppLogger : IAppLogger
    {
        private ILogger _logger;
        public string Id { get; set; }

        public AppLogger(ILogger logger, string id)
        {
            _logger = logger;
            Id = id;
        }

        string FormatMessage(string message)
        {
            return string.Format("[{0}] {1}", Id, message);
        }

        LogEventInfo CreateLogEvent(string message, LogLevel level)
        {
            LogEventInfo info = new LogEventInfo();
            info.Message = message;
            info.Properties["LoggerId"] = Id;
            info.Level = level;
            return info;
        }

        public void Info(string message)
        {
            _logger.Log(typeof(AppLogger), CreateLogEvent(message, LogLevel.Info));
        }

        public void Debug(string message)
        {
            _logger.Log(typeof(AppLogger), CreateLogEvent(message, LogLevel.Debug));
        }

        public void Error(string message)
        {
            _logger.Log(typeof(AppLogger), CreateLogEvent(message, LogLevel.Error));
        }

        public void Error(string message, Exception ex)
        {
            var l = CreateLogEvent(message, LogLevel.Error);
            l.Exception = ex;
            _logger.Log(typeof(AppLogger), l);
        }
    }
}
