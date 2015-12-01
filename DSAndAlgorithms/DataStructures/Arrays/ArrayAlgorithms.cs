using System;
using System.Collections.Generic;

namespace DSAndAlgorithms.DataStructures.Arrays
{
    internal static class ArrayAlgorithms
    {
        /// <summary>
        /// Given an array of n integers. Find non- repeated element
        /// Finds the non repeated element using map.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns></returns>
        public static int FindNonRepeatedElementUsingMap(int[] input)
        {
            var dictionary = new Dictionary<int, int>();

            foreach (var element in input)
            {
                if (!dictionary.ContainsKey(element))
                {
                    dictionary.Add(element, 1);
                }
                else
                {
                    dictionary[element] = dictionary[element] + 1;
                }
            }

            foreach (var element in dictionary)
            {
                if (element.Value == 1)
                {
                    return element.Key;
                }
            }

            return -1;
        }
        
        /// <summary>
        /// Given an array of size N, in which each element is b/w 0-N. Finds the missing number.
        /// Cons: If n is large, Sum may overflow
        /// Pro: O(N)
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns></returns>
        public static int FindMissingNumberUsingSum(int[] input)
        {
            int N = input.Length;
            int sumN = N*(N + 1)/2;
            int sumNumbers = 0;
            foreach (var i in input)
            {
                sumNumbers += i;
            }

            return sumN - sumNumbers;
        }

        /// <summary>
        /// Given an array of size N, in which each element is b/w 0-N. Finds the missing number.
        /// Cons: If n is large, Sum may overflow
        /// Pro: O(N)
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns></returns>
        public static int FindMissingNumberUsingXOR(int[] input)
        {
            var xor = 0;
            for (int i = 0; i < input.Length; i++)
            {
                xor ^= i ^ input[i];
            }

            xor ^= input.Length;

            return xor;
        }

        public static int Replace0With5InIntegerValue(int input)
        {
            int temp = input;
            int multiple = 1;
            while (temp > 0)
            {
                int digit = temp%10;
                temp = temp/10;


                if (digit == 0)
                {
                    input += 5*multiple;
                }

                multiple *= 10;
            }

            return input;
        }

        public struct Point
        {
            private int X;
            private int Y;
        }

        #region 2 D Arrays

        /// <summary>
        /// Given a 2D array, with all of its columns and rows sorted.
        /// Find an efficient algorithm to search an element
        /// </summary>
        /// <param name="input"></param>
        /// <param name="element"></param>
        /// <returns></returns>
        public static Point SearchElementInSortedTwoDArray(int[][] input, int element)
        {
            // TODO
            return new Point();
        }


        /// <summary>
        /// Prints the matrix in spiral form.
        /// </summary>
        /// <param name="input">The input.</param>
        public static void PrintMatrixInSpiralForm(int[,] input)
        {
            int i, k = 0, l = 0;
            int m = input.GetLength(0);
            int n = 0;

            /*  k - starting row index
                 m - ending row index
                 l - starting column index
                 n - ending column index
                 i - iterator
             */

            while (k < m && l < n)
            {
                /* Print the first row from the remaining rows */
                for (i = l; i < n; ++i)
                {
                    Console.WriteLine(input[k, i]);
                }
                k++;

                /* Print the last column from the remaining columns */
                for (i = k; i < m; ++i)
                {
                    Console.WriteLine(input[i, n - 1]);
                }
                n--;

                /* Print the last row from the remaining rows */
                if (k < m)
                {
                    for (i = n - 1; i >= l; --i)
                    {
                        Console.WriteLine(input[m - 1, i]);
                    }
                    m--;
                }

                /* Print the first column from the remaining columns */
                if (l < n)
                {
                    for (i = m - 1; i >= k; --i)
                    {
                        Console.WriteLine(input[i, l]);
                    }
                    l++;
                }
            }
        }

        #endregion

        /// <summary>
        /// An array is given with element name and their respective pH values. Print the combination of 2 elements which make a neutral compound
        /// </summary>
        /// <param name="input"></param>
        public static void FindCombinationSuchThatPHValueIsNeutralized(PhValue[] input)
        {
            var map = new Dictionary<int, string>();
            foreach (var phValue in input)
            {
                if (!map.ContainsKey(-phValue.Value))
                {
                    map.Add(phValue.Value, phValue.Element);
                }

                else
                {
                    Console.WriteLine(phValue.Element + "," + map[-phValue.Value]);
                    break;
                }
            }
        }
    }

    internal class PhValue
    {
        public string Element { get; set; }
        public int Value { get; set; }
    }
}