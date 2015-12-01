using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DSAndAlgorithms.Algorithms.Sorting
{
    /// <summary>
    /// Select the minimum in each pass and swap with ith value
    /// </summary>
    static class SelectionSorter
    {
        public static T[] Sort<T>(T[] input) where T: IComparable<T>
        {
            for (int i = 0; i < input.Length-1; i++)
            {
                var min = input[i];
                for (int j = i; j < input.Length-1; j++)
                {
                   
                    if (input[j].CompareTo(min) < 0)
                    {
                        min = input[j];
                    }
                }
                input[i] = min;
            }
            return input;
        }
    }
}
