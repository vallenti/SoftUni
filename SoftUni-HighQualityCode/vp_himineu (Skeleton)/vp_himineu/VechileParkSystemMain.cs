namespace VehicleParkSystem
{
    using System.Globalization;
    using System.Threading;
    using Core;

    static class VechileParkSystemMain
    {
        static void Main()
        {
                Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
                var engine = new Engine();
                engine.Run();
        }
    }
}