//using System;
//using System.Collections.Generic;
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
//            var parking = new SortedSet<string>();

//            while (input != "END")
//            {
//                var splitInput = Regex.Split(input, ", ").ToArray();
//                var opperation = splitInput[0];
//                var plateNumber = splitInput[1];
//                if (opperation == "IN")
//                {
//                    parking.Add(plateNumber);
//                }
//                else
//                {
//                    parking.Remove(plateNumber);
//                }
//                input = Console.ReadLine();
//            }


//            if (parking.Count != 0)
//            {
//                foreach (var car in parking)
//                {
//                    Console.WriteLine(car);
//                }
//            }
//            else
//            {
//                Console.WriteLine("Parking Lot is Empty");
//            }


//        }
//    }
//}