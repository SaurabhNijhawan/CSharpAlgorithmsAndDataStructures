using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DSAndAlgorithms;

namespace DSAndAlgorithms.Tests
{
    [TestClass]
    public class InsertionSorterTests
    {
        [TestMethod]
        public void SortIWrote_Check_Sorting_Behaviour()
        {
            int[] inputArray = {5, 7, 1, 3, 6, 9};
            var sortedArray = InsertionSorter.Sort(inputArray);
            Assert.IsTrue(sortedArray!=null);
            int[] expectedArray = { 1, 3, 5, 6, 7, 9 };
            CollectionAssert.AreEquivalent(sortedArray, expectedArray);
        }

        [TestMethod]
        public void SortIWrote_Check_Behaviour_On_Duplicate_Numbers()
        {
            int[] inputArray = { 9, 7, 1, 3, 9, 9 };
            var sortedArray = InsertionSorter.Sort(inputArray);
            Assert.IsTrue(sortedArray != null);
            int[] expectedArray = {1, 3, 7, 9, 9, 9};
            CollectionAssert.AreEquivalent(sortedArray,expectedArray);
        }

        [TestMethod]
        public void SortIWrote_Check_Behaviour_On_No_Input()
        {
            int[] inputArray = { };
            var sortedArray = InsertionSorter.Sort(inputArray);
            Assert.IsTrue(sortedArray != null);
        }
    }
}
