//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace _02.SimpleCalculator
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            string input = Console.ReadLine();
//            Stack<string> splitInput = new Stack<string>(input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Reverse().ToArray());

//            while (splitInput.Count != 1)
//            {
//                Operate(splitInput);
//            }
//            Console.WriteLine(splitInput.Peek());


//        }

//        private static void Operate(Stack<string> splitInput)
//        {
//            var a = double.Parse(splitInput.Pop());
//            var oper = splitInput.Pop();
//            var b = double.Parse(splitInput.Pop());

//            splitInput.Push(oper == "+" ? (a + b).ToString() : (a - b).ToString());
//            //Console.WriteLine($"{a}{oper}{b}");
//        }
//    }
//}