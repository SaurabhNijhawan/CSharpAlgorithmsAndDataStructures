using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAndAlgorithms.Algorithms.DynamicProgramming
{
    static class CoinChangeProblem
    {
        public static int GetMinimumNumberOfCoins(int[] denominations, int amount)
        {
          //int[] minimums = new int[amount];

          //  for (int i = 1; i <= amount; i++)
          //  {
          //      for (int j = 0; j < denominations.Length; j++)
          //      {
          //          if()
          //          minimums[i]
          //      }

          //  }
            return 1;
        }

        public static int GetNoOfWaysToReturnChange(int[] denominations, int amount)
        {
            int i, j, resultX, resultY;
            int noOfDenominations = denominations.Count();
            int[,] outputTable = new int[amount + 1, noOfDenominations];


            for (i = 0; i < noOfDenominations; i++)
                outputTable[0, i] = 1;


            for (i = 1; i < amount + 1; i++)
            {
                for (j = 0; j < noOfDenominations; j++)
                {

                    resultX = (i - denominations[j] >= 0) ? outputTable[i - denominations[j], j] : 0;


                    resultY = (j >= 1) ? outputTable[i, j - 1] : 0;


                    outputTable[i, j] = resultX + resultY;
                }
            }
            return outputTable[amount, noOfDenominations - 1];
        }
    }
}
