//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace Periodic_Table
//{
//    class Program
//    {
//        static void Main()
//        {
//            int inputSize = int.Parse(Console.ReadLine());


//            SortedSet<string> set = new SortedSet<string>();

//            for (int i = 0; i < inputSize; i++)
//            {
//                string[] input = Console.ReadLine().Split();

//                foreach (var item in input)
//                {
//                    set.Add(item);
//                }
//            }

//            Console.WriteLine(string.Join(" ", set));

//        }
//    }
//}