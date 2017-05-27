//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text.RegularExpressions;

//namespace Dragon_Army

//{
//    class Program
//    {
//        static void Main()
//        {
//            int n = int.Parse(Console.ReadLine());
//            Dictionary<string, SortedDictionary<string, List<int>>> dragons = new Dictionary<string, SortedDictionary<string, List<int>>>();

//            for (int i = 0; i < n; i++)
//            {
//                string[] input = Console.ReadLine().Split(new char[] { ' ' }).ToArray();

//                //Red Bazgargal 45 250 25
//                string type = input[0];
//                string name = input[1];
//                int damage = 45; //input[2]
//                int health = 250; //input[3]
//                int armor = 10; //input[4]

//                if (input[2] != "null")
//                {
//                    damage = int.Parse(input[2]);
//                }

//                if (input[3] != "null")
//                {
//                    health = int.Parse(input[3]);
//                }

//                if (input[4] != "null")
//                {
//                    armor = int.Parse(input[4]);
//                }

//                if (!dragons.ContainsKey(type))
//                {
//                    SortedDictionary<string, List<int>> dragonEntry = new SortedDictionary<string, List<int>>();
//                    List<int> dragonStats = new List<int>();

//                    dragonStats.Add(damage);
//                    dragonStats.Add(health);
//                    dragonStats.Add(armor);

//                    dragonEntry[name] = dragonStats;

//                    dragons[type] = dragonEntry;
//                }
//                else if (!dragons[type].ContainsKey(name))
//                {
//                    List<int> dragonStats = new List<int>();

//                    dragonStats.Add(damage);
//                    dragonStats.Add(health);
//                    dragonStats.Add(armor);

//                    dragons[type][name] = dragonStats;
//                }
//                else
//                {
//                    List<int> dragonStats = new List<int>();
//                    dragonStats.Add(damage);
//                    dragonStats.Add(health);
//                    dragonStats.Add(armor);

//                    dragons[type][name].Clear();
//                    dragons[type][name] = dragonStats;
//                }
//            }

//            foreach (var item in dragons)
//            {
//                double damageAverage = 0;
//                foreach (var drag in item.Value)
//                {
//                    damageAverage += drag.Value[0];
//                }
//                damageAverage /= item.Value.Count();

//                double healthAverage = 0;
//                foreach (var drag in item.Value)
//                {
//                    healthAverage += drag.Value[1];
//                }
//                healthAverage /= item.Value.Count();

//                double armorAverage = 0;
//                foreach (var drag in item.Value)
//                {
//                    armorAverage += drag.Value[2];
//                }
//                armorAverage /= item.Value.Count();

//                Console.WriteLine($"{item.Key}::({damageAverage:F2}/{healthAverage:F2}/{armorAverage:F2})");
//                foreach (var drag in item.Value)
//                {
//                    Console.WriteLine($"-{drag.Key} -> damage: {drag.Value[0]}, health: {drag.Value[1]}, armor: {drag.Value[2]}");
//                }
//            }
//        }
//    }
//}