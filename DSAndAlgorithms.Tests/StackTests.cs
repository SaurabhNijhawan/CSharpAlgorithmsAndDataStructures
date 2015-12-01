using System;
using DSAndAlgorithms.DataStructures.Stacks;
using DSAndAlgorithms.Stacks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DSAndAlgorithms.Tests
{
    [TestClass]
    public class StackTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            Stack stack = new Stack();
            Node node1 = new Node();
            node1.Age = 21;
            node1.Name = "Stan";

            Node node2 = new Node();
            node2.Age = 23;
            node2.Name = "Cad";

            stack.Push(node1);
            stack.Push(node2);

            stack.PrintStack();

            stack.Pop();
            stack.PrintStack();
        }
    }
}
