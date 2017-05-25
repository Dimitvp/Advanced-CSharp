//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace _05.CalculateSequenceWithQueue
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            var firstDigit = long.Parse(Console.ReadLine());
//            var steps = 1;
//            var queue = new Queue<long>();

//            // S1 = N
//            // S2 = S1 + 1
//            // S3 = 2 * S1 + 1
//            // S4 = S1 + 2
//            // S5 = S2 + 1
//            // S6 = 2 * S2 + 1
//            // S7 = S2 + 2


//            queue.Enqueue(firstDigit);
//            Console.Write($"{firstDigit}");
//            while (steps <= 51)
//            {
//                long next = 0;
//                next = queue.Peek() + 1;
//                steps = PopulateAndPrint(steps, queue, next);
//                if (steps >= 50)
//                {
//                    return;
//                }

//                next = queue.Peek() * 2 + 1;
//                steps = PopulateAndPrint(steps, queue, next);
//                if (steps >= 50)
//                {
//                    return;
//                }

//                next = queue.Peek() + 2;
//                steps = PopulateAndPrint(steps, queue, next);
//                queue.Dequeue();
//                if (steps >= 50)
//                {
//                    return;
//                }
//            }
//        }

//        private static int PopulateAndPrint(int steps, Queue<long> queue, long next)
//        {
//            Console.Write($" {next}");
//            queue.Enqueue(next);
//            steps++;
//            return steps;
//        }
//    }
//}