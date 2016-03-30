namespace LoggerApp.Interfaces
{
    using System;

    public interface ILayout
    {
        string Format(string msg, ReportLevel level, DateTime date);
    }
}
