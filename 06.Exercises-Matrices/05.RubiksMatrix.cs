using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

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
                var buffer = 0;


                if (command == "down")
                {
                    shifts = shifts % rows;
                    
                    // shiffle down
                    for (int r = 0; r < rows-1; r++)
                    {
                        buffer = matrix[r+1][target];
                        matrix[r + 1][target] = matrix[r][target];
                    }
                    matrix[0][target] = buffer;

                }

                if (command == "up")
                {
                    shifts = shifts % rows;
                    // shiffle up
                }

                if (command == "left")
                {
                    // shiffle left
                }

                if (command == "right")
                {
                    // shiffle right
                }
            }




        }
    }
}
