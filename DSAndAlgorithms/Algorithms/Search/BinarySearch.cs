using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAndAlgorithms.Search
{
    public static class BinarySearcher
    {
        public static int BinarySearchRecursive(int[] array, int start, int end, int element)
        {
            if (end >= start)
            {
                int mid = start + (end - start)/2;

                if (array[mid] == element)
                    return mid;

                if (array[mid] > element)
                    return BinarySearchRecursive(array, start, mid - 1, element);

                return BinarySearchRecursive(array, mid+1, end, element);
            }

            return -1;
        }

        public static int BinarySearch(int[] input, int element)
        {
            int startIndex = 0;
            int endIndex = input.Length - 1;
            
            while (startIndex <= endIndex)
            {
                int mid = startIndex + (endIndex - startIndex) / 2;
                if (element == input[mid])
                {
                    return mid;
                }

                if (element > input[mid])
                {
                    startIndex = mid + 1;
                }
                else
                {
                    endIndex = mid - 1;
                }

            }
            return 0;
        }
    }
}
