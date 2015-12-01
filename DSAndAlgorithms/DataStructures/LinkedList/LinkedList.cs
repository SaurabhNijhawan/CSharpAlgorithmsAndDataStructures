using System;

namespace DSAndAlgorithms.DataStructures.LinkedList
{
    /// <summary>
    /// This is a static class because it doesn't maintains any state, i.e. the head pointer. The head pointer is instead passed to it.
    /// We can make it a non-static class, then we have to make Head an instance variable of this class and initialize it in the ctor.
    /// </summary>
    /// <typeparam name="T"></typeparam>
     static class LinkedList<T>
    {
        public static void Add(Node<T> head, T data)
        {
            var node = new Node<T> {Data = data};
            var current = head;

            while (current.Next!=null)
            {
                current = current.Next;
            }

            current.Next = node;
        }

        public static bool Contains(Node<T> head, T element)
        {
            var current = head.Next;
            while (current != null)
            {
                if (current.Data.Equals(element))
                {
                    return true;
                }

                current = current.Next;
            }

            return false;
        }

        public static void Traverse(Node<T> head)
        {
            var temp = head.Next;
            while (temp!=null)
            {
                Console.Write(temp.Data + "->");
                temp = temp.Next;
            }
            Console.WriteLine();
        }

        public static int Size(Node<T> head)
        {
            int size = 0;
            Node<T> temp = head;
            while (temp!=null)
            {
                size++;
                temp = temp.Next;
            }
            return size;
        }
    }



}
