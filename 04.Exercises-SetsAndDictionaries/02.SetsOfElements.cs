//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Sets_of_Elements
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int[] input = Console.ReadLine().Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

//            HashSet<int>[] sets = new HashSet<int>[2];
//            for (int i = 0; i < sets.Length; i++)
//            {
//                sets[i] = new HashSet<int>();
//            }

//            for (int i = 0; i < input[0]; i++)
//            {
//                sets[0].Add(int.Parse(Console.ReadLine()));
//            }

//            for (int i = 0; i < input[1]; i++)
//            {
//                sets[1].Add(int.Parse(Console.ReadLine()));
//            }

//            var both = sets[0].Intersect(sets[1]);

//            Console.WriteLine(string.Join(" ", both));
//        }
//    }
//}