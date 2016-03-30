namespace TDDMicroExercises.TirePressureMonitoringSystem
{
    public class Alarm
    {
        private const double LowPressureThreshold = 17;
        private const double HighPressureThreshold = 21;

        private readonly Sensor sensor = new Sensor();

        private bool isAlarmOn = false;

        public Alarm(Sensor sensor)
        {
            this.sensor = sensor;
        }

        public void Check()
        {
            double psiPressureValue = sensor.PopNextPressurePsiValue();

            if (psiPressureValue < LowPressureThreshold || psiPressureValue > HighPressureThreshold)
            {
                isAlarmOn = true;
            }
        }

        public bool IsAlarmOn
        {
            get { return isAlarmOn; }
        }
    }
}
