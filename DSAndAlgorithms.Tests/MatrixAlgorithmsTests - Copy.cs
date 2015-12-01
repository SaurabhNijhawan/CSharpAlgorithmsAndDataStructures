using System;
using DSAndAlgorithms.Algorithms.Matrixes;
using DSAndAlgorithms.Algorithms.Sorting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DSAndAlgorithms;
using SortingSelfCoded;

namespace DSAndAlgorithms.Tests
{
    [TestClass]
    public class MatrixAlgorithmsTests
    {
        [TestMethod]
        public void MatrixAlgorithms_Rotate90_Should_Rotate_By_90()
        {
            int[,] matrix = { {6, 12, 8}, {2, 9, 3}, {4,8,0} };

            var result = MatrixAlgorithms.Rotate90(matrix);
        }

       
    }
}
