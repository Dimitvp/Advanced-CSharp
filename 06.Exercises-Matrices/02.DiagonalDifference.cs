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

//            int matrixSize = int.Parse(Console.ReadLine());
//            double[][] matrix = new double[matrixSize][];
//            double leftSum = 0;
//            double rightSum = 0;
//            for (int i = 0; i < matrixSize; i++)
//            {
//                matrix[i] = Regex.Split(Console.ReadLine().Trim(), "\\s+").Select(double.Parse).ToArray();
//                leftSum += matrix[i][i];
//                rightSum += matrix[i][matrix.Length - (1 + i)];
//            }

//            Console.WriteLine(Math.Abs(leftSum - rightSum));
//        }
//    }
//}

