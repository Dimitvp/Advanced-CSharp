//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace _01.ReverseStrings
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            string input = Console.ReadLine();
//            var partiPool = new SortedSet<string>();

//            while (input!= "PARTY")
//            {
//                partiPool.Add(input);
//                input = Console.ReadLine();
//            }

//            while (input != "END")
//            {
//                partiPool.Remove(input);
//                input = Console.ReadLine();
//            }
//            Console.WriteLine(partiPool.Count);
//            foreach (var missingPerson in partiPool)
//            {
//                Console.WriteLine(missingPerson);
//            }
//        }
//    }
//}