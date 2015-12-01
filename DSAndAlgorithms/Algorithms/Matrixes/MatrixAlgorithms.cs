using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAndAlgorithms.Algorithms.Matrixes
{
    public static class MatrixAlgorithms
    {
        public static int[,] Rotate90(int[,] input)
        {
            int rows = input.GetUpperBound(0);
            int columns = input.GetUpperBound(1);
            var temp = new int[rows+1,columns+1];

            for (int i = 0; i <= rows; i++)
            {
                for (int j = 0; j <= columns; j++)
                {
                    temp[rows-j, i] = input[i, j];
                }
            }

            return temp;
        }

    }
}
