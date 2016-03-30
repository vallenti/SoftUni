using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _01.LinkedQueue;

namespace TestLinkedQueue
{
    [TestClass]
    public class TestLinkedQueue
    {

        private LinkedQueue<int> queue;

        [TestInitialize]
        public void TestInitialize()
        {
            this.queue = new LinkedQueue<int>();
        }

        [TestMethod]
        public void TestEnqueAndDequeElement_ShouldPass()
        {
            queue.Enqueue(5);
            var dequedElement = queue.Dequeue();
            Assert.AreEqual(dequedElement, 5, "dequed element is not correct");
        }

        [TestMethod]
        public void TestEnqueAndDequeMulitpleElements_ShouldPass()
        {
            queue.Enqueue(5);
            queue.Enqueue(3);
            queue.Enqueue(1);

            var deque5 = queue.Dequeue();
            var deque3 = queue.Dequeue();
            var deque1 = queue.Dequeue();

            Assert.AreEqual(deque5, 5, "");
            Assert.AreEqual(deque3, 3, "");
            Assert.AreEqual(deque1, 1, "");
        }

        [TestMethod]
        public void TestEnqueCount_ShouldPass()
        {
            queue.Enqueue(5);
            queue.Enqueue(1);
            queue.Enqueue(6);
            queue.Enqueue(2);
            queue.Enqueue(3);

            Assert.AreEqual(5, queue.Count, "");
        }

        [TestMethod]
        public void TestEnqueDequeCount_ShouldPass()
        {
            queue.Enqueue(5);
            queue.Enqueue(1);
            queue.Enqueue(6);
            queue.Enqueue(2);
            queue.Enqueue(3);

            for (int i = 0; i < 3; i++)
            {
                queue.Dequeue();
            }

            Assert.AreEqual(2, queue.Count, "");
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestDequeWithEmptyQueue_ShouldThrow()
        {
            queue.Dequeue();
        }
    }
}
