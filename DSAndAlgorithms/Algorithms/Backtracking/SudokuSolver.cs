using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mime;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DSAndAlgorithms.Algorithms.Backtracking
{
    static class SudokuSolver
    {

        public static void SolveMultipleSudokuProblems()
        {
            var path = Directory.GetCurrentDirectory() + @"\Algorithms\Backtracking\samplesudoku.txt";
            string[] f = File.ReadAllLines(path);

            var allProblems = new List<int[]>();
            foreach (var s in f)
            {
                
                char[] characters = s.ToCharArray();
                if (characters.Length >0 && (characters[0] == '.' || Char.IsNumber(characters[0])))
                {
                    var row = new int[9];
                    int index = 0;
                    foreach (var character in characters)
                    {
                        if (character == '.')
                        {
                            row[index] = 0;
                        }
                        else if (character == ' ' || character == '|')
                        {
                            continue;
                        }
                        else
                        {
                            row[index] = character - '0';
                        }

                        index++;
                    }

                    allProblems.Add(row);
                }
            }

            int noOfProblems = allProblems.Count/9;
           var problems = new List<int[,]>();

            for (int i = 0; i < noOfProblems; i++)
            {
                var problem = new int[9, 9];
                for (int j = 0; j < 9; j++)
                {
                    problem[0,j] = allProblems[0][j];
                    problem[1, j] = allProblems[1][j];
                    problem[2, j] = allProblems[2][j];
                    problem[3, j] = allProblems[3][j];
                    problem[4, j] = allProblems[4][j];
                    problem[5, j] = allProblems[5][j];
                    problem[6, j] = allProblems[6][j];
                    problem[7, j] = allProblems[7][j];
                    problem[8, j] = allProblems[8][j];
                }

                problems.Add(problem);
            }

            Parallel.ForEach(problems, problem => Solve(problem));
        }

        public static bool Solve(int[,] input)
        {
               int row = 0;
         int col = 0;
            if (!FindEmptyLocation(input, ref row, ref col))
            {
                return true;
            }

            for (int i = 1; i <=input.GetLength(0); i++)
            {
                if (IsSafe(input, row, col, i))
                {
                    input[row, col] = i;

                    if (Solve(input))
                    {
                        return true;
                    }

                    input[row, col] = 0;

                }
            }

            return false;


        }

        private static bool IsSafe(int[,] input, int row, int col, int number)
        {

            return !UsedInRow(input, row, number) &&
                   !UsedInColumn(input, col, number) &&
                   !UsedInBox(input, Convert.ToInt32(row - row % Math.Sqrt(input.GetLength(0))), Convert.ToInt32(col - col % Math.Sqrt(input.GetLength(0))), number);
        }

        private static bool UsedInBox(int[,] input, int d, int i, int number)
        {
            for (int rowTemp = 0; rowTemp < Convert.ToInt32(Math.Sqrt(input.GetLength(0))); rowTemp++)
            {
                for (int colTemp = 0; colTemp < Convert.ToInt32(Math.Sqrt(input.GetLength(0))); colTemp++)
                {
                    if (input[rowTemp + d, colTemp + i] == number)
                    {
                        return true;
                    }
                }   
            }

            return false;
        }

        private static bool FindEmptyLocation(int[,] input, ref int row, ref int col)
        {
            for (int i = 0; i < input.GetLength(0); i++)
            {
                for (int j = 0; j < input.GetLength(0); j++)
                {
                    if (input[i, j] == 0)
                    {
                        row = i;
                        col = j;

                        return true;
                    } 
                }
              
            }

            return false;

        }

        private static bool UsedInRow(int[,] input, int row, int number)
        {

            for (int col = 0; col < input.GetLength(0); col++)
            {
                if (input[row, col] == number)
                {
                    return true;
                }
            }

            return false;
        }

        private static bool UsedInColumn(int[,] input, int col, int number)
        {
            for (int row = 0; row < input.GetLength(0); row++)
            {
                if (input[row, col] == number)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
