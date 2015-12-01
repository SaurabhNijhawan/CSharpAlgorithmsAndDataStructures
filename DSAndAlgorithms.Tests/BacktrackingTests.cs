using System;
using DSAndAlgorithms.Algorithms.Backtracking;
using DSAndAlgorithms.DataStructures.Tree;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DSAndAlgorithms;

namespace DSAndAlgorithms.Tests
{
    [TestClass]
    public class BacktrackingTests
    {
        [TestMethod]
        public void SudokuTests()
        {
          
            //int[,] input = new int[9,9]
            //{
            //    {
            //        0,1,0,8,0,9,0,5,0
            //    },
            //    {
            //        8,6,0,0,0,1,0,2,7
            //    },
            //   {
            //        9,0,4,0,0,0,0,0,0
            //    },
            //    {
            //        0,4,0,0,0,2,1,3,0
            //    },
            //    {
            //        3,5,0,0,0,0,0,7,0
            //    },  
            //    {
            //        0,9,0,5,0,0,6,0,8
            //    },
            //    {
            //        0,0,0,0,0,7,0,6,0
            //    },
            //    {
            //        0,8,0,0,0,0,0,0,2
            //    },
            //    {
            //        0,0,7,1,6,8,0,0,0
            //    },
            //};

            SudokuSolver.SolveMultipleSudokuProblems();
            //SudokuSolver.Solve(input);
        }

       
    }
}
