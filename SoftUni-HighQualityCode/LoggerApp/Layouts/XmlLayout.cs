namespace LoggerApp.Layouts
{
    using System;
    using System.Text;
    using Interfaces;

    public class XmlLayout : ILayout
    {
        public string Format(string msg, ReportLevel level, DateTime date)
        {
            var output = new StringBuilder();
            output.AppendLine("<log>");
            output.AppendLine("<message>" + msg + "</message>");
            output.AppendLine("<level>" + level + "</level>");
            output.AppendLine("<date>" + date + "</date>");
            output.AppendLine("</log>");

            return output.ToString();
        }
    }
}
