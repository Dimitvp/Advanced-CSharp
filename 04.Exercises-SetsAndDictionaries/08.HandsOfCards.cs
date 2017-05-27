//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace Hands_of_cards
//{
//    class Program
//    {
//        static void Main()
//        {


//            string[] input = Console.ReadLine().Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
//            Dictionary<string, HashSet<string>> playerPoint = new Dictionary<string, HashSet<string>>();

//            while (input[0] != "JOKER")
//            {
//                string name = input[0];
//                HashSet<string> cards = new HashSet<string>(input[1].Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray());

//                if (!playerPoint.Keys.Contains(input[0]))
//                {
//                    playerPoint[input[0]] = cards;
//                }
//                else
//                {
//                    playerPoint[input[0]].UnionWith(cards);
//                }

//                input = Console.ReadLine().Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
//            }

//            foreach (var item in playerPoint)
//            {
//                Console.WriteLine($"{item.Key}: {ShowPoints(item.Value)}");
//            }


//        }

//        private static int ShowPoints(HashSet<string> value)
//        {
//            int sum = 0;

//            foreach (var item in value)
//            {
//                string power = item.Substring(0, item.Length - 1);
//                int cardPower = 0;
//                string type = item[item.Length - 1].ToString();
//                int cardType = 0;


//                switch (power)
//                {
//                    case "2":
//                        cardPower = 2;
//                        break;
//                    case "3":
//                        cardPower = 3;
//                        break;
//                    case "4":
//                        cardPower = 4;
//                        break;
//                    case "5":
//                        cardPower = 5;
//                        break;
//                    case "6":
//                        cardPower = 6;
//                        break;
//                    case "7":
//                        cardPower = 7;
//                        break;
//                    case "8":
//                        cardPower = 8;
//                        break;
//                    case "9":
//                        cardPower = 9;
//                        break;
//                    case "10":
//                        cardPower = 10;
//                        break;
//                    case "J":
//                        cardPower = 11;
//                        break;
//                    case "Q":
//                        cardPower = 12;
//                        break;
//                    case "K":
//                        cardPower = 13;
//                        break;
//                    case "A":
//                        cardPower = 14;
//                        break;
//                    default:
//                        break;
//                }

//                switch (type)
//                {
//                    case "S":
//                        cardType = 4;
//                        break;
//                    case "H":
//                        cardType = 3;
//                        break;
//                    case "D":
//                        cardType = 2;
//                        break;
//                    case "C":
//                        cardType = 1;
//                        break;
//                    default:
//                        break;
//                }
//                sum += cardType * cardPower;
//            }

//            return sum;
//        }
//    }
//}