namespace TestReversedListGeneric
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using _06.ReversedListGeneric;
    using System.Collections.Generic;
    using System.Text;

    [TestClass]
    public class TestReversedList
    {
        [TestMethod]
        public void TestAdd_EmptyList_ShouldAddElement()
        {
            ReversedList<string> seqence = new ReversedList<string>();
            var expected = "one";

            seqence.Add(expected);

            Assert.AreEqual(1, seqence.Count);

            var actual = seqence[0];
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestAdd_SeveralElements_ShouldAddAllElementsCorrectly()
        {
            ReversedList<string> seqence = new ReversedList<string>();

            seqence.Add("one");
            seqence.Add("two");
            seqence.Add("three");

            Assert.AreEqual(3, seqence.Count);
            Assert.AreEqual("one", seqence[2]);
            Assert.AreEqual("two", seqence[1]);
            Assert.AreEqual("three", seqence[0]);
        }

        [TestMethod]
        public void TestCount_SeveralElements_ShouldBeCorrectValue()
        {
            ReversedList<string> seqence = new ReversedList<string>();

            seqence.Add("one");
            seqence.Add("two");
            seqence.Add("three");

            Assert.AreEqual(3, seqence.Count);
        }

        [TestMethod]
        public void TestCount_RemoveSeveralElements_ShouldBeCorrectValue()
        {
            ReversedList<string> seqence = new ReversedList<string>();
            seqence.Add("one");
            seqence.Add("two");
            seqence.Add("three");
            seqence.Add("four");

            seqence.Remove(0);
            seqence.Remove(0);

            Assert.AreEqual(2, seqence.Count);
        }

        [TestMethod]
        public void TestCapacity_NotFullArray_ShouldBeCorrectValue()
        {
            ReversedList<string> seqence = new ReversedList<string>();

            for (int i = 0; i < 20; i++)
            {
                seqence.Add(string.Empty);
            }

            Assert.AreEqual(32, seqence.Capacity);
        }

        [TestMethod]
        public void TestIndexGetter_ShouldGetCorrectElement()
        {
            ReversedList<string> seqence = new ReversedList<string>();
            seqence.Add("one");
            seqence.Add("two");
            seqence.Add("three");
            seqence.Add("four");

            Assert.AreEqual("four", seqence[0]);
            Assert.AreEqual("three", seqence[1]);
            Assert.AreEqual("two", seqence[2]);
            Assert.AreEqual("one", seqence[3]);
        }

        [TestMethod]
        public void TestIndexSetter_ShouldSetValueCorrectly()
        {
            ReversedList<string> seqence = new ReversedList<string>();
            seqence.Add("one");
            seqence.Add("two");

            seqence[0] = "modified-two";

            Assert.AreEqual("modified-two", seqence[0]);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestRemove_EmptyList_ShouldThrow()
        {
            ReversedList<string> seqence = new ReversedList<string>();
            seqence.Remove(0);
        }

        [TestMethod]
        public void TestRemove_SingleElement_ShouldMakeListEmpty()
        {
            ReversedList<string> seqence = new ReversedList<string>();
            seqence.Add("testOne");

            seqence.Remove(0);

            Assert.AreEqual(0, seqence.Count);
        }

        [TestMethod]
        public void TestRemove_SeveralElements_ShouldRemoveElementsCorrectly()
        {
            ReversedList<string> seqence = new ReversedList<string>();
            seqence.Add("one");
            seqence.Add("two");
            seqence.Add("three");
            seqence.Add("four");

            var actualFour = seqence.Remove(0);
            var actualThree = seqence.Remove(0);

            Assert.AreEqual("four", actualFour);
            Assert.AreEqual("three", actualThree);
            Assert.AreEqual("two", seqence[0]);
            Assert.AreEqual("one", seqence[1]);
        }


        [TestMethod]
        public void IEnumerable_Foreach_EmptyList()
        {
            ReversedList<string> seqence = new ReversedList<string>();
            StringBuilder actual = new StringBuilder();
            foreach (string item in seqence)
            {
                actual.Append(item);
            }

            Assert.AreEqual(string.Empty, actual.ToString());
        }

        [TestMethod]
        public void IEnumerable_Foreach_SingleElement()
        {
            ReversedList<string> seqence = new ReversedList<string>();
            seqence.Add("one");
            StringBuilder actual = new StringBuilder();
            foreach (string item in seqence)
            {
                actual.Append(item);
            }

            Assert.AreEqual("one", actual.ToString());
        }

        [TestMethod]
        public void IEnumerable_Foreach_MultipleElements()
        {
            ReversedList<string> seqence = new ReversedList<string>();
            seqence.Add("one");
            seqence.Add("two");
            seqence.Add("three");
            StringBuilder actual = new StringBuilder();
            foreach (string item in seqence)
            {
                actual.Append(item);
            }

            Assert.AreEqual("threetwoone", actual.ToString());
        }
    }
}
