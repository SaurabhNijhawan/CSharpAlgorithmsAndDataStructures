using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAndAlgorithms.StringAlgorithms
{
    public static class Combinotorics
    {
        public static List<string> PrintAllPossibleWordsByPressingNDigits(int[] digits)
        {
            var arr = new ArrayList();
            var map = new Dictionary<int, char[]>
            {
                {0, null},
                {1, null},
                {2, new[] {'A', 'B', 'C'}},
                {3, new[] {'D', 'E', 'F'}},
                {4, new[] {'G', 'H', 'I'}},
                {5, new[] {'J', 'K', 'L'}},
                {6, new[] {'M', 'N', 'O'}},
                {7, new[] {'P', 'Q', 'R', 'S'}},
                {8, new[] {'T', 'U', 'V'}},
                {9, new[] {'W', 'X', 'Y', 'Z'}},
            };

            List<String> res = new List<String>();
            List<String> preres = new List<String>();
            res.Add("");

            for (int i = 0; i < digits.Length; i++)
            {
                var temp = new List<string>();
                for (int index = 0; index < res.Count; index++)
                {
                    var str = res[index];
                    char[] letters = map[digits[i]];
                    for (int j = 0; j < letters.Length; j++)
                    {
                        preres.Add(str + letters[j]);
                    }
                    temp.AddRange(preres);
                    preres = new List<String>();
                }
                res = temp;
            }
            return res;
        }
    }
}
