

namespace LoggerApp
{
    using LoggerApp.Appenders;
    using LoggerApp.Interfaces;
    using LoggerApp.Layouts;

    public class AppStart
    {
        public static void Main()
        {
            ILayout simpleLayout = new SimpleLayout();
            IAppender consoleAppender =
                 new ConsoleAppender(simpleLayout);
            ILogger logger = new Logger(consoleAppender);

            logger.Error("Error parsing JSON.");
            logger.Info(string.Format("User {0} successfully registered.", "Pesho"));


            var fileAppender = new FileAppender(new XmlLayout());
            fileAppender.FilePath = "log.txt";

            logger = new Logger(consoleAppender, fileAppender);
            logger.Error("Error parsing JSON.");
            logger.Info(string.Format("User {0} successfully registered.", "Pesho"));
            logger.Warn("Warning - missing files.");



            consoleAppender.ReportLevel = ReportLevel.Error;

            logger = new Logger(consoleAppender);

            logger.Info("Everything seems fine");
            logger.Warn("Warning: ping is too high - disconnect imminent");
            logger.Error("Error parsing request");
            logger.Critical("No connection string found in App.config");
            logger.Fatal("mscorlib.dll does not respond");

        }
    }
}
