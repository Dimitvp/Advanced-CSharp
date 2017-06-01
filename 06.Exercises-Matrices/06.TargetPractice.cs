//using System;
//using System.Linq;
//using System.Text.RegularExpressions;

//namespace _06.Exercises_Matrices
//{
//    class Program
//    {
//        static bool isInside(int shootX, int shootY, int targetX, int targetY, int radius)
//        {
//            var distance = Math.Sqrt((Math.Pow(shootX - targetX, 2) + Math.Pow(shootY - targetY, 2)));
//            if (distance <= radius)
//            {
//                return true;
//            }
//            return false;

//        }

//        static void Main(string[] args)
//        {
//            var matrixSize = Regex.Split(Console.ReadLine().Trim(), "\\s+").Select(int.Parse).ToArray();
//            var rows = matrixSize[0];
//            var cols = matrixSize[1];
//            var snake = Console.ReadLine();
//            var matrix = new char[rows][];

//            var counter = 0;
//            bool fromRight = true;
//            for (int r = rows - 1; r >= 0; r--)
//            {
//                matrix[r] = new char[cols];

//                if (fromRight)
//                {
//                    for (int c = cols - 1; c >= 0; c--)
//                    {
//                        matrix[r][c] = snake[counter % snake.Length];
//                        counter++;
//                    }
//                    fromRight = false;
//                }
//                else
//                {
//                    for (int c = 0; c < cols; c++)
//                    {
//                        matrix[r][c] = snake[counter % snake.Length];
//                        counter++;
//                    }
//                    fromRight = true;
//                }
//            }
//            var shoot = Regex.Split(Console.ReadLine().Trim(), "\\s+").Select(int.Parse).ToArray();
//            var shootX = shoot[0];
//            var shootY = shoot[1];
//            var shootRadius = shoot[2];

//            for (int r = 0; r < rows; r++)
//            {
//                for (int c = 0; c < cols; c++)
//                {
//                    if (isInside(r, c, shootX, shootY, shootRadius))
//                    {
//                        matrix[r][c] = ' ';
//                    }
//                }
//            }

//            bool proceed = false;
//            do
//            {
//                proceed = false;
//                for (int r = 0; r < rows - 1; r++)
//                {
//                    for (int c = 0; c < cols; c++)
//                    {
//                        if ((matrix[r][c] != ' ') && (matrix[r + 1][c] == ' '))
//                        {
//                            proceed = true;
//                            matrix[r + 1][c] = matrix[r][c];
//                            matrix[r][c] = ' ';
//                        }
//                    }
//                }
//            } while (proceed);


//            for (int r = 0; r < rows; r++)
//            {
//                Console.WriteLine(string.Join("", matrix[r]));
//            }
//        }
//    }
//}
