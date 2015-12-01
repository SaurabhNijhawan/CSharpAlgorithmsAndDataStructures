using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAndAlgorithms.InbuiltCollection
{
    class HowToArrays
    {
        public static void HowTo()
        {
            // Array Covariance
            string[] names = new string[10];
            Object[] namesObjects;
            namesObjects = names; // Arrays are covariant, Lists and other generic collections are not.

            // 2D Arrays: Note it's a comma in the bracket not 2 brackets, 2 brackets  is Jagged arrays
            int [,] int2DArray = new int[10,10];

        }
    }
}
