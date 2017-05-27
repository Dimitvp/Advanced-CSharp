using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ReverseStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            var classSize = int.Parse(Console.ReadLine());
            var classMarks = new SortedDictionary<string, double>();
            for (int i = 0; i < classSize; i++)
            {
                string name = Console.ReadLine();
                string gradesData = Console.ReadLine();
                var avgGrades = gradesData
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(double.Parse)
                    .ToList()
                    .Average();

                if (!classMarks.ContainsKey(name))
                {
                    classMarks[name] = 0;
                }
                classMarks[name] += avgGrades;
            }

            foreach (var student in classMarks)
            {
                Console.WriteLine($"{student.Key} is graduated with {student.Value}");
            }

        }
    }
}