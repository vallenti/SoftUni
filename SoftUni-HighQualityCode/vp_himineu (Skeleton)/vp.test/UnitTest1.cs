using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using VehicleParkSystem.Core;
using VehicleParkSystem.Models;
using VehicleParkSystem.Core.Commands;

namespace vp.test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var car = new Car("CA1234AA", "pesho", 3);
            var mockedData = new Mock<Database>();
            mockedData.Setup(d => d.VehiclesByLicensePlate[""]).Returns(car);

            var park = new VehiclePark(mockedData.Object, 1, 3);
            var vehicle = park.FindVehicle("CA1234AA");
            
        }
    }
}
