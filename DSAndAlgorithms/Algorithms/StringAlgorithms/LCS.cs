using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAndAlgorithms.StringAlgorithms
{
    public static class LCS
    {
        public static int? LongestCommonSubSequenceLength(char[] a, char[] b)
        {
            var aLen = a.Length + 1;
            var bLen = b.Length + 1;
            var lcsLengths = new int?[aLen,bLen];

            for (int i = 0; i < aLen; i++)
            {
                for (int j = 0; j < bLen; j++)
                {
                    if (i == 0 || j == 0)
                    {
                        lcsLengths[i, j] = 0;
                    }
                }
            }

            for (int i = 1; i < aLen; i++)
            {
                for (int j = 1; j < bLen; j++)
                {
                    if (a[i-1] ==b[j-1])
                    {
                        lcsLengths[i,j] = 1+ lcsLengths[i-1,j-1];
                    }
                    else
                    {
                        lcsLengths[i,j] = Math.Max(Convert.ToInt32(lcsLengths[i - 1,j]), Convert.ToInt32(lcsLengths[i,j - 1]));
                    }
                }
            }

            return lcsLengths[a.Length,b.Length];
        }
    }
}
