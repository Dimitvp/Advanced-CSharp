//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace Periodic_Table
//{
//    class Program
//    {
//        static void Main()
//        {
//            string input = Console.ReadLine();

//            SortedDictionary<char, int> counter = new SortedDictionary<char, int>();

//            foreach (char ch in input)
//            {
//                if (!counter.ContainsKey(ch))
//                {
//                    counter[ch] = 0;
//                }
//                counter[ch]++;
//            }

//            foreach (var item in counter)
//            {
//                Console.WriteLine($"{item.Key}: {item.Value} time/s");
//            }

//        }
//    }
//}