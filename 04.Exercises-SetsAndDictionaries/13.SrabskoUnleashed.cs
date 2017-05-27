//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text.RegularExpressions;

//namespace Srabsko_Unleashed

//{
//    class Program
//    {
//        static void Main()
//        {
//            string regex = @"^(\D+)( @)(\D*) (\d*) (\d*$)";
//            string input = Console.ReadLine();
//            Dictionary<string, Dictionary<string, long>> events = new Dictionary<string, Dictionary<string, long>>();
//            while (input != "End")
//            {
//                MatchCollection matches = Regex.Matches(input, regex);
//                if (matches.Count > 0)
//                {
//                    // matches regex
//                    string singer;
//                    string venue;
//                    int ticketsPrice;
//                    int ticketsCount;
//                    foreach (Match match in matches)
//                    {
//                        singer = match.Groups[1].Value;
//                        string[] testSinger = singer.Split(new char[] { ' ' }).ToArray();
//                        venue = match.Groups[3].Value;
//                        string[] testVenue = venue.Split(new char[] { ' ' }).ToArray();
//                        ticketsPrice = int.Parse(match.Groups[4].Value);
//                        ticketsCount = int.Parse(match.Groups[5].Value);
//                        long eventRevenue = ticketsPrice * ticketsCount;
//                        if (testSinger.Length > 3 || testVenue.Length > 3)
//                        {
//                            continue;
//                        }

//                        if (!events.ContainsKey(venue))
//                        {
//                            Dictionary<string, long> entry = new Dictionary<string, long>();
//                            entry[singer] = eventRevenue;
//                            events[venue] = entry;
//                        }
//                        else
//                        {
//                            if (!events[venue].ContainsKey(singer))
//                            {
//                                events[venue][singer] = eventRevenue;
//                            }
//                            else
//                            {
//                                events[venue][singer] += eventRevenue;
//                            }
//                        }

//                    }
//                    input = Console.ReadLine();
//                }
//                else
//                {
//                    // doesn't matches regex
//                    input = Console.ReadLine();
//                    continue;
//                }
//            }

//            foreach (var place in events)
//            {
//                Console.WriteLine($"{place.Key}");
//                foreach (var performer in place.Value.OrderByDescending(visitors => visitors.Value))
//                {
//                    Console.WriteLine($"#  {performer.Key} -> {performer.Value}");
//                }
//            }
//        }
//    }
//}