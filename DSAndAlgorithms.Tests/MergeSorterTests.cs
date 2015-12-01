using System;
using DSAndAlgorithms.Algorithms.Sorting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DSAndAlgorithms;

namespace DSAndAlgorithms.Tests
{
    [TestClass]
    public class MergeSorterTests
    {
        [TestMethod]
        public void MergeSorter_Check_Sorting_Behavior()
        {
            int[] unsortedInts = { 6, 12, 8, 2, 9 };
            
            MergeSorter.MergeSort(unsortedInts);
        }

        [TestMethod]
        public void MergeSorter_Duplicates_Test()
        {
            int[] unsortedInts = { 6, 12, 8, 2, 9, 6 };
            
            MergeSorter.MergeSort(unsortedInts);
            
        }
    }
}
