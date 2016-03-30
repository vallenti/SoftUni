namespace HotelBookingSystem.Test
{
    using Models;
    using Interfaces;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Moq;
    using Controllers;
    using Data;

    [TestClass]
    public class RoomsControllerTest
    {

        [TestMethod]
        public void AddRoom_ShouldPass()
        {
            const string expected = "The room with ID 3 has been created successfully.";
            var admin = new User("admin", "admin123", Roles.VenueAdmin);
            var venue = new Venue("parvoto", "sofiqta", "description", admin);
            
            var mockedData = new Mock<IHotelBookingSystemData>();
            mockedData.Setup(d => d.Venues.Get(It.IsAny<int>())).Returns(venue);
            mockedData.Setup(p => p.Rooms).Returns(new Repository<Room>());

            var controller = new RoomsController(mockedData.Object, admin);

            controller.Add(1, 2, 30.00m);
            controller.Add(2, 2, 30.00m);
            var result = controller.Add(3, 2, 30.00m).Display();

            Assert.AreEqual(expected, result);
        }
    }
}
