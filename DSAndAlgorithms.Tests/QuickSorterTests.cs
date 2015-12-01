using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DSAndAlgorithms;

namespace DSAndAlgorithms.Tests
{
    [TestClass]
    public class QuickSorterTests
    {
        [TestMethod]
        public void SortIWrote_Check_Sorting_Behavior()
        {
            int[] unsortedInts = { 6, 12, 8, 2, 9 };
            
            QuickSorter.QuickSort(unsortedInts,0,4);
        }
    }
}
