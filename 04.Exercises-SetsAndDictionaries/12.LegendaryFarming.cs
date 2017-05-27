//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace Logs_Aggregator
//{
//    class Program
//    {
//        static void Main()
//        {

//            string[] loot;// = Console.ReadLine().ToLower().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
//            Dictionary<string, int> materials = new Dictionary<string, int>();
//            materials["shards"] = 0;
//            materials["fragments"] = 0;
//            materials["motes"] = 0;
//            Dictionary<string, int> junk = new Dictionary<string, int>();

//            do
//            {
//                loot = Console.ReadLine().ToLower().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
//                for (int item = 0; item < loot.Length; item += 2)
//                {
//                    string material = loot[item + 1];
//                    int quantity = int.Parse(loot[item]);
//                    //6 leathers 255 fragments 7 Shards
//                    switch (material)
//                    {
//                        case "shards":
//                            materials["shards"] += quantity;
//                            break;
//                        case "fragments":
//                            materials["fragments"] += quantity;
//                            break;
//                        case "motes":
//                            materials["motes"] += quantity;
//                            break;
//                        default:
//                            if (!junk.ContainsKey(material))
//                            {
//                                junk[material] = quantity;
//                            }
//                            else
//                            {
//                                junk[material] += quantity;
//                            }
//                            break;
//                    }
//                    if (materials.Values.Max() >= 250)
//                    {
//                        var keyOflegendary = materials.FirstOrDefault(x => x.Value == materials.Values.Max()).Key;
//                        string legendaryItem = "";
//                        switch (keyOflegendary)
//                        {
//                            case "shards":
//                                legendaryItem = "Shadowmourne";
//                                break;
//                            case "fragments":
//                                legendaryItem = "Valanyr";
//                                break;
//                            case "motes":
//                                legendaryItem = "Dragonwrath";
//                                break;
//                            default:
//                                break;
//                        }

//                        Console.WriteLine($"{legendaryItem} obtained!");
//                        materials[keyOflegendary] -= 250;
//                        foreach (var itemLegendary in materials.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
//                        {
//                            Console.WriteLine($"{itemLegendary.Key}: {itemLegendary.Value}");
//                        }

//                        foreach (var itemJunk in junk.OrderBy(x => x.Key))
//                        {
//                            Console.WriteLine($"{itemJunk.Key}: {itemJunk.Value}");
//                        }

//                        return;
//                    }

//                }



//            } while (materials.Values.Count > 0 && materials.Values.Max() <= 250);
//        }
//    }
//}