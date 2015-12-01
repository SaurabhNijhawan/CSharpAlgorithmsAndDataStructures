using System;

namespace DSAndAlgorithms.ProblemSolving.Codility
{
    static class TapeEquilibriumSolver
    {
        public static int Solve(int[] input)
        {
            
            int sum = 0;
            int leftSum = 0;
            int[] diff = new int[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                sum += input[i];
            }

            for (int j = 0; j < input.Length; j++)
            {
                leftSum += input[j];
                int rightSum = sum - leftSum;
                diff[j] = Math.Abs(leftSum - rightSum);
            }

            int min = diff[0];
            for (int i = 1; i < diff.Length - 1; i++)
            {
                if (diff[i] < min)
                {
                    min = diff[i];
                }
            }
            return min;
        }

        public static int solution(int X, int Y, int D)
        {
            // write your code in C# 5.0 with .NET 4.5 (Mono)

            var noOfJumps = Math.Ceiling((Y - X) / (decimal)D);
            return  Convert.ToInt32(noOfJumps);
        }

        public static int solution(int X, int[] A)
        {
            // write your code in C# 5.0 with .NET 4.5 (Mono)
            int[] x = new int[X];
            int k = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] < X)
                {
                    if (x[i] == 0)
                    {
                        x[i] = 1;
                        k++;
                    }
                }
                if (k == X - 1)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
