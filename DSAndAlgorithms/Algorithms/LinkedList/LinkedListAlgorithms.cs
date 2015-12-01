using System.Collections.Generic;
using DSAndAlgorithms.DataStructures.LinkedList;

namespace DSAndAlgorithms.Algorithms.LinkedList
{
     internal static class LinkedListAlgorithms<T>
    {
        public static void SwapAlternateElementsUsingSwappingOfData(Node<T> header)
        {
            if (header == null )
            {
                return;
            }

            var current = header.Next;
            while (current != null && current.Next != null)
            {
                T data = current.Data;
                current.Data = current.Next.Data;
                current.Next.Data = data;
                current = current.Next.Next;
            }
        }

        public static void SwapAlternateElementsByExchangingLinks(Node<T> header)
         {
             if (header == null)
             {
                 return;
             }

             var prev = header;
             var current = header.Next;
             var next = current.Next;

             while (current!=null && next!=null)
             {
                 current.Next = next.Next;
                 next.Next = current;
                 prev = next;

             }
         }

        public static T FindNthElementFromEndUsingPredeterminedLengthOfLinkedList(int n, Node<T> headerer)
        {
            int m = DataStructures.LinkedList.LinkedList<T>.Size(headerer) - n + 1;
            Node<T> temp = headerer;
            while (m != 0)
            {
                m--;
                temp = temp.Next;
            }
            return temp.Data;
        }

        public static T FindNthElementFromEndUsingTwoPointers(int n, Node<T> header)
        {
            Node<T> first = header;
            Node<T> second = header;

            while (n != 0)
            {
                first = first.Next;
                n--;
            }

            while (first.Next != null)
            {
                first = first.Next;
                second = second.Next;
            }

            return second.Data;
        }

        public static Node<T> FindMiddleElement(Node<T> header)
        {
            Node<T> slow = header, fast = header;

            while (fast != null && fast.Next != null)
            {
                slow = slow.Next;
                fast = fast.Next.Next;
            }

            return slow;
        }

        public static Node<T> FindFirstDuplicateElementUsingSet(Node<T> header)
        {
            var set = new HashSet<Node<T>>();
            var current = header.Next;
            while (current != null)
            {
                set.Add(current);
                current = current.Next;
            }

            var curr = header.Next;
            while (curr != null)
            {
                if (set.Contains(curr))
                {
                    return curr;
                }

                curr = curr.Next;
            }
            return null;
        }

        public static Node<T> Reverse(Node<T> head)
         {
             var current = head;
             Node<T> result = null;

             while (current != null)
             {
                 Node<T> next = current.Next;
                 current.Next = result;
                 result = current;
                 current = next;
             }
            
             return result;
         }

         public static Node<T> RearrangeLinkedList(Node<T> head)
         {
             if (head == null)
             {
                 return head;
             }

             var current = head;
             while (current.Next!=null)
             {
                 var temp = current.Next;
                 while (temp.Next!=null)
                 {
                     
                 }

             }
             return head;
         }


    }
}
