//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace _05.HotPotato
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            string input = Console.ReadLine();
//            int steps = int.Parse(Console.ReadLine());
//            List<string> splitInput = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
//            Queue<string> kids = new Queue<string>(splitInput);
//            while (kids.Count != 1)
//            {
//                for (int i = 1; i < steps; i++)
//                {
//                    kids.Enqueue(kids.Dequeue());
//                }
//                Console.WriteLine($"Removed {kids.Dequeue()}");
//            }
//            Console.WriteLine($"Last is {kids.Peek()}");
//        }
//    }
//}