using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace _03.TestLongestSubsequence
{
    [TestClass]
    public class TestLongestSubsequence
    {
        [TestMethod]
        public void LongestSubsequence_InMiddleOfSequence()
        {
            //Arrange
            List<int> sequence = new List<int>() { 12, 2, 7, 4, 3, 3, 8 };
            List<int> expected = new List<int> { 3, 3 };

            ExecuteTest(sequence, expected);
        }

        [TestMethod]
        public void LongestSubsequence_AtTheBeginningOfSequence()
        {
            //Arrange
            List<int> sequence = new List<int>() { 2, 2, 2, 3, 3 };
            List<int> expected = new List<int> { 2, 2, 2 };

            ExecuteTest(sequence, expected);
        }

        [TestMethod]
        public void LongestSubsequence_AtTheEndOfSequence()
        {
            //Arrange
            List<int> sequence = new List<int>() { 4, 4, 5, 5, 5 };
            List<int> expected = new List<int> { 5, 5, 5 };

            ExecuteTest(sequence, expected);

        }

        [TestMethod]
        public void LongestSubsequence_TakeLeftMostSubsequenceOfSeveralEqual()
        {
            //Arrange
            List<int> sequence = new List<int>() { 1, 2, 3 };
            List<int> expected = new List<int> { 1 };

            ExecuteTest(sequence, expected);
        }

        [TestMethod]
        public void LongestSubsequence_SingleElementInSequence()
        {
            //Arrange
            List<int> sequence = new List<int>() { 0 };
            List<int> expected = new List<int> { 0 };

            ExecuteTest(sequence, expected);
        }

        private void ExecuteTest(List<int> sequence, List<int> expected)
        {
            //Act
            List<int> actual = LongestSubesequenceFinder.FindLongestSubSeqenceOfEqualNumbers(sequence);

            //Assert
            Assert.AreEqual(expected.Count, actual.Count);
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
