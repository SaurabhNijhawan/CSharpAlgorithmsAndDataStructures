//using System;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using DSAndAlgorithms.LinkedList;


//namespace DSAndAlgorithms.Tests
//{
//    [TestClass]
//    public class LinkedListTests
//    {
//        #region Fields

//        private static LinkedList<int> linkedList;

//        #endregion
    
//        [ClassInitialize]
//        public static void ClassInitializer(TestContext context)
//        {
//            linkedList = new LinkedList.LinkedList<int>();
//            linkedList.Add(93);
//            linkedList.Add(43);
//            linkedList.Add(73);
//            linkedList.Add(53);
//            linkedList.Add(32);
//            linkedList.Add(31);
//        }

//        [TestMethod]
//        public void LinkedList_Traverse_Successful()
//        {
//            linkedList.Traverse();
//        }

//        [TestMethod]
//        public void LinkedList_FindNthElementUsingPredeterminedLength_Successful()
//        {
//            int element =linkedList.FindNthElementFromEndUsingPredeterminedLengthOfLinkedList(4);
//            Assert.AreEqual(73, element);
//        }

//        [TestMethod]
//        public void LinkedList_FindNthElementFromEndUsingTwoPointers_Successful()
//        {
//            int element = linkedList.FindNthElementFromEndUsingTwoPointers(4);
//            Assert.AreEqual(73, element);
//        }

//        [TestMethod]
//        public void LinkedList_FindMiddleElement_Should_Return_Middle_Elelemnt()
//        {
//            var middle = linkedList.FindMiddleElement();
//            Assert.AreEqual(73, middle.Data);
//        }

    
//    }
//}
