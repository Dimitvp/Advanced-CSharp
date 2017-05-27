//using System;
//using System.Collections.Generic;
//using System.Globalization;
//using System.Linq;
//using System.Text;
//using System.Text.RegularExpressions;
//using System.Threading.Tasks;

//namespace _01.ReverseStrings
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {

//            string input = Console.ReadLine();
//            List<double> splitInput = input
//                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
//                .Select(double.Parse)
//                .ToList();

//            var valuesCounter = new SortedDictionary<double, int>();

//            foreach (var digit in splitInput)
//            {
//                if (!valuesCounter.ContainsKey(digit))
//                {
//                    valuesCounter[digit] = 0;
//                }
//                valuesCounter[digit]++;
//            }

//            NumberFormatInfo nfi = new NumberFormatInfo();
//            nfi.NumberDecimalSeparator = ",";
//            foreach (var entry in valuesCounter)
//            {
//                Console.WriteLine($"{entry.Key.ToString(nfi)} - {entry.Value} times");
//            }
//        }
//    }
//}