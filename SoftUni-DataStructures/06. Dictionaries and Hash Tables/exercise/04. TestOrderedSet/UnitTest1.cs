using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _04.OrderedSet;
using System.Text;

namespace _04.TestOrderedSet
{
    [TestClass]
    public class TestOrderedSet
    {
        private OrderedSet<int> set;

        [TestInitialize]
        public void InitializeTests()
        {
            set = new OrderedSet<int>();
        }

        [TestMethod]
        public void Count_ShouldWorkCorrectly()
        {
            Assert.AreEqual(0, set.Count);
            set.Add(5);
            set.Add(6);
            Assert.AreEqual(2, set.Count);
            set.Remove(5);
            Assert.AreEqual(1, set.Count);
        }

        [TestMethod]
        public void Add_SingleElement_ShouldWorkCorrectly()
        {
            set.Add(5);
            Assert.AreEqual(1, set.Count);
        }

        [TestMethod]
        public void Add_SeveralElements_ShouldWorkCorrectly()
        {
            set.Add(5);
            set.Add(6);
            set.Add(1);
            Assert.AreEqual(3, set.Count);
        }

        [TestMethod]
        public void Add_DuplicateElement_ShouldWorkCorrectly()
        {
            set.Add(5);
            set.Add(5);
            Assert.AreEqual(1, set.Count);
        }

        [TestMethod]
        public void Contains_ShouldWorkCorrectly()
        {
            set.Add(10);
            Assert.IsTrue(set.Contains(10));
        }

        [TestMethod]
        public void Contains_MissingElement_ShouldWorkCorrectly()
        {
            set.Add(10);
            Assert.IsFalse(set.Contains(3));
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Remove_EmptySet_ShouldThrow()
        {
            set.Remove(5);
        }

        [TestMethod]
        public void Remove_SingleElement_ShouldWorkCorrectly()
        {
            set.Add(5);
            set.Add(7);

            set.Remove(5);

            Assert.AreEqual(1, set.Count);
        }

        [TestMethod]
        public void IEnumerable_AllElements_ShouldWorkCorrectly()
        {
            set.Add(17);
            set.Add(9);
            set.Add(12);
            set.Add(19);
            set.Add(6);
            set.Add(25);

            string expected = "6 9 12 17 19 25 ";
            StringBuilder actual = new StringBuilder();
            foreach (var item in set)
            {
                actual.Append(item + " ");
            }

            Assert.AreEqual(expected, actual.ToString());
        }

    }
}
