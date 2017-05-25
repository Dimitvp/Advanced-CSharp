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
//            List<string> splitInput = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Reverse().ToList();
//            Console.WriteLine(string.Join(" ", splitInput.Select(Reverse)));
//        }

//        private static string Reverse(string s)
//        {
//            char[] charArray = s.ToCharArray();
//            Array.Reverse(charArray);
//            return new string(charArray);
//        }
//    }
//}