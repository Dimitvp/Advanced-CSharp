//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace _03.MaximumElement
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int inputSize = int.Parse(Console.ReadLine());
//            Stack<long> result = new Stack<long>();
//            Stack<long> biggest = new Stack<long>(new long[] { Int64.MinValue });

//            for (int i = 0; i < inputSize; i++)
//            {
//                string input = Console.ReadLine();
//                List<long> splitInput = input
//                    .Trim()
//                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
//                    .Select(long.Parse)
//                    .ToList();

//                if (splitInput[0] == 1)
//                {
//                    if (splitInput[1] >= biggest.Peek())
//                    {
//                        biggest.Push(splitInput[1]);
//                    }
//                    result.Push(splitInput[1]);
//                }
//                else if (splitInput[0] == 2)
//                {
//                    if (result.Peek() == biggest.Peek())
//                    {
//                        biggest.Pop();
//                    }
//                    result.Pop();

//                }
//                else if (splitInput[0] == 3)
//                {
//                    Console.WriteLine(biggest.Peek());
//                }
//            }
//        }
//    }
//}