using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BangaloreUniversityLearningSystem.Data;
using BangaloreUniversityLearningSystem.Interfaces;
using Moq;
using BangaloreUniversityLearningSystem;
using BangaloreUniversityLearningSystem.Controllers;
using BangaloreUniversityLearningSystem.Models;

namespace BULS.Test
{
    [TestClass]
    public class RepositoryTest
    {
        [TestMethod]
        public void TestGetFirstElement_ShouldPass()
        {
            var rep = new Repository<int>();
            rep.Add(5);
            rep.Add(6);
            rep.Add(7);

            var result = rep.Get(1);
            Assert.AreEqual(5, result, "not equal");
        }

        [TestMethod]
        public void TestGetNonExistingElement_ShouldBeNull()
        {
            var rep = new Repository<int>();
            rep.Add(5);
            rep.Add(6);
            rep.Add(7);

            var result = rep.Get(10);
            Assert.AreEqual(result, default(int), "");
        }

        [TestMethod]
        public void MockingAddLecture()
        {
            var dataMock = new Mock<IBangaloreUniversityData>();
            var courseRepo = new Mock<IRepository<Course>>();
            var course = new Course("C# test");
            courseRepo.Setup(c => c.Get(It.IsAny<int>()))
                .Returns(course);

            dataMock.Setup(d => d.Courses)
                .Returns(courseRepo.Object);

            IBangaloreUniversityData mockedData = dataMock.Object;

            var controller = new CoursesController(mockedData, new User("mitko", "1234567", Role.Lecturer));

            controller.AddLecture(1, "beginning");

            Assert.AreEqual(mockedData.Courses.Get(1).Lectures.Count, 1, "");
        }
    }
}
