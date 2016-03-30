using BuhtigIssueTracker.Core;
using BuhtigIssueTracker.Interfaces;
using System.Globalization;
using System.Threading;

class BuhtigIssueTrackerMain
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        IEngine engine = new Engine();
        engine.Run();
    }
}
