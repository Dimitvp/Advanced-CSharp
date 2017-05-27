//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace Periodic_Table
//{
//    class Program
//    {
//        static void Main()
//        {
//            string[] input = Console.ReadLine().Trim().Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
//            Dictionary<string, string> phoneBook = new Dictionary<string, string>();
//            do
//            {
//                if (input[0] == "stop")
//                {
//                    break;
//                }

//                if (input[0] != "search")
//                {
//                    phoneBook[input[0]] = input[1];
//                    input = Console.ReadLine().Trim().Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
//                }
//                else
//                {

//                    string name = Console.ReadLine();
//                    if (name != "stop")
//                    {

//                        if (phoneBook.ContainsKey(name))
//                        {
//                            Console.WriteLine($"{name} -> {phoneBook[name]}");
//                        }
//                        else
//                        {
//                            Console.WriteLine($"Contact {name} does not exist.");
//                        }
//                    }
//                    else
//                    {
//                        break;
//                    }
//                }
//            } while (input[0] != "stop");



//        }
//    }
//}