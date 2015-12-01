using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAndAlgorithms.DynamicProgramming
{
    static class LongestIncreasingSubsequence
    {

        /// <summary>
        /// If arr[i] > arr[j]
        /// T(i) = Max(T(i), T(j+1))
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static int Length(int[] input)
        {
            var lengths = new int[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                lengths[i] = 1;
            }

            for (int i = 1; i < input.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (input[i] > input[j] && lengths[i] < lengths[j] + 1)
                    {
                        lengths[i] = lengths[j] + 1;
                    }
                }
            }


            return lengths.Max();
        }
    }
}
