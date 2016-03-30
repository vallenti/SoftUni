namespace LoggerApp.Appenders
{
    using System;
    using System.IO;
    using Interfaces;

    public class FileAppender : Appender
    {
        private StreamWriter writer;

        public FileAppender(ILayout layout)
            : this(null, layout)
        {

        }

        public FileAppender(string path, ILayout layout)
            : base(layout)
        {
            this.FilePath = path;
        }

        public string FilePath { get; set; }

        public override void Append(string message, ReportLevel level, DateTime date)
        {
            if (level >= ReportLevel)
            {
                using (this.writer = new StreamWriter(this.FilePath, true))
                {
                    string output = this.Layout.Format(message, level, date);
                    this.writer.WriteLine(output);
                }
            }
        }
    }
}
