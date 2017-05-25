//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace _02._10.SimpleTextEditor
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            var operationsCount = int.Parse(Console.ReadLine());

//            var commandsBuffer = new Stack<string>();
//            for (int i = 0; i < operationsCount; i++)
//            {
//                var input = Console.ReadLine();

//                List<string> splitInput = input
//                    .Trim()
//                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
//                    .ToList();

//                int commandName = 0;
//                string commandParam = "";

//                //add          1 string 
//                //remove last  2 count
//                //print index  3 index
//                //undo         4
//                if (splitInput.Count == 2)
//                {
//                    commandName = int.Parse(splitInput[0]);
//                    commandParam = splitInput[1];
//                }
//                if (splitInput.Count == 1)
//                {
//                    commandName = int.Parse(splitInput[0]);
//                }

//                switch (commandName)
//                {
//                    case 1:
//                        if (commandsBuffer.Count >= 1)
//                        {
//                            var text = commandsBuffer.Peek();
//                            text += commandParam;
//                            commandsBuffer.Push(text);
//                        }
//                        else
//                        {
//                            commandsBuffer.Push(commandParam);
//                        }
//                        break;
//                    case 2:
//                        if (commandsBuffer.Count >= 1)
//                        {
//                            var text = commandsBuffer.Peek();
//                            int cut = int.Parse(commandParam);
//                            if (text.Length >= cut)
//                            {
//                                text = text.Substring(0,text.Length - cut);
//                            }
//                            else
//                            {
//                                text = "";
//                            }
//                            commandsBuffer.Push(text);
//                        }
//                        break;
//                    case 3:
//                        if (commandsBuffer.Count >= 1)
//                        {
//                            var text = commandsBuffer.Peek();
//                            int index = int.Parse(commandParam);
//                            if (index >= 1 && index <= text.Length)
//                            {
//                                Console.WriteLine(text[index - 1]);
//                            }
//                        }
//                        break;
//                    case 4:
//                        if (commandsBuffer.Count >= 1)
//                        {
//                            commandsBuffer.Pop();
//                        }
//                        break;

//                }
//                //if (commandsBuffer.Count >= 1)
//                //    Console.WriteLine(commandsBuffer.Peek());

//            }
//        }
//    }
//}