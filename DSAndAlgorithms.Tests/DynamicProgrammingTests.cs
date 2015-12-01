using System;
using DSAndAlgorithms.Algorithms.DynamicProgramming;
using DSAndAlgorithms.DynamicProgramming;
using DSAndAlgorithms.StringAlgorithms;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DSAndAlgorithms.Tests
{
    [TestClass]
    public class DynamicProgrammingTests
    {
        [TestMethod]
        public void LongestIncreasingSubsequence_Length()
        {
            // Arrange
            int[] input = {4, 7, 12, 45, 3, 21, 22, 65, 89, 9, 56, 2};

            // Act
            var length = LongestIncreasingSubsequence.Length(input);

            // Assert
            Assert.AreEqual(7, length);
        }

        [TestMethod]
        public void LCS_Test()
        {
            // Arrange
            char[] a = "abcdefggg".ToCharArray();
            char[] b = "abgdf".ToCharArray();

            // Act
            var length = DSAndAlgorithms.DynamicProgramming.LCS.LongestCommonSubSequenceLength(a, b);

            // Assert
            Assert.AreEqual(4, length);
        }

        [TestMethod]
        public void CoinChangeProblem_Test()
        {
            // Arrange
            var denominations = new int[] {1, 2, 3};

            var amount = 10;

            // Act
            var noOfWays = CoinChangeProblem.GetNoOfWaysToReturnChange(denominations, amount);

            // Assert
            
        }

    }
}
