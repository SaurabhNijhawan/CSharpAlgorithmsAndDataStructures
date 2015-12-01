using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DSAndAlgorithms.LinkedList;

namespace DSAndAlgorithms.Tests
{
    [TestClass]
    public class DoublyLinkedListTests
    {
        #region Fields

        private static DoublyLinkedList<int> doublyLinkedList;
        private static DoublyLinkedListNode<int> head;

            #endregion
    
        [ClassInitialize]
        public static void ClassInitializer(TestContext context)
        {
          head = new DoublyLinkedListNode<int>(-1);
          doublyLinkedList= new DoublyLinkedList<int>(head);
         doublyLinkedList.Add(4);
         doublyLinkedList.Add(41);
          doublyLinkedList.Add(54);
          doublyLinkedList.Add(9);
        }

        [TestMethod]
        public void DoublyLinkedList_Traverse_Successful()
        {
           doublyLinkedList.Traverse();
        }

        [TestMethod]
        public void DoublyLinkedListAlgorithms_Traverse_Successful()
        {
            doublyLinkedList.Traverse();
            DoublyLinkedListAlgorithms<int>.Reverse(head);
            doublyLinkedList.Traverse();
        }
    
    }
}
