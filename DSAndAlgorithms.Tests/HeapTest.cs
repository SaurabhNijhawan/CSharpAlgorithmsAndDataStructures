using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DSAndAlgorithms.Tests
{
    [TestClass]
    public class HeapTest
    {
        [TestMethod]
        public void Heaps_MaxHeapify_Should_Return_Valid_Heap()
        {
            int[] array = {0,30, 4, 7, 21, 56, 21};
            var heap = Heaps.Heaps.MaxHeapify(array, 1);

        }



        [TestMethod]
        public void Heaps_BuildHeap_Should_Return_Valid_Heap()
        {
            int[] array = { 0, 30, 4, 7, 21, 56, 21 };
            Heaps.Heaps.BuildMaxHeap(array);

        }

    }
}
