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
//            var sum = 0;
//            for (int i = 0; i < rows; i++)
//            {
//                var counter = 0;
//                var row = Regex.Split(Console.ReadLine(), ", ").Select(int.Parse).ToArray();
//                matrix[i] = new int[cols];
//                for (int j = 0; j < cols; j++)
//                {
//                    matrix[i][j] = row[counter];
//                    sum += row[counter];
//                    counter++;
//                }
//            }

//            Console.WriteLine($"{rows}\n{cols}\n{sum}");
//        }
//    }
//}
