using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HotelBookingSystem.Data;
using HotelBookingSystem.Models;

namespace HotelBookingSystem.Test
{
    [TestClass]
    public class RepositoryTest
    {
        [TestMethod]
        public void TestGet_ValidId_ShouldPass()
        {
            Repository<Venue> venuesRepo = new Repository<Venue>();
            var venue1 = new Venue("novoto", "sfeee", "nqma", null);
            var venue2 = new Venue("staroto", "sfeee", "nqmaa", null);
            venuesRepo.Add(venue1);
            venuesRepo.Add(venue2);

            var result = venuesRepo.Get(1);

            Assert.AreEqual(venue1, result, "venues do not match");
        }

        [TestMethod]
        public void TestGet_InvalidId_ShouldReturnNull()
        {
            Repository<Venue> venuesRepo = new Repository<Venue>();
            var venue1 = new Venue("novoto", "sfeee", "nqma", null);
            var venue2 = new Venue("staroto", "sfeee", "nqmaa", null);
            venuesRepo.Add(venue1);
            venuesRepo.Add(venue2);

            var result = venuesRepo.Get(10);

            Assert.AreEqual(null, result, "venues do not match");
        }
    }
}
