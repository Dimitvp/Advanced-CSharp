using System;
using System.Collections.Generic;
using System.Linq;

public class PoisonousPlants
{
    public static void Main()
    {

        // This is not my solution, my one gets 77/100
        var n = int.Parse(Console.ReadLine());
        var plants = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .Take(n)
            .ToArray();

        var days = new int[n];
        var indexes = new Stack<int>();
        indexes.Push(0);

        for (int i = 1; i < plants.Length; i++)
        {
            int maxDays = 0;

            while (indexes.Count > 0 && plants[indexes.Peek()] >= plants[i])
            {
                maxDays = Math.Max(maxDays, days[indexes.Pop()]);
            }

            if (indexes.Count > 0)
            {
                days[i] = maxDays + 1;
            }

            indexes.Push(i);
        }

        Console.WriteLine(days.Max());
    }
}

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Security.Permissions;
//using System.Text;
//using System.Threading.Tasks;

//namespace _01.ReverseStrings
//{
//    class Plant
//    {
//        public Plant(double pest, bool alive)
//        {
//            this.Pesticide = pest;
//            this.isAlive = alive;
//        }
//        public double Pesticide { get; set; }
//        public bool isAlive { get; set; }

//    }

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            var plantsCount = int.Parse(Console.ReadLine());

//            var input = Console.ReadLine();

//            List<double> plantsPest = input
//                .Trim()
//                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
//                .Select(double.Parse)
//                .ToList();

//            List<Plant> plants = new List<Plant>();
//            foreach (double pest in plantsPest)
//            {
//                plants.Add(new Plant(pest, true));
//            }

//            int days = 0;

//            if (plants.Count == 1)
//            {
//                Console.WriteLine(0);
//                return;
//            }

//            while (true)
//            {
//                //var beforeDay = plants.Count(x => x.isAlive);
//                bool isChanging = false;
//                for (int i = 1; i < plants.Count; i++)
//                {
//                    if (plants[i].Pesticide > plants[i - 1].Pesticide)
//                    {
//                        plants[i].isAlive = false;
//                        isChanging = true;
//                    }
//                }

//                //var afterDay = plants.Count(x => x.isAlive);
//                if (!isChanging)
//                {
//                    Console.WriteLine(days);
//                    return;
//                }
//                else
//                {
//                    days++;
//                    plants = plants.Where(x => x.isAlive).ToList();
//                }

//            }
//        }
//    }
//}