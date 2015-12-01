using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DSAndAlgorithms.Algorithms.Recursion;

namespace DSAndAlgorithms.Tests
{
    [TestClass]
    public class RecursionAlgorithmsTests
    {
        #region Power Tests
        [TestMethod]
        public void RecursionAlgorithms_Power_Test()
        {
            var result = RecursionAlgorithms.Power(3, 4);

            Assert.AreEqual(81, result);

        }

        [TestMethod]
        public void RecursionAlgorithms_Power_N_0_Should_Return_1()
        {
            var result = RecursionAlgorithms.Power(3, 0);

            Assert.AreEqual(1, result);

        }

        [TestMethod]
        public void RecursionAlgorithms_Power_N_1_Should_Return_X()
        {
            var result = RecursionAlgorithms.Power(3, 1);

            Assert.AreEqual(3, result);

        }

        #endregion

        [TestMethod]
        public void RecursionAlgorithms_Tower_Of_Hanoi_Test()
        {
           RecursionAlgorithms.TowerOfHanoi(3, 'A', 'B', 'C');
         }

        [TestMethod]
        public void RecursionAlgorithms_GenerateBinaryStrings_Length2_Test()
        {
            RecursionAlgorithms.GenerateBinaryStrings(2);
        }

        [TestMethod]
        public void RecursionAlgorithms_GenerateBinaryStrings_Length3_Test()
        {
            RecursionAlgorithms.GenerateBinaryStrings(3);
        }


        [TestMethod]
        public void RecursionAlgorithms_Fibonacci_Series_Test()
        {
            FibonacciSeriesGenerator.Generate();
        }

    }
}
