//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Numerics;
//using System.Text;
//using System.Threading.Tasks;

//namespace _02._09.StackFibonacci
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int fibonacciNumber = int.Parse(Console.ReadLine());

//            Stack<BigInteger> stackFibonacci = new Stack<BigInteger>(new BigInteger[] { 1, 1 });

//            for (int i = 2; i < fibonacciNumber; i++)
//            {
//                var prev = stackFibonacci.Pop();
//                var prePrev = stackFibonacci.Pop();
//                stackFibonacci.Push(prePrev);
//                stackFibonacci.Push(prev);
//                stackFibonacci.Push(prev + prePrev);
//            }
//            Console.WriteLine(stackFibonacci.Peek());
//        }
//    }
//}