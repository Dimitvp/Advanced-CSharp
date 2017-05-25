//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace _04.MatchingBrackets
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            string input = Console.ReadLine();
//            Stack<int> indexStack = new Stack<int>();

//            for (int i = 0; i < input.Length; i++)
//            {
//                if (input[i] == '(')
//                {
//                    indexStack.Push(i);
//                }

//                if (input[i] == ')')
//                {
//                    for (int j = indexStack.Peek(); j <= i; j++)
//                    {
//                        Console.Write(input[j]);
//                    }
//                    Console.WriteLine();
//                    indexStack.Pop();
//                }

//            }

//        }
//    }
//}