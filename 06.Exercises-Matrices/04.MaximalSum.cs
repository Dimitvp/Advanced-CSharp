//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Text.RegularExpressions;
//using System.Threading.Tasks;

//namespace _06.Exercises_Matrices
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            var matrixSize = Regex.Split(Console.ReadLine().Trim(), "\\s+").Select(int.Parse).ToArray();
//            var rows = matrixSize[0];
//            var cols = matrixSize[1];
//            var matrix = new double[rows][];
//            var maxSum = double.MinValue;
//            var maxRowIndex = 0;
//            var maxColIndex = 0;

//            for (int i = 0; i < rows; i++)
//            {
//                matrix[i] = Regex.Split(Console.ReadLine().Trim(), "\\s+").Select(double.Parse).ToArray();
//            }

//            for (int r = 0; r < rows - 2; r++)
//            {
//                for (int c = 0; c < cols - 2; c++)
//                {
//                    var sum = matrix[r + 0][c] + matrix[r + 0][c + 1] + matrix[r + 0][c + 2] +
//                              matrix[r + 1][c] + matrix[r + 1][c + 1] + matrix[r + 1][c + 2] +
//                              matrix[r + 2][c] + matrix[r + 2][c + 1] + matrix[r + 2][c + 2];

//                    if (sum > maxSum)
//                    {
//                        maxSum = sum;
//                        maxRowIndex = r;
//                        maxColIndex = c;
//                    }
//                }
//            }

//            Console.WriteLine($"Sum = {maxSum}");
//            for (int i = maxRowIndex; i <= maxRowIndex+2; i++)
//            {
//                for (int j = maxColIndex; j <= maxColIndex+2; j++)
//                {
//                    Console.Write($"{matrix[i][j]} ");
//                }
//                Console.WriteLine();
//            }

//        }
//    }
//}
