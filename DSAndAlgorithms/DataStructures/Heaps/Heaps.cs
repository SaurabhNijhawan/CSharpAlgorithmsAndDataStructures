using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAndAlgorithms.Heaps
{
    public static class Heaps
    {
        public static void BuildMaxHeap(int[] array)
        {
            int length = HeapSize(array);

            for (int i = length/2; i > 0; i--)
            {
                MaxHeapify(array, i);
            }

            return ;
        }

        public static int[] MaxHeapify(int[] array, int index)
        {
            var left = 2*index;
            var right = 2*index + 1;
            
            int max=index;
            if (left <= HeapSize(array) && array[left-1] > array[index-1])
            {
                max = left;
            }
              
            if (right <= HeapSize(array) && array[right-1] > array[max-1])
            {
                max = right;
            }

            if (max != index)
            {
                int temp = array[max-1];
                array[max-1] = array[index-1];
                array[index-1] = temp;
                MaxHeapify(array, max);
            }
            
            return array;
        }
        public static int[] MinHeapify(int[] array, int index)
        {
            var left = 2 * index;
            var right = 2 * index + 1;


            int max = index;
            if (left <= HeapSize(array) && array[left - 1] < array[index - 1])
            {
                max = left;
            }

            if (right <= HeapSize(array) && array[right - 1] < array[max - 1])
            {
                max = right;
            }

            if (max != index)
            {
                int temp = array[max - 1];
                array[max - 1] = array[index - 1];
                array[index - 1] = temp;
                MaxHeapify(array, max);
            }

            return array;
        }

        public static int HeapSize(int[] a)
        {
            return a.Length;
        }
    }
}
