//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace User_logs
//{
//    class Program
//    {
//        static void Main()
//        {
//            string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
//            Dictionary<string, Dictionary<string, int>> userLog = new Dictionary<string, Dictionary<string, int>>();

//            while (input[0] != "end")
//            {
//                // IP=192.23.30.40 message='Hello&derps.' user=destroyer
//                string ip = input[0].Substring(3, input[0].Length - 3);
//                string user = input[2].Substring(5, input[2].Length - 5);

//                if (!userLog.Keys.Contains(user))
//                {
//                    userLog[user] = new Dictionary<string, int>();
//                    Dictionary<string, int> buffer = new Dictionary<string, int>();
//                    buffer[ip] = 0;
//                    userLog[user] = buffer;
//                }
//                else
//                {
//                    if (!userLog[user].Keys.Contains(ip))
//                    {
//                        userLog[user][ip] = 0;
//                    }

//                }
//                userLog[user][ip]++;
//                input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
//            }

//            if (userLog.Count > 0)
//            {
//                foreach (var user in userLog.OrderBy(x => x.Key))
//                {
//                    Console.WriteLine($"{user.Key}:{Environment.NewLine}{string.Join(", ", user.Value.Select(y => string.Format("{0} => {1}", y.Key, y.Value)))}.");

//                }
//            }

//        }
//    }
//}