//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace _06.TruckTour
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            // Gets input
//            var pumpStations = long.Parse(Console.ReadLine());
//            var path = new Queue<List<int>>();

//            // Populate the pumps over the path
//            PopulatePumps(pumpStations, path);

//            // first round-trip pump index
//            FindFirstRoundTripPump(path);
//        }

//        private static void FindFirstRoundTripPump(Queue<List<int>> path)
//        {
//            var pump = 0;
//            for (int i = 0; i < path.Count; i++)
//            {

//                // can it even start ?
//                if (path.Peek()[0] - path.Peek()[1] < 0)
//                {
//                    path.Enqueue(path.Dequeue());
//                    pump++;
//                    continue;
//                }

//                // mirroring the path
//                var currentPath = new Queue<List<int>>(path);
//                var fuel = 0;

//                // proceed further
//                for (int j = 0; j < path.Count; j++)
//                {
//                    fuel += currentPath.Peek()[0] - currentPath.Peek()[1];
//                    if (fuel < 0)
//                    {
//                        path.Enqueue(path.Dequeue());
//                        pump++;
//                        break;
//                    }
//                    currentPath.Enqueue(currentPath.Dequeue());
//                }

//                // enough fuel to complete the round trip
//                if (fuel >= 0)
//                {
//                    Console.WriteLine(pump);
//                    return;
//                }
//            }
//        }

//        private static void PopulatePumps(long pumpStations, Queue<List<int>> path)
//        {
//            for (int i = 0; i < pumpStations; i++)
//            {
//                var input = Console.ReadLine();
//                List<int> pumpData = input
//                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
//                    .Select(int.Parse)
//                    .ToList();

//                path.Enqueue(pumpData);
//            }
//        }
//    }
//}