using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAndAlgorithms.Algorithms.Sorting
{
    static class TestSorter
    {
        public static int[] Sort(int[] input)
        {
            
            return AuxSort(input, 0, input.Length-1);

        }

        private static int[] AuxSort(int[] input, int l, int r)
        {
            if (l < r)
            {
                int p = Partition(input, l, r);
                AuxSort(input, l, p - 1);
                AuxSort(input, p + 1, r);
            }

            return input;
        }

        private static int Partition(int[] input, int l, int r)
        {
            int pivot = input[l];

            return 1;
        }
    }
}
