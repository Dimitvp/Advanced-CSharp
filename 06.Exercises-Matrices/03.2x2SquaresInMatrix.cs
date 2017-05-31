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
//            var matrix = new string[rows][];
//            var count = 0;

//            for (int i = 0; i < rows; i++)
//            {
//                matrix[i] = Regex.Split(Console.ReadLine().Trim(), "\\s+").ToArray();
//            }

//            for (int r = 0; r < rows - 1; r++)
//            {
//                for (int c = 0; c < cols - 1; c++)
//                {
//                    if (matrix[r][c] == matrix[r][c + 1] && matrix[r][c] == matrix[r + 1][c] &&
//                        matrix[r][c] == matrix[r + 1][c + 1])
//                    {
//                        count++;
//                    }
//                }
//            }

//            Console.WriteLine(count);

//        }
//    }
//}
