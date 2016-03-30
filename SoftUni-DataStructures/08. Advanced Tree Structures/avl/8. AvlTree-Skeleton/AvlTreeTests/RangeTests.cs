using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AvlTreeLab;
using System.Linq;

namespace AvlTreeTests
{
    [TestClass]
    public class RangeTests
    {
        private AvlTree<int> tree;

        [TestInitialize]
        public void TestInitialize()
        {
            var nums = TestUtils.ToIntArray("1 5 3 20 6 13 40 70 100 200 -50");

            tree = new AvlTree<int>();
            foreach (var num in nums)
            {
                tree.Add(num);
            }
        }

        [TestMethod]
        public void Range_IncluseBoundaries_ShouldWorkCorrectly()
        {
            var numberInRange = tree.Range(5, 20).ToArray();
            int[] expectedNumbers = new int[] { 5, 6, 13, 20};

            CollectionAssert.AreEqual(expectedNumbers, numberInRange);
        }

        [TestMethod]
        public void Range_ExcluseBoundaries_ShouldWorkCorrectly()
        {
            var numberInRange = tree.Range(7, 99).ToArray();
            int[] expectedNumbers = new int[] { 13, 20, 40, 70 };

            CollectionAssert.AreEqual(expectedNumbers, numberInRange);
        }

        [TestMethod]
        public void Range_Test1_ExclusiveBoundaries()
        {
            var nums = TestUtils.ToIntArray("20 30 5 8 14 18 -2 0 50 50");

            tree = new AvlTree<int>();
            foreach (var num in nums)
            {
                tree.Add(num);
            }

            var numberInRange = tree.Range(4, 34).ToArray();
            int[] expectedNumbers = new int[] { 5, 8, 14, 18, 20, 30 };

            CollectionAssert.AreEqual(expectedNumbers, numberInRange);
        }

        [TestMethod]
        public void Range_Test2_InclusiveBoundaries()
        {
            var nums = TestUtils.ToIntArray("5 40 3 8 2 2 2 1 0 50 80 33 -70");

            tree = new AvlTree<int>();
            foreach (var num in nums)
            {
                tree.Add(num);
            }

            var numberInRange = tree.Range(8, 40).ToArray();
            int[] expectedNumbers = new int[] { 8, 33, 40 };

            CollectionAssert.AreEqual(expectedNumbers, numberInRange);
        }

        [TestMethod]
        public void Range_Test3_NoElementsInGivenBoundaries()
        {
            var nums = TestUtils.ToIntArray("0 0 -10 20 3 4 5 6 7 8 9 10 11 12 13");

            tree = new AvlTree<int>();
            foreach (var num in nums)
            {
                tree.Add(num);
            }

            var numberInRange = tree.Range(21, 10000).ToArray();
            int[] expectedNumbers = new int[] { };

            Assert.AreEqual(0, numberInRange.Length);
            CollectionAssert.AreEqual(expectedNumbers, numberInRange);
        }
    }
}
