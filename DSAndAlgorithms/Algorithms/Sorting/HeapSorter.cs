﻿namespace SortingSelfCoded
{
    public static class HeapSorter
    {
        public static void HeapSort(int[] input)
        {
            //Build-Max-Heap O(NLogN) (Confirm)
            int heapSize = input.Length;
            for (int p = (heapSize - 1)/2; p >= 0; p--)
                MaxHeapify(input, heapSize, p);

            // Once MaxHeap is built, one by one get max item from heap and then Heapify again without that element( O(N))
            for (int i = input.Length - 1; i > 0; i--)
            {
                //Swap
                int temp = input[i];
                input[i] = input[0];
                input[0] = temp;

                heapSize--;
                MaxHeapify(input, heapSize, 0);
            }
        }


        private static void MaxHeapify(int[] input, int heapSize, int index)
        {
            int left = (index + 1)*2 - 1;
            int right = (index + 1)*2;
            int largest = 0;

            if (left < heapSize && input[left] > input[index])
                largest = left;
            else
                largest = index;

            if (right < heapSize && input[right] > input[largest])
                largest = right;

            if (largest != index)
            {
                int temp = input[index];
                input[index] = input[largest];
                input[largest] = temp;

                MaxHeapify(input, heapSize, largest);
            }
        }
    }
}