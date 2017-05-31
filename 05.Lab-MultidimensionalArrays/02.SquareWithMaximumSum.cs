//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Text.RegularExpressions;
//using System.Threading.Tasks;

//namespace _05.Lab_MultidimensionalArrays
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            var input = Console.ReadLine();
//            var matrixSize = Regex.Split(input, ", ").Select(int.Parse).ToArray();
//            var rows = matrixSize[0];
//            var cols = matrixSize[1];
//            var matrix = new int[rows][];
//            var maxSum = int.MinValue;
//            var maxArr = new int[2][];
//            maxArr[0] = new[] { Int32.MinValue, Int32.MinValue };
//            maxArr[1] = new[] { Int32.MinValue, Int32.MinValue };
//            ArrayInit(rows, cols, matrix);
//            maxSum = FinxMaxSquare(rows, cols, matrix, maxSum, maxArr);
//            PrintResult(maxSum, maxArr);

//        }

//        private static void PrintResult(int maxSum, int[][] maxArr)
//        {
//            foreach (int i in maxArr[0])
//            {
//                Console.Write($"{i} ");
//            }
//            Console.WriteLine();
//            foreach (int i in maxArr[1])
//            {
//                Console.Write($"{i} ");
//            }
//            Console.WriteLine();
//            Console.WriteLine(maxSum);
//        }

//        private static int FinxMaxSquare(int rows, int cols, int[][] matrix, int maxSum, int[][] maxArr)
//        {
//            for (int i = 0; i < rows - 1; i++)
//            {
//                for (int j = 0; j < cols - 1; j++)
//                {
//                    var currentSum = matrix[i][j] + matrix[i + 1][j] + matrix[i][j + 1] + matrix[i + 1][j + 1];
//                    if (currentSum > maxSum)
//                    {
//                        maxSum = currentSum;
//                        maxArr[0][0] = matrix[i][j];
//                        maxArr[1][0] = matrix[i + 1][j];
//                        maxArr[0][1] = matrix[i][j + 1];
//                        maxArr[1][1] = matrix[i + 1][j + 1];
//                    }
//                }
//            }

//            return maxSum;
//        }

//        private static void ArrayInit(int rows, int cols, int[][] matrix)
//        {
//            for (int i = 0; i < rows; i++)
//            {
//                var counter = 0;
//                var row = Regex.Split(Console.ReadLine(), ", ").Select(int.Parse).ToArray();
//                matrix[i] = new int[cols];
//                for (int j = 0; j < cols; j++)
//                {
//                    matrix[i][j] = row[counter];
//                    counter++;
//                }
//            }
//        }
//    }
//}
