//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace _04.BasicQueueOperations
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            string input = Console.ReadLine();
//            List<string> splitInput = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
//            var n = int.Parse(splitInput[0]);
//            var s = int.Parse(splitInput[1]);
//            var x = splitInput[2];

//            string elementsInput = Console.ReadLine();
//            List<string> elements = elementsInput.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

//            Queue<string> result = new Queue<string>(elements.Take(n));
//            for (int i = 0; i < s; i++)
//            {
//                result.Dequeue();
//            }

//            if (result.Contains(x))
//            {
//                Console.WriteLine(result.Contains(x).ToString().ToLower());
//            }
//            else
//            {
//                if (result.Count == 0)
//                {
//                    Console.WriteLine(0);
//                    return;
//                }
//                var smallest = Int64.MaxValue;
//                while (result.Count > 0)
//                {
//                    if (int.Parse(result.Peek()) < smallest)
//                    {
//                        smallest = int.Parse(result.Peek());
//                    }
//                    result.Dequeue();
//                }
//                Console.WriteLine(smallest);

//            }

//        }
//    }

//}