using System;
using DSAndAlgorithms.DataStructures.Heaps;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace DSAndAlgorithms.Tests
{
    [TestClass]
    public class MaxHeapTest
    {
        [TestMethod]
        public void MaxHeap_BuildMaxHeap_Should_Return_Valid_Heap()
        {
            int[] array = {0,30, 4, 7, 21, 56, 21};
            var maxHeap = new MaxHeap(array, array.Length);

        }



        [TestMethod]
        public void MaxHeap_RemoveMaximum_Should_Return_MaximumAndReBuildTheHeap()
        {
            int[] array = { 0, 30, 4, 7, 21, 56, 21 };
            var maxHeap = new MaxHeap(array, array.Length);

            int max = maxHeap.RemoveMaximum();

            Assert.AreEqual(56, max);
            Assert.AreEqual(6, maxHeap.Length);
            Assert.AreEqual(30, maxHeap.Array[0]);

        }

        [TestMethod]
        public void MaxHeap_RemoveMaximumTwice_Should_Return_MaximumAndReBuildTheHeap()
        {
            int[] array = { 0, 30, 4, 7, 21, 56, 21 };
            var maxHeap = new MaxHeap(array, array.Length);

            int max1 = maxHeap.RemoveMaximum();
            int max2 = maxHeap.RemoveMaximum();

            Assert.AreEqual(56, max1);
            Assert.AreEqual(30, max2);
            Assert.AreEqual(5, maxHeap.Length);
            Assert.AreEqual(21, maxHeap.Array[0]);

        }

    }
}
