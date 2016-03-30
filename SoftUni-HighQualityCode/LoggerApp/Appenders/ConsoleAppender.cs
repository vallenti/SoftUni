namespace LoggerApp.Appenders
{
    using System;
    using Interfaces;

    public class ConsoleAppender : Appender
    {
        public ConsoleAppender(ILayout layout)
            : base(layout)
        {
        }

        public override void Append(string message, ReportLevel level, DateTime date)
        {
            if (level >= this.ReportLevel)
            {
                string output = this.Layout.Format(message, level, date);
                Console.WriteLine(output);
            }
        }
    }
}
