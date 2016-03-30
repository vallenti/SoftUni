using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AvlTreeLab;

namespace AvlTreeTests
{
    [TestClass]
    public class IndexTests
    {
        private AvlTree<int> tree;

        [TestInitialize]
        public void TestInitialize()
        {
            var nums = TestUtils.ToIntArray("20 30 5 8 14 18 -2 0 50 50");

            tree = new AvlTree<int>();
            foreach (var num in nums)
            {
                tree.Add(num);
            }
        }

        [TestMethod]
        public void ValidIndicies_ShouldWorkCorrectly()
        {
            Assert.AreEqual(18, tree[5]);
            Assert.AreEqual(5, tree[2]);
            Assert.AreEqual(8, tree[3]);
            Assert.AreEqual(0, tree[1]);
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void InvalidIndicies_LowerInvalidIndex_ShouldThrow()
        {
            var value = tree[-3];
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void InvalidIndicies_UpperInvalidIndex_ShouldThrow()
        {
            var value = tree[9];
        }
    }
}
