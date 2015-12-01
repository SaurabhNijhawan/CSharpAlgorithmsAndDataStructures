using System;

namespace DSAndAlgorithms
{
    internal static class InsertionSorter
    {
        /// <summary>
        /// Like you do in cards
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="inputArray"></param>
        /// <returns>Sorted Array</returns>
        public static T[] Sort<T>(T[] inputArray) where T : IComparable<T>
        {
            for (int i = 1; i < inputArray.Length; i++)
            {
                for (int j = i - 1; j >= 0; j--)
                {
                    if (inputArray[j + 1].CompareTo(inputArray[j]) < 0)
                    {
                        T temp = inputArray[j + 1];
                        inputArray[j + 1] = inputArray[j];
                        inputArray[j] = temp;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            return inputArray;
        }
    }
}