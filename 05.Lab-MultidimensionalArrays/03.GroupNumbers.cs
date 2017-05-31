//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Runtime.InteropServices;
//using System.Text;
//using System.Text.RegularExpressions;
//using System.Threading;
//using System.Threading.Tasks;

//namespace _05.Lab_MultidimensionalArrays
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            var data = Regex.Split(Console.ReadLine(), ", ").Select(int.Parse).ToArray();
//            var register = new Dictionary<string, Queue<int>>();


//            for (int i = 0; i < 3; i++)
//            {
//                register[i.ToString()] = new Queue<int>();
//            }
//            foreach (var item in data)
//            {
//                var result = item % 3;
//                if (result == 0)
//                {
//                    register["0"].Enqueue(item);
//                }
//                if (result == 1 || result == -1)
//                {
//                    register["1"].Enqueue(item);
//                }
//                if (result == 2 || result == -2)
//                {
//                    register["2"].Enqueue(item);
//                }
//            }

//            foreach (var dividor in register.Where(x => x.Value.Count > 0))
//            {
//                Console.WriteLine(string.Join(" ", register[dividor.Key]));
//            }



//        }
//    }
//}
