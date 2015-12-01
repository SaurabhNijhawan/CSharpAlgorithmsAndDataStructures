using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAndAlgorithms.Algorithms.Recursion
{
    static class RecursionAlgorithms
    {
        public static long Power(int x, int n)
        {
            if (n == 0) return 1;
            if (n == 1) return x;
            
            if ((n & 1) == 0)
            {
                // n is even
                var temp = Power(x, n/2);
                return temp*temp;
            }
            else
            {
                // n is odd
                var temp = Power(x, n / 2);
                return temp * temp * x;   
            }
        }

        public static void TowerOfHanoi(int n, char source, char auxiliary, char target)
        {
            if(n == 0) return;

            TowerOfHanoi(n-1, source, target, auxiliary);
            Console.WriteLine(source + " -->" + target);
            TowerOfHanoi(n-1, auxiliary, source,target);
        }

        public static void GenerateBinaryStrings(int n)
        {
            var outArray = new int[n];
            AuxGenerateBinaryStrings(0, n, outArray);
        }

        private static void AuxGenerateBinaryStrings(int depth, int n, int[] outArray)
        {
            if (depth == n)
            {
                Console.WriteLine(string.Join(" ", outArray.Select(v => v.ToString())));
                return;
            }

            for (int i = 0; i <= 1; i++)
            {
                outArray[depth] = i;
                AuxGenerateBinaryStrings(depth+1,n,outArray);
            }
        }
    }
}
