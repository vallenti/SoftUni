using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace _02.BiDictionary.Test
{
    [TestClass]
    public class BiDictionaryTests
    {
        private BiDictionary<string, string, int> distances;

        [TestInitialize]
        public void TestInitialize()
        {
            distances = new BiDictionary<string, string, int>();
            AddElements();
        }


        [TestMethod]
        public void FindByFirstKey_NoResults_ShouldWorkCorrectly()
        {
            List<int> distancesFromPetrich = distances.FindByKey1("Petrich").ToList();
            int[] expected = new int[] { };
            CollectionAssert.AreEqual(expected, distancesFromPetrich);
        }

        [TestMethod]
        public void FindByFirstKey_SeveralResults_ShouldWorkCorrectly()
        {
            List<int> distancesFromSofia = distances.FindByKey1("Sofia").ToList();
            int[] expected = new int[] { 443, 468, 490, 145, 383 };
            CollectionAssert.AreEqual(expected, distancesFromSofia);
        }

        [TestMethod]
        public void FindBySecondKey_NoResults_ShouldWorkCorrectly()
        {
            List<int> distancesFromPetrich = distances.FindByKey2("Petrich").ToList();
            int[] expected = new int[] { };
            CollectionAssert.AreEqual(expected, distancesFromPetrich);
        }

        [TestMethod]
        public void FindBySecondKey_SeveralResults_ShouldWorkCorrectly()
        {
            List<int> distancesFromBurgas = distances.FindByKey2("Bourgas").ToList();
            int[] expected = new int[] { 383, 253, 292};
            CollectionAssert.AreEqual(expected, distancesFromBurgas);
        }

        [TestMethod]
        public void FindByBothKeys_NoResults_ShouldWorkCorrectly()
        {
            List<int> distancesRousseVarna = distances.Find("Rousse", "Varna").ToList();
            int[] expected = new int[] { };
            CollectionAssert.AreEqual(expected, distancesRousseVarna);
        }

        [TestMethod]
        public void FindByBothKeys_SeveralResults_ShouldWorkCorrectly()
        {
            List<int> distancesSofiaVarna = distances.Find("Sofia", "Varna").ToList();
            int[] expected = new int[] { 443, 468, 490 };
            CollectionAssert.AreEqual(expected, distancesSofiaVarna);
        }

        [TestMethod]
        public void Remove_MissingElements_ShouldWorkCorrectly()
        {
            var removeResult = distances.Remove("Smolyan", "Lisichkovo");
            Assert.IsFalse(removeResult);
        }

        [TestMethod]
        public void Remove_NotMissingElement_ShouldWorkCorrectly()
        {
            var removeResult = distances.Remove("Sofia", "Varna");
            Assert.IsTrue(removeResult);
        }

        private void AddElements()
        {
            distances.Add("Sofia", "Varna", 443);
            distances.Add("Sofia", "Varna", 468);
            distances.Add("Sofia", "Varna", 490);
            distances.Add("Sofia", "Plovdiv", 145);
            distances.Add("Sofia", "Bourgas", 383);
            distances.Add("Plovdiv", "Bourgas", 253);
            distances.Add("Plovdiv", "Bourgas", 292);
        }
    }
}
