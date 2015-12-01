using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAndAlgorithms.LinkedList
{
    class DoublyLinkedList<T>
    {
        public int Size { get; private set; }
        public DoublyLinkedListNode<T> Head { get; private set; }

        public DoublyLinkedList(DoublyLinkedListNode<T> head)
        {
            this.Head = head;
            Head.Next = Head;
            Head.Previous = Head;
        }

        public bool Add(T data)
        {
            var newElement = new DoublyLinkedListNode<T>(data);
            var temp = Head.Previous;
            Head.Previous = newElement;
            newElement.Next = Head;
            temp.Next = newElement;
            newElement.Previous = temp;
            Size++;
            return true;
        }

        public void Traverse()
        {
            var current = Head.Next;
            while (current != Head)
            {
                Console.Write(current.Data + "->");
                current = current.Next;
            }
            Console.WriteLine();
        }

        public void RemoveNode(DoublyLinkedListNode<T> doublyLinkedListNode)
        {

        }
    }
}
