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
//            var matrixSize = Regex.Split(Console.ReadLine(), "\\s+").Select(int.Parse).ToArray();
//            char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
//            var result = new string[matrixSize[0]][];
//            for (int r = 0; r < matrixSize[0]; r++)
//            {
//                result[r] = new string[matrixSize[1]];
//                for (int c = 0; c < matrixSize[1]; c++)
//                {
//                    result[r][c] = $"{alphabet[r]}{alphabet[r + c]}{alphabet[r]}";
//                }
//            }

//            for (int r = 0; r < matrixSize[0]; r++)
//            {
//                Console.WriteLine(string.Join(" ", result[r]));
//            }

//        }
//    }
//}
