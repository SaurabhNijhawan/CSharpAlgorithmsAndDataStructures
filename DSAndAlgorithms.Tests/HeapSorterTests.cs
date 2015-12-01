using System;
using DSAndAlgorithms.Algorithms.Sorting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DSAndAlgorithms;
using SortingSelfCoded;

namespace DSAndAlgorithms.Tests
{
    [TestClass]
    public class HeapSorterTests
    {
        [TestMethod]
        public void MergeSorter_Check_Sorting_Behavior()
        {
            int[] unsortedInts = { 6, 12, 8, 2, 9 };
            
            HeapSorter.HeapSort(unsortedInts);
        }

        [TestMethod]
        public void MergeSorter_Duplicates_Test()
        {
            int[] unsortedInts = { 6, 12, 8, 2, 9, 6 };
            
            MergeSorter.MergeSort(unsortedInts);
            
        }
    }
}
