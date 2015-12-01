using System;
using DSAndAlgorithms.Algorithms.BitManipulation;
using DSAndAlgorithms.Search;
using DSAndAlgorithms.StringAlgorithms;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DSAndAlgorithms.Tests
{
    [TestClass]
    public class BitManipulatorTests
    {
        [TestMethod]
        public void BitManipulator_AreIntegersOfOppositeSigns_Opposite_Sign_Ints_Must_Return_True()
        {
            // Arrange
            int a = -9;
            int b = 4;

            // Act
            var result = Bitmanipulator.AreIntegersOfOppositeSigns(a, b);

            // Assert
            Assert.IsTrue(result);
        }

         [TestMethod]
        public void BitManipulator_AreIntegersOfOppositeSigns_Same_Sign_Ints_Must_Return_False()
        {
            // Arrange
            int a = 9;
            int b = 4;

            // Act
            var result = Bitmanipulator.AreIntegersOfOppositeSigns(a, b);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void BitManipulator_AreIntegersOfOppositeSignsUsingBitManpulation_Opposite_Sign_Ints_Must_Return_True()
        {
            // Arrange
            int a = -9;
            int b = 4;

            // Act
            var result = Bitmanipulator.AreIntegersOfOppositeSignsUsingBitManipulation(a, b);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void BitManipulator_AreIntegersOfOppositeSignsUsingBitManpulation_Same_Sign_Ints_Must_Return_False()
        {
            // Arrange
            int a = 9;
            int b = 4;

            // Act
            var result = Bitmanipulator.AreIntegersOfOppositeSignsUsingBitManipulation(a, b);

            // Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void BitManipulator_Add()
        {
            // Arrange
            int a = 9;
            int b = 4;

            // Act
            var result = Bitmanipulator.Add(a, b);

            // Assert
           
        }

        }
}
