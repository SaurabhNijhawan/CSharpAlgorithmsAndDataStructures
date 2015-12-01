using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAndAlgorithms.StringAlgorithms
{
    public static class Anagrams
    {
       // We can also convert string to char arrays and do an XOR of all int values of chars, if finally we don't get 0 then they are not equal
        public static bool AreTwoStringsAnagrams(string s1, string s2)
        {
            // Short circuit if any of the strings are null or whitespace 
            if (string.IsNullOrWhiteSpace(s1) || string.IsNullOrWhiteSpace(s2))
            {
                return false;
            }

            // Short circuit if the strings are not of equal length
            if (s1.Length != s2.Length)
            {
                return false;
            }

            // O(L) space complexity, where L is the Lenght of the largest string
            char[] c1 = s1.ToLower().ToCharArray();
            char[] c2 = s2.ToLower().ToCharArray();

            Array.Sort(c1);
            Array.Sort(c2);

            for(int i = 0; i < c1.Length; i++)
            {
                if (c1[i] != c2[i])
                {
                    return false;
                }
            }

            return true;
        }
        
        public static void DisplayAllAnagramsTogether(string[] s1)
        {
            int[] indexes = new int[s1.Length];

            for (int i = 0; i < s1.Length; i++)
            {
                indexes[i] = i;
            }

            string[] EachStringSorted = new string[s1.Length];
            for (int index = 0; index < s1.Length; index++)
            {
                var s = s1[index];
                var chars = s.ToCharArray();
                Array.Sort(chars);
                string m = new string(chars);
                EachStringSorted[index] = m;
            }

            for (int i = 0; i < EachStringSorted.Length; i++)
            {
                for (int j = i + 1; j < EachStringSorted.Length; j++)
                {
                    if (string.Compare(EachStringSorted[j], EachStringSorted[i]) < 0)
                    {
                        string temp = EachStringSorted[j];
                        EachStringSorted[j] = EachStringSorted[i];
                        EachStringSorted[i] = temp;

                        int temp1 = indexes[j];
                        indexes[j] = indexes[i];
                        indexes[i] = temp1;
                    }
                }
            }

            foreach (var index in indexes)
            {
                Console.Write(s1[index] + " ");
            }
        }
    }
}