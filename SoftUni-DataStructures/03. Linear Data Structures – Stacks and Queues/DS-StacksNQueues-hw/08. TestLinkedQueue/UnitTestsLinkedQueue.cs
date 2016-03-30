using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _07.LinkedQueueGeneric;

namespace _08.TestLinkedQueue
{
    [TestClass]
    public class UnitTestsLinkedQueue
    {
        [TestMethod]
        public void TestEnqueueDequeue_SingleElement_ShouldWorkCorrectly()
        {
            LinkedQueue<int> queue = new LinkedQueue<int>();
            Assert.AreEqual(0, queue.Count);

            queue.Enqueue(5);
            Assert.AreEqual(1, queue.Count);

            var poppedElement = queue.Dequeue();
            Assert.AreEqual(5, poppedElement);
            Assert.AreEqual(0, queue.Count);
        }

        [TestMethod]
        public void TestEnqueueDequeue_1000Elements_ShouldWorkCorrectly()
        {
            const int numberOfOperations = 1000;
            LinkedQueue<string> queue = new LinkedQueue<string>();
            for (int i = 0; i < numberOfOperations; i++)
            {
                queue.Enqueue("test" + i);
            }

            Assert.AreEqual(numberOfOperations, queue.Count);

            for (int i = 0; i < numberOfOperations; i++)
            {
                string currentElement = queue.Dequeue();
                Assert.AreEqual("test" + i, currentElement);
                Assert.AreEqual(numberOfOperations - i - 1, queue.Count);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestDequeue_EmptyQueue_ShouldThrow()
        {
            LinkedQueue<int> queue = new LinkedQueue<int>();
            queue.Dequeue();
        }

        [TestMethod]
        public void TestInitialCount_EnqueueDequeueElement_ShouldWorkCorrectly()
        {
            LinkedQueue<int> queue = new LinkedQueue<int>();
            Assert.AreEqual(0, queue.Count);

            queue.Enqueue(3);
            Assert.AreEqual(1, queue.Count);

            queue.Enqueue(5);
            Assert.AreEqual(2, queue.Count);

            var actualThree = queue.Dequeue();
            Assert.AreEqual(3, actualThree);
            Assert.AreEqual(1, queue.Count);

            var actualFive = queue.Dequeue();
            Assert.AreEqual(5, actualFive);
            Assert.AreEqual(0, queue.Count); 
        }

        [TestMethod]
        public void TestToArray_SeveralElements_ShouldWorkCorrectly()
        {
            LinkedQueue<int> stack = new LinkedQueue<int>();
            stack.Enqueue(3);
            stack.Enqueue(5);
            stack.Enqueue(-2);
            stack.Enqueue(7);
            var expected = new int[] { 3, 5, -2, 7 };
            var actual = stack.ToArray();
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestToArray_EmptyQueue_ShouldPass()
        {
            LinkedQueue<DateTime> stack = new LinkedQueue<DateTime>();
            var expected = new DateTime[0];
            var actual = stack.ToArray();
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
