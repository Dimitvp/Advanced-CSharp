using System;
using System.Collections;
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
            var rows = int.Parse(Console.ReadLine());
            var lego = new List<int>[rows];

            for (int i = 0; i < rows; i++)
            {
                lego[i] = Regex.Split(Console.ReadLine().Trim(), "\\s+").Select(int.Parse).ToList();
            }

            for (int i = 0; i < rows; i++)
            {
                lego[i].AddRange(Regex.Split(Console.ReadLine().Trim(), "\\s+").Select(int.Parse).Reverse().ToList());
            }

            if (lego.Length > 0)
            {
                var counter = 0;
                var isLegoPerfect = true;
                var correctLength = lego[0].Count;
                for (int r = 0; r < rows; r++)
                {
                    counter += lego[r].Count;
                    if (lego[r].Count != correctLength)
                    {
                        isLegoPerfect = false;
                    }
                }

                if (isLegoPerfect)
                {
                    for (int r = 0; r < rows; r++)
                    {
                        Console.WriteLine($"[{string.Join(", ", lego[r])}]");
                    }
                }
                else
                {
                    Console.WriteLine($"The total number of cells is: {counter}");
                }
            }
            
        }
    }
}
