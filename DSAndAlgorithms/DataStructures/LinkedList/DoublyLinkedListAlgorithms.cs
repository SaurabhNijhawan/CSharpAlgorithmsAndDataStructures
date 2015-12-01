using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAndAlgorithms.LinkedList
{
    static class DoublyLinkedListAlgorithms<T>
    {
        public static void Reverse(DoublyLinkedListNode<T> head)
        {
            var current = head.Next;

            while (current!=head)
            {
                var temp = current.Next;
                current.Next = current.Previous;
                current.Previous = temp;
                current = temp;
            }

            var last = head.Previous;
            head.Previous = head.Next;
            head.Next = last;

        }
    }
}
