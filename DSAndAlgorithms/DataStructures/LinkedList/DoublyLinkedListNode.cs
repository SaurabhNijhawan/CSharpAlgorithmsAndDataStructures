using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAndAlgorithms.LinkedList
{
    class DoublyLinkedListNode<T>
    {
        public T Data { get; private set; }
        public DoublyLinkedListNode<T> Previous { get; set; }

        public DoublyLinkedListNode<T> Next { get; set; }

        public DoublyLinkedListNode(T data)
        {
            this.Data = data;
        }
    }
}
