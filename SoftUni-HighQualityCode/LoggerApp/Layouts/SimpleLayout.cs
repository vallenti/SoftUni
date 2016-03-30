namespace LoggerApp.Layouts
{
    using System;
    using Interfaces;

    public class SimpleLayout : ILayout
    {
        public string Format(string msg, ReportLevel level, DateTime date)
        {
            return string.Format("{0} - {1} - {2}",
                date, level, msg);
        }
    }
}
