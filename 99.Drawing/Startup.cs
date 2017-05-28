using System;
using System.Runtime.CompilerServices;
using _99.Drawing;

namespace SuperSnake
{

    internal class Program
    {

        static void Main()
        {
            Game();
        }

        private static void Game()
        {
            var obj = new Protagonist();
            InitializeGame();
            NavigateProtagonist(obj);
        }

        private static void NavigateProtagonist(Protagonist obj)
        {
            ConsoleKeyInfo keyInfo;

            while (true)
            {
                keyInfo = Console.ReadKey(true);
                System.Threading.Thread.Sleep(10);

                switch (keyInfo.Key)
                {
                    case ConsoleKey.UpArrow:
                        //System.Threading.Thread.Sleep(200);
                        MoveUp(obj);
                        break;

                    case ConsoleKey.RightArrow:
                        MoveRight(obj);
                        break;

                    case ConsoleKey.DownArrow:
                        MoveDown(obj);
                        break;

                    case ConsoleKey.LeftArrow:
                        MoveLeft(obj);
                        break;

                    case ConsoleKey.Escape:
                        Console.WriteLine("Pause");
                        break;
                }
            }

            //while ((keyInfo = Console.ReadKey(true)).Key != ConsoleKey.Escape)
            //{
            //    switch (keyInfo.Key)
            //    {
            //        case ConsoleKey.UpArrow:
            //            //System.Threading.Thread.Sleep(200);
            //            MoveUp(obj);
            //            break;

            //        case ConsoleKey.RightArrow:
            //            MoveRight(obj);

            //            break;

            //        case ConsoleKey.DownArrow:
            //            MoveDown(obj);

            //            break;

            //        case ConsoleKey.LeftArrow:
            //            MoveLeft(obj);
            //            break;
            //    }
            //}
        }

        private static void MoveLeft(Protagonist obj)
        {
            obj.Move(-1, 0);
            DrawProtagonist(obj);
            ClearBackground(obj);
        }

        private static void MoveDown(Protagonist obj)
        {
            obj.Move(0, 1);
            DrawProtagonist(obj);
            ClearBackground(obj);
        }

        private static void MoveRight(Protagonist obj)
        {
            obj.Move(1, 0);
            DrawProtagonist(obj);
            ClearBackground(obj);
        }

        private static void MoveUp(Protagonist obj)
        {
            obj.Move(0, -1);
            DrawProtagonist(obj);
            ClearBackground(obj);
        }

        private static void DrawProtagonist(Protagonist obj)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(obj.X, obj.Y);
            if (obj.Y == 0)
            {
                Console.Write("..");
            }
            else
            {
                Console.Write("  ");
            }

        }

        private static void ClearBackground(Protagonist obj)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Clear();
            DrawProtagonist(obj);

        }

        private static void InitializeGame()
        {
            Console.CursorVisible = false;
            Console.BufferHeight = GameConst.Height;
            Console.BufferWidth = GameConst.Width;
            Console.SetWindowSize(GameConst.Width, GameConst.Height);
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(0, 0);
            Console.Write("  ");
        }
    }
}
