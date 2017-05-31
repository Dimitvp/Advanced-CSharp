using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _06.Exercises_Matrices
{
    class Program
    {
        static void Main(string[] args)
        {
            var matrixSize = Regex.Split(Console.ReadLine().Trim(), "\\s+").Select(int.Parse).ToArray();
            var rows = matrixSize[0];
            var cols = matrixSize[1];
            var shuffles = int.Parse(Console.ReadLine());
            var matrix = new int[rows][];

            var counter = 1;
            for (int r = 0; r < rows; r++)
            {
                matrix[r] = new int[cols];
                for (int c = 0; c < cols; c++)
                {
                    matrix[r][c] = counter++;
                }
            }

            for (int i = 0; i < shuffles; i++)
            {
                var commandData = Regex.Split(Console.ReadLine().Trim(), "\\s+").ToArray();
                var target = int.Parse(commandData[0]);
                var command = commandData[1];
                var shifts = int.Parse(commandData[2]);
                var buffer = 9999999;


                if (command == "down")
                {
                    shifts = shifts % rows;
                    // shiffle down
                    for (int j = 0; j < shifts; j++)
                    {
                        for (int r = 0; r < rows; r++)
                        {
                            var cur = matrix[r][target];
                            matrix[r][target] = buffer;
                            buffer = cur;
                        }
                        matrix[0][target] = buffer;
                    }


                }

                if (command == "up")
                {
                    shifts = shifts % rows;
                    // shiffle up
                    for (int j = 0; j < shifts; j++)
                    {
                        buffer = matrix[0][target];
                        for (int r = 0; r < rows - 1; r++)
                        {
                            matrix[r][target] = matrix[r + 1][target];
                        }
                        matrix[matrix.Length - 1][target] = buffer;
                    }

                }

                if (command == "left")
                {
                    shifts = shifts % cols;
                    // shiffle left

                    for (int j = 0; j < shifts; j++)
                    {
                        buffer = matrix[target][0];
                        for (int c = 0; c < cols - 1; c++)
                        {
                            matrix[target][c] = matrix[target][c + 1];
                        }
                        matrix[target][matrix[target].Length - 1] = buffer;
                    }
                }

                if (command == "right")
                {
                    shifts = shifts % cols;
                    // shiffle right
                    for (int j = 0; j < shifts; j++)
                    {
                        buffer = matrix[target][0];
                        for (int c = 1; c < cols; c++)
                        {
                            var curr = matrix[target][c];
                            matrix[target][c] = buffer;
                            buffer = curr;
                        }
                        matrix[target][0] = buffer;
                    }
                }
            }

            counter = 1;
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    if (matrix[r][c] != counter)
                    {

                        for (int rr = 0; rr < rows; rr++)
                        {
                            for (int cc = 0; cc < cols; cc++)
                            {
                                if (matrix[rr][cc] == counter)
                                {
                                    var wrong = matrix[r][c];
                                    var correct = matrix[rr][cc];
                                    matrix[r][c] = correct;
                                    matrix[rr][cc] = wrong;
                                    Console.WriteLine($"Swap ({r}, {c}) with ({rr}, {cc})");

                                }
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("No swap required");
                    }
                    counter++;
                }
            }
        }
    }
}
