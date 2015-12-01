using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using DSAndAlgorithms.DataStructures.Arrays;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DSAndAlgorithms.Tests
{
    [TestClass]
    public class ArrayAlgorithmsTests
    {
        [TestMethod]
        public void ArrayAlgorithms_FindNonRepeatedElementsUsingMap_1_Missing_Element_Should_Return_Non_Repeated_Element()
        {
            // Arrange
            var input = new int[] {1,7,2,6,2,7,6};
            
            // Act
            var output = ArrayAlgorithms.FindNonRepeatedElementUsingMap(input);

            // Assert

            Assert.AreEqual(1, output);
        }

        [TestMethod]
        public void ArrayAlgorithms_FindNonRepeatedElementsUsingMap_No_Missing_Elements_Should_Return_Minus_1()
        {
            // Arrange
            var input = new int[] { 1, 7, 2, 6, 2, 7, 6, 1 };

            // Act
            var output = ArrayAlgorithms.FindNonRepeatedElementUsingMap(input);

            // Assert

            Assert.AreEqual(-1, output);
        }

        [TestMethod]
        public void ArrayAlgorithms_FindMissingElementUsingSum_Should_Return_Missing_Element()
        {
            // Arrange
            var input = new int[] { 1,4,0,3,2,7,6 };

            // Act
            var output = ArrayAlgorithms.FindMissingNumberUsingSum(input);

            // Assert

            Assert.AreEqual(5, output);
        }

        [TestMethod]
        public void ArrayAlgorithms_FindMissingElementUsingXOR_Should_Return_Missing_Element()
        {
            // Arrange
            var input = new int[] { 1, 4, 0, 3, 2, 7, 6 };

            // Act
            var output = ArrayAlgorithms.FindMissingNumberUsingXOR(input);

            // Assert

            Assert.AreEqual(5, output);
        }

        [TestMethod]
        public void ArrayAlgorithms_FindCombinationSuchThatPHValueIsNeutralized_Test()
        {
            // Arrange
            var input = new PhValue[] { new PhValue() { Element = "CA", Value = -3 }, new PhValue() { Element = "AR", Value = 3 }, new PhValue() { Element = "MN", Value = 6 }, new PhValue() { Element = "PD", Value = 8 } };

            // Act
            ArrayAlgorithms.FindCombinationSuchThatPHValueIsNeutralized(input);
        }

        [TestMethod]
        public void ArrayAlgorithms_Replace0With5_Input_102_Output_ShouldBe_152_Test()
        {
            // Arrange
            var input = 102;

            // Act
           var output=  ArrayAlgorithms.Replace0With5InIntegerValue(input);

            // Assert
            Assert.AreEqual(152, output);
        }

        [TestMethod]
        public void ArrayAlgorithms_Replace0With5_Input_1002_Output_ShouldBe_1552_Test()
        {
            // Arrange
            var input = 1002;

            // Act
            var output = ArrayAlgorithms.Replace0With5InIntegerValue(input);

            // Assert
            Assert.AreEqual(1552, output);
        }

        [TestMethod]
        public void ArrayAlgorithms_PrintMatrixInSpiralForm_Test()
        {
            // Arrange
            var input = new int[,]
            {
                {1,2,3,4,5},
                {6,7,8,9,10},
                {11,12,13,14,15}

            };

            // Act
            ArrayAlgorithms.PrintMatrixInSpiralForm(input);
        }

        [TestMethod]
        public void Sample()
        {
          
        
            ChildClass cd = new ChildClass();
            int a = 4;
            cd.Func(a);
            cd.Funct(new C());
        }

        public void wrongmethod()
        {
            wrongmethod();
        }


        private class B
        {

        }

        class C: B
        {
             
        }

        class BaseClass
        {
             public virtual void Func(int a)
             {
                 Console.Write("base int");
             }

            public virtual void Funct(C b)
            {

            }
        }

         class ChildClass: BaseClass
         {
             public override void Func(int a)
             {
                 Console.Write("der int");
             }

             public void Func(object a)
             {
                 Console.Write("der object");
             }

             public override void Funct(C b)
             {
                
             }

             public void Funct(B b)
             {

             }
         }

    }
}