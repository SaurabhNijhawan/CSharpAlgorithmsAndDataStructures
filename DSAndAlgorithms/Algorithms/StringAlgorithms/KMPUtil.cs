using System;

namespace DSAndAlgorithms.Algorithms.StringAlgorithms
{
    public class StringSearcher  // Knuth-Morris-Pratt string search
    {
        private char[] pattern;  // the (small) pattern to search for
        private int[] Table;   // lets the search function to skip ahead

        public StringSearcher(char[] W)
        {
            this.pattern = new char[W.Length];
            Array.Copy(W, this.pattern, W.Length);
            this.Table = BuildTable(W);           // use a helper to build T
        }

        private int[] BuildTable(char[] W)
        {
            int[] result = new int[W.Length];
            int pos = 2;
            int cnd = 0;
            result[0] = -1;
            result[1] = 0;
            while (pos < W.Length)
            {
                if (W[pos - 1] == W[cnd])
                {
                    ++cnd; result[pos] = cnd; ++pos;
                }
                else if (cnd > 0)
                    cnd = result[cnd];
                else
                {
                    result[pos] = 0; ++pos;
                }
            }
            return result;
        }

        public int Search(char[] inputString)
        {
            int m = 0;
            int i = 0;
            while (m + i < inputString.Length)
            {
                if (this.pattern[i] == inputString[m + i])
                {
                    if (i == this.pattern.Length - 1)
                        return m;
                    ++i;
                }
                else
                {
                    m = m + i - this.Table[i];
                    if (this.Table[i] > -1)
                        i = this.Table[i];
                    else
                        i = 0;
                }
            }
            return -1; 
        }
    }
}
