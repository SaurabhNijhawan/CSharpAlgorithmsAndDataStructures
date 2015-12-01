using System;
using DSAndAlgorithms.Stacks;

namespace DSAndAlgorithms.DataStructures.Stacks
{
    class Stack
    {
        public Node Top { get; private set; }

        public void Push(Node newNode)
        {
            newNode.Next = Top;
            Top = newNode;
        }

        public Node Pop()
        {
            Node temp = Top;
            Top = Top.Next;
            return temp;
        }

        public void PrintStack()
        {
            Node tempTop = Top;
            while (tempTop != null)
            {
                Console.WriteLine("Age: {0} , Name: {1}", tempTop.Age, tempTop.Name);
                tempTop = tempTop.Next;
            }
        }
    }
}