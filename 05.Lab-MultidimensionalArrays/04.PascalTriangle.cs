//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Numerics;
//using System.Text;
//using System.Threading.Tasks;

//namespace _05.Lab_MultidimensionalArrays
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            var size = int.Parse(Console.ReadLine());
//            BigInteger[][] triangle = new BigInteger[size][];
//            for (int i = 0; i < size; i++)
//            {
//                triangle[i] = new BigInteger[i + 1];
//                triangle[i][0] = 1;
//                for (int j = 1; j < triangle[i].Length - 1; j++)
//                {
//                    triangle[i][j] = triangle[i - 1][j - 1] + triangle[i - 1][j];
//                }
//                triangle[i][triangle[i].Length - 1] = 1;
//            }

//            foreach (var row in triangle)
//            {
//                Console.WriteLine(string.Join(" ", row));
//            }
//        }
//    }
//}
