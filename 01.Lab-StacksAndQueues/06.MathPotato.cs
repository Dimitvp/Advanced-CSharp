//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace _06.MathPotato
//{
//    class Program
//    {

//        static void Main(string[] args)
//        {
//            string input = Console.ReadLine();
//            int steps = int.Parse(Console.ReadLine());
//            List<string> splitInput = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
//            Queue<string> kids = new Queue<string>(splitInput);

//            int loopCount = 0;
//            while (kids.Count != 1)
//            {
//                ++loopCount;
//                if (!isPrime(loopCount))
//                {
//                    for (int i = 1; i < steps; i++)
//                    {
//                        kids.Enqueue(kids.Dequeue());
//                    }
//                    Console.WriteLine($"Removed {kids.Dequeue()}");
//                }
//                else
//                {
//                    for (int i = 1; i < steps; i++)
//                    {
//                        kids.Enqueue(kids.Dequeue());
//                    }
//                    Console.WriteLine($"Prime {kids.Peek()}");
//                }


//            }
//            Console.WriteLine($"Last is {kids.Peek()}");


//        }
//        private static bool isPrime(int number)
//        {

//            if (number == 1) return false;
//            if (number == 2) return true;

//            for (int i = 2; i <= Math.Ceiling(Math.Sqrt(number)); ++i)
//            {
//                if (number % i == 0) return false;
//            }

//            return true;

//        }

//    }
//}