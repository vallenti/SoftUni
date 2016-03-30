namespace LoggerApp
{
    using System;
    using Interfaces;
    using System.Collections.Generic;

    public class Logger : ILogger
    {
        private ICollection<IAppender> appenders;

        public Logger(params IAppender[] appender)
        {
            this.appenders = new List<IAppender>(appender);
        }

        public IEnumerable<IAppender> Appenders { get; private set; }

        public void Info(string msg)
        {
            this.Log(msg, ReportLevel.Info);
        }

        public void Warn(string msg)
        {
            this.Log(msg, ReportLevel.Warn);
        }

        public void Error(string msg)
        {
            this.Log(msg, ReportLevel.Error);
        }

        public void Critical(string msg)
        {
            this.Log(msg, ReportLevel.Critical);
        }

        public void Fatal(string msg)
        {
           this.Log(msg, ReportLevel.Fatal);
        }

        private void Log(string msg, ReportLevel level)
        {
            var date = DateTime.Now;
            foreach (var appender in this.appenders)
            {
                appender.Append(msg, level, date);
            }
        }
    }
}
