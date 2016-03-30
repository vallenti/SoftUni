namespace LoggerApp.Interfaces
{
    using System;

    public interface IAppender
    {
        ILayout Layout { get; set; }
        ReportLevel ReportLevel { get; set; }

        void Append(string message, ReportLevel level, DateTime date);
    }
}
