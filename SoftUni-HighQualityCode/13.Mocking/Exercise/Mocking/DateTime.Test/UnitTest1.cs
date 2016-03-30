namespace DateTime.Test
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Moq;
    using TDDMicroExercises.TirePressureMonitoringSystem;

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            var mock = new Mock<Sensor>();
            mock.Setup(s => s.PopNextPressurePsiValue())
                .Returns(19d);

            Sensor sensor = mock.Object;
            Alarm alarm = new Alarm(sensor);

            //Act
            alarm.Check();

            //Assert
            Assert.AreEqual(false, alarm.IsAlarmOn,"alarm was triggered on");
        }
    }
}
