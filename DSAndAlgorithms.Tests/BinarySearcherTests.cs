using System;
using DSAndAlgorithms.Search;
using DSAndAlgorithms.StringAlgorithms;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DSAndAlgorithms.Tests
{
    [TestClass]
    public class BinarySearcherTests
    {
        [TestMethod]
        public void BinarySearcher_BinarySearchRecursive_Valid_Search_Must_Return_Index()
        {
            // Arrange
            int[] array = {3, 6, 8, 9, 12, 45, 89, 112};

            // Act
            var index = BinarySearcher.BinarySearchRecursive(array, 0, array.Length - 1, 45);

            // Assert
            Assert.AreEqual(5, index);
        }

        [TestMethod]
        public void BinarySearcher_BinarySearch_Valid_Search_Must_Return_Index()
        {
            // Arrange
            int[] array = { 3, 6, 8, 9, 12, 45, 89, 112 };

            // Act
            var index = BinarySearcher.BinarySearch(array, 45);

            // Assert
            Assert.AreEqual(5, index);
        }

        }
}
