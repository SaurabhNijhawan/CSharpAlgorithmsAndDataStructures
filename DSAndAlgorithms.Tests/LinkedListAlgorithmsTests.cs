using System;
using DSAndAlgorithms.Algorithms.LinkedList;
using DSAndAlgorithms.DataStructures.LinkedList;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DSAndAlgorithms.LinkedList;


namespace DSAndAlgorithms.Tests
{
    [TestClass]
    public class LinkedListAlgorithmsTests
    {
        #region Fields

        //private static LinkedList<int> linkedList;

        #endregion
    
        [ClassInitialize]
        public static void ClassInitializer(TestContext context)
        {
            //linkedList = new LinkedList<int>();
            //linkedList.Add(1);
            //linkedList.Add(2);
            //linkedList.Add(3);
            //linkedList.Add(4);
            //linkedList.Add(5);
            //linkedList.Add(6);
        }

        [TestMethod]
        public void LinkedListAlgorithms_SwapAlternateElements_Test()
        {
           //linkedList.Traverse();
           //LinkedListAlgorithms<int>.SwapAlternateElementsUsingSwapping(linkedList.Head);
           //linkedList.Traverse();
        }

        [TestMethod]
        public void LinkedListAlgorithms_Reverse_LinkedListShouldBeReversed()
        {

            // Arrange
           var head = new Node<int>();
            
           LinkedList<int>.Add(head, 1);
           LinkedList<int>.Add(head, 2);
           LinkedList<int>.Add(head, 3);
           LinkedList<int>.Add(head, 4);

           LinkedList<int>.Traverse(head);

            LinkedListAlgorithms<int>.Reverse(head);

           LinkedList<int>.Traverse(head);



            // Act

            // Assert
        }



    }
}
