using System;
using TDDMicroExercises.TirePressureMonitoringSystem;

namespace Mocking
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Sensor();
            var a = new Alarm(s);

            Console.WriteLine(s.PopNextPressurePsiValue());
            a.Check();
            Console.WriteLine(a.IsAlarmOn);
        }
    }
}
