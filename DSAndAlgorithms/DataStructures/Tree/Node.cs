using System;

namespace DSAndAlgorithms.DataStructures.Tree
{
    public class Node<E> 
    {
        public E data;
        public Node<E> Left;
        public Node<E> Right;

        public void DisplayNode()
        {
            Console.Write("[");
            Console.Write(data);
            Console.Write("]");
        }

        public override string ToString()
        {
            return this.data.ToString();
        }
    }
}