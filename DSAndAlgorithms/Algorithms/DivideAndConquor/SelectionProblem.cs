using System;

namespace DSAndAlgorithms.Algorithms.DivideAndConquor
{
    public static class SelectionProblem
    {
        public static int FindKthSmallestElement(int[] input, int k)
        {
            return AuxillaryFindKthSmallestElement(input, 0, input.Length - 1, k);
        }

        private static int AuxillaryFindKthSmallestElement(int[] input, int left, int right, int k)
        {
            if (left > right)
            {
                return Int32.MinValue;
            }

            int p = Partition(input, left, right);
            if (p - left + 1 == k)
            {
                return input[p];
            }

            if (p - left + 1 < k)
            {
                return AuxillaryFindKthSmallestElement(input, p+1, right, k-(p+1));
            }
            else
            {
                return AuxillaryFindKthSmallestElement(input, left, p - 1, k);
            }
        }

        private static int Partition(int[] input, int left, int right)
        {
            int lastMin = left;
            for (int current = left + 1; current <= right; current++)
            {
                if (input[current] < input[left])
                {
                    ++lastMin;
                    Swap(input, lastMin, current);
                }
            }

            Swap(input, left, lastMin);
            return lastMin;
        }

        private static void Swap(int[] input, int lastMin, int current)
        {
            int temp = input[lastMin];
            input[lastMin] = input[current];
            input[current] = temp;
        }
    }
}
