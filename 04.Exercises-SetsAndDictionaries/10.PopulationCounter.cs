//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace Population_Counter
//{
//    class Program
//    {
//        static void Main()
//        {
//            string[] input = Console.ReadLine().Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
//            Dictionary<string, Dictionary<string, long>> countries = new Dictionary<string, Dictionary<string, long>>();
//            Dictionary<string, long> countriesPopulation = new Dictionary<string, long>();

//            while (input[0] != "report")
//            {
//                //Sofia|Bulgaria|1
//                string country = input[1];
//                string city = input[0];
//                long population = long.Parse(input[2]);

//                if (!countries.ContainsKey(country))
//                {

//                    Dictionary<string, long> cityPopulation = new Dictionary<string, long>();

//                    cityPopulation[city] = population;
//                    countries[country] = cityPopulation;

//                    if (!countriesPopulation.ContainsKey(country))
//                    {
//                        countriesPopulation[country] = population;
//                    }
//                    else
//                    {
//                        countriesPopulation[country] += population;
//                    }
//                }
//                else
//                {


//                    if (!countries[country].ContainsKey(city))
//                    {

//                        countries[country][city] = population;
//                    }
//                    else
//                    {
//                        countries[country][city] += population;
//                    }

//                    if (!countriesPopulation.ContainsKey(country))
//                    {
//                        countriesPopulation[country] = population;
//                    }
//                    else
//                    {
//                        countriesPopulation[country] += population;
//                    }

//                }
//                input = Console.ReadLine().Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
//            }

//            foreach (var country in countriesPopulation.OrderByDescending(population => population.Value))
//            {
//                Console.WriteLine($"{country.Key} (total population: {country.Value})");

//                foreach (var city in countries[country.Key].OrderByDescending(population => population.Value))
//                {
//                    Console.WriteLine($"=>{city.Key}: {city.Value}");
//                }
//            }

//        }
//    }
//}