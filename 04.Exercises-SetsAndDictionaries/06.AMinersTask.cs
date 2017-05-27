//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace A_miner_task
//{
//    class Program
//    {
//        static void Main()
//        {
//            string input = Console.ReadLine();
//            Dictionary<string, long> resourcesPool = new Dictionary<string, long>();

//            while (input != "stop")
//            {
//                if (!resourcesPool.Keys.Contains(input))
//                {
//                    resourcesPool[input] = 0;
//                }
//                resourcesPool[input] += long.Parse(Console.ReadLine());
//                input = Console.ReadLine();
//            }

//            foreach (var item in resourcesPool)
//            {
//                Console.WriteLine($"{item.Key} -> {item.Value}");
//            }

//        }
//    }
//}