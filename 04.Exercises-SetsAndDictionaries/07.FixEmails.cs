//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace Fix_emails
//{
//    class Program
//    {
//        static void Main()
//        {
//            string input = Console.ReadLine();
//            Dictionary<string, string> emails = new Dictionary<string, string>();

//            while (input != "stop")
//            {
//                string email = Console.ReadLine();
//                if (email.Substring(email.Length - 2, 2).ToLower() == "us" || email.Substring(email.Length - 2, 2).ToLower() == "uk")
//                {
//                    input = Console.ReadLine();
//                    continue;
//                }
//                if (!emails.Keys.Contains(input))
//                {
//                    emails[input] = email;
//                }
//                input = Console.ReadLine();
//            }

//            foreach (var item in emails)
//            {
//                Console.WriteLine($"{item.Key} -> {item.Value}");
//            }

//        }
//    }
//}
