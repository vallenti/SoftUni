namespace LinkedListTest
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using _07.SingleLinkedListGeneric;
    using System.Text;

    [TestClass]
    public class TestLinkedList
    {
        private const string Zero = "zero";
        private const string One = "one";
        private const string Two = "two";
        private const string Three = "three";
        private const string Four = "four";
        private const string Five = "five";

        private SinglyLinkedList<string> list;

        [TestInitialize]
        public void InitializeTestSetup()
        {
            this.list = new SinglyLinkedList<string>();
        }

        [TestMethod]
        public void TestAdd_EmptyList_ShouldAddCorrectElement()
        {
            list.Add(One);

            Assert.AreEqual(1, list.Count);
        }

        [TestMethod]
        public void TestAdd_SeveralElements_ShouldAddCorrectElements()
        {
            list.Add(One);
            list.Add(Two);
            list.Add(Three);

            Assert.AreEqual(3, list.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestRemove_EmptyList_ShouldThrow()
        {
            list.Remove(0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestRemove_InvalidIndex_ShouldThrow()
        {
            list.Add(One);
            list.Remove(10);
        }

        [TestMethod]
        public void TestRemove_OneElement_ShouldMakeListEmpty()
        {
            list.Add(One);

            var actualOne = list.Remove(0);

            Assert.AreEqual(One, actualOne);
            Assert.AreEqual(0, list.Count);
        }

        [TestMethod]
        public void TestRemove_SeveralElements_ShouldRemoveCorrectElements()
        {
            list.Add(One);
            list.Add(Two);
            list.Add(Three);
            list.Add(Four);
            list.Add(Five);

            var actualTwo = list.Remove(1);
            var actualFive = list.Remove(3);

            Assert.AreEqual(Two, actualTwo);
            Assert.AreEqual(Five, actualFive);
            Assert.AreEqual(3, list.Count);
        }

        [TestMethod]
        public void TestCount_EmptyList_ShouldPass()
        {
            Assert.AreEqual(0, list.Count);
        }

        [TestMethod]
        public void TestCount_AddElements_ShouldPass()
        {
            list.Add(One);
            list.Add(Two);
            list.Add(Three);

            Assert.AreEqual(3, list.Count);
        }

        [TestMethod]
        public void TestCount_RemoveElements_ShouldPass()
        {
            list.Add(One);
            list.Add(Two);
            list.Add(Three);

            list.Remove(0);
            list.Remove(1);

            Assert.AreEqual(1, list.Count);
        }

        [TestMethod]
        public void TestFirstIndexOf_ElementFound_ShouldReturnCorrectIndex()
        {
            this.SetupIndexesTestMethods();
            const int expectedIndex = 2;

            int actualIndex = list.FirstIndexOf(Three);

            Assert.AreEqual(expectedIndex, actualIndex);
        }

        [TestMethod]
        public void TestFirstIndexOf_ElementNotFound_ShouldReturnMinusOne()
        {
            this.SetupIndexesTestMethods();
            const int expectedIndex = -1;

            var actualIndex = list.FirstIndexOf(Zero);

            Assert.AreEqual(expectedIndex, actualIndex);
        }

        [TestMethod]
        public void TestLastIndexOf_ElementFound_ShouldReturnCorrectIndex()
        {
            this.SetupIndexesTestMethods();
            const int expectedIndex = 4;

            var actualIndex = list.LastIndexOf(Three);

            Assert.AreEqual(expectedIndex, actualIndex);
        }

        [TestMethod]
        public void TestLastIndexOf_ElementNotFound_ShouldReturnMinusOne()
        {
            this.SetupIndexesTestMethods();
            const int expectedIndex = -1;

            var actualIndex = list.LastIndexOf(Zero);

            Assert.AreEqual(expectedIndex, actualIndex);
        }

        private void SetupIndexesTestMethods()
        {
            list.Add(One);
            list.Add(Two);
            list.Add(Three);
            list.Add(Four);
            list.Add(Three);
        }

        [TestMethod]
        public void IEnumerable_Foreach_EmptyList()
        {
            string actual = this.ForeachAppender(list);

            Assert.AreEqual(string.Empty, actual);
        }

        [TestMethod]
        public void IEnumerable_Foreach_SingleElement()
        {
            list.Add(One);

            string actual = this.ForeachAppender(list);

            Assert.AreEqual(One, actual);
        }

        [TestMethod]
        public void IEnumerable_Foreach_MultipleElements()
        {
            list.Add(One);
            list.Add(Two);
            list.Add(Three);
            string expected = One+Two+Three;
            string actual = this.ForeachAppender(list);

            Assert.AreEqual(expected, actual);
        }

        private string ForeachAppender(SinglyLinkedList<string> list)
        {
            StringBuilder actual = new StringBuilder();
            foreach (string item in list)
            {
                actual.Append(item);
            }

            return actual.ToString();
        }
    }
}
