using System;

namespace DSAndAlgorithms.DynamicProgramming
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
                    if (a[i-1] == b[j-1])
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



///* Dynamic Programming implementation of LCS problem */
//#include<stdio.h>
//#include<stdlib.h>
 
//int max(int a, int b);
 
///* Returns length of LCS for X[0..m-1], Y[0..n-1] */
//int lcs( char *X, char *Y, int m, int n )
//{
//   int L[m+1][n+1];
//   int i, j;
 
//   /* Following steps build L[m+1][n+1] in bottom up fashion. Note 
//      that L[i][j] contains length of LCS of X[0..i-1] and Y[0..j-1] */
//   for (i=0; i<=m; i++)
//   {
//     for (j=0; j<=n; j++)
//     {
//       if (i == 0 || j == 0)
//         L[i][j] = 0;
 
//       else if (X[i-1] == Y[j-1])
//         L[i][j] = L[i-1][j-1] + 1;
 
//       else
//         L[i][j] = max(L[i-1][j], L[i][j-1]);
//     }
//   }
   
//   /* L[m][n] contains length of LCS for X[0..n-1] and Y[0..m-1] */
//   return L[m][n];
//}
 
///* Utility function to get max of 2 integers */
//int max(int a, int b)
//{
//    return (a > b)? a : b;
//}
 
///* Driver program to test above function */
//int main()
//{
//  char X[] = "AGGTAB";
//  char Y[] = "GXTXAYB";
 
//  int m = strlen(X);
//  int n = strlen(Y);
 
//  printf("Length of LCS is %d\n", lcs( X, Y, m, n ) );
 
//  getchar();
//  return 0;
//}