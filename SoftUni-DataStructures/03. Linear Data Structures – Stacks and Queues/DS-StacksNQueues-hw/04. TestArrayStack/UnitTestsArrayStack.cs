using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _03.ArrayStackGeneric;

namespace _04.TestArrayStack
{
    [TestClass]
    public class UnitTestsArrayStack
    {
        [TestMethod]
        public void TestPushPop_SingleElement_ShouldWorkCorrectly()
        {
            ArrayStack<int> stack = new ArrayStack<int>();
            Assert.AreEqual(0, stack.Count);

            stack.Push(5);
            Assert.AreEqual(1, stack.Count);

            var poppedElement = stack.Pop();
            Assert.AreEqual(5, poppedElement);
            Assert.AreEqual(0, stack.Count);
        }

        [TestMethod]
        public void TestPushPop_1000Elements_ShouldWorkCorrectly()
        {
            const int numberOfOperations = 1000;
            ArrayStack<string> stack = new ArrayStack<string>();
            for (int i = 0; i < numberOfOperations; i++)
            {
                stack.Push("test" + i);
            }

            Assert.AreEqual(numberOfOperations, stack.Count);

            for (int i = numberOfOperations - 1; i >= 0; i--)
            {
                string currentElement = stack.Pop();
                Assert.AreEqual("test" + i, currentElement);
                Assert.AreEqual(i, stack.Count);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestPop_EmptyStack_ShouldThrow()
        {
            ArrayStack<int> stack = new ArrayStack<int>();
            stack.Pop();
        }

        [TestMethod]
        public void TestInitialCapacity_PushPopElement_ShouldWorkCorrectly()
        {
            ArrayStack<int> stack = new ArrayStack<int>(1);
            Assert.AreEqual(0, stack.Count);

            stack.Push(3);
            Assert.AreEqual(1, stack.Count);

            stack.Push(5);
            Assert.AreEqual(2, stack.Count);

            var actualFive = stack.Pop();
            Assert.AreEqual(5, actualFive);
            Assert.AreEqual(1, stack.Count);

            var actualThree = stack.Pop();
            Assert.AreEqual(3, actualThree);
            Assert.AreEqual(0, stack.Count);
        }

        [TestMethod]
        public void TestToArray_SeveralElements_ShouldWorkCorrectly()
        {
            ArrayStack<int> stack = new ArrayStack<int>();
            stack.Push(3);
            stack.Push(5);
            stack.Push(-2);
            stack.Push(7);
            var expected = new int[] { 7, -2, 5, 3 };
            var actual = stack.ToArray();
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestToArray_EmptyStack_ShouldPass()
        {
            ArrayStack<DateTime> stack = new ArrayStack<DateTime>();
            var expected = new DateTime[0];
            var actual = stack.ToArray();
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
