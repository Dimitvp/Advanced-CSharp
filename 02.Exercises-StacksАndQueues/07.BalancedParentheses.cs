//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace _02._07.BalancedParentheses
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            string input = Console.ReadLine();
//            var verificationStack = new Stack<char>();

//            foreach (char ch in input)
//            {
//                if (verificationStack.Count == 0)
//                {
//                    verificationStack.Push(ch);
//                    continue;
//                }

//                if (ch == '}' || ch == ']' || ch == ')')
//                {
//                    var previousSign = verificationStack.Peek();
//                    if (previousSign == '{' && ch == '}')
//                    {
//                        verificationStack.Pop();
//                    }
//                    if (previousSign == '[' && ch == ']')
//                    {
//                        verificationStack.Pop();
//                    }
//                    if (previousSign == '(' && ch == ')')
//                    {
//                        verificationStack.Pop();
//                    }
//                }
//                else
//                {
//                    verificationStack.Push(ch);
//                }

//            }

//            if (verificationStack.Count == 0)
//            {
//                Console.WriteLine("YES");
//            }
//            else
//            {
//                Console.WriteLine("NO");
//            }
//        }
//    }
//}