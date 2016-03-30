namespace LoggerApp.Appenders
{
    using System;
    using Interfaces;

    public abstract class Appender : IAppender
    {
        private ILayout layout;

        protected Appender(ILayout layout)
        {
            this.Layout = layout;
            this.ReportLevel = ReportLevel.Info;
        }

        public ILayout Layout
        {
            get { return this.layout; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException(
                        "Layout cannot be null");
                }

                this.layout = value;
            }
        }

        public ReportLevel ReportLevel { get; set; }

        public abstract void Append(string message, ReportLevel level, DateTime date);
    }
}
