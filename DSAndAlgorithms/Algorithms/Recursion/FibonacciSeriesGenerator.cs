using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAndAlgorithms.Algorithms.Recursion
{
    static class FibonacciSeriesGenerator
    {
        public static void Generate()
        {
            int a = 0;
            int b = 1;
            Console.WriteLine(a);
            Console.WriteLine(b);

            GenerateCore(a, b);
        }

        private static void GenerateCore(int a, int b)
        {
            int sum = a + b;
            if (sum < 1000)
            {
                Console.WriteLine(sum);
                a = b;
                b = sum;
                GenerateCore(a, b);
            }
        }

    }
}
