//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace Logs_Aggregator
//{
//    class Program
//    {
//        static void Main()
//        {

//            Dictionary<string, Dictionary<string, int>> logs = new Dictionary<string, Dictionary<string, int>>();
//            int loops = int.Parse(Console.ReadLine());

//            for (int i = 0; i < loops; i++)
//            {
//                //•	10.10.17.33 alex 12
//                string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

//                string name = input[1];
//                string ip = input[0];
//                int duration = int.Parse(input[2]);
//                Dictionary<string, int> session = new Dictionary<string, int>();

//                if (!logs.ContainsKey(name))
//                {
//                    session[ip] = duration;
//                    logs[name] = session;
//                }
//                else
//                {
//                    if (!logs[name].ContainsKey(ip))
//                    {
//                        session[ip] = duration;
//                        logs[name][ip] = duration;
//                    }
//                    else
//                    {
//                        logs[name][ip] += duration;
//                    }
//                }
//            }

//            foreach (var name in logs.OrderBy(n => n.Key))
//            {
//                Console.WriteLine($"{name.Key}: {name.Value.Values.Sum()} [{string.Join(", ", name.Value.Keys.OrderBy(x => x))}]");
//            }
//        }
//    }
//}
