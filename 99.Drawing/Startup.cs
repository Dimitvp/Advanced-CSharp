using System;
using System.Runtime.CompilerServices;
using _99.Drawing;

namespace SuperSnake
{

    internal class Program
    {

        static void Main(string[] args)
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

            while ((keyInfo = Console.ReadKey(true)).Key != ConsoleKey.Escape)
            {
                switch (keyInfo.Key)
                {
                    case ConsoleKey.UpArrow:
                        obj.Move(0, -1);
                        DrawProtagonist(obj);
                        ClearBackground(obj);

                        break;

                    case ConsoleKey.RightArrow:
                        obj.Move(1, 0);
                        DrawProtagonist(obj);
                        ClearBackground(obj);

                        break;

                    case ConsoleKey.DownArrow:
                        obj.Move(0, 1);
                        DrawProtagonist(obj);
                        ClearBackground(obj);

                        break;

                    case ConsoleKey.LeftArrow:
                        obj.Move(-1, 0);
                        DrawProtagonist(obj);
                        ClearBackground(obj);
                        break;
                }
            }
        }

        private static void DrawProtagonist(Protagonist obj)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(obj.X, obj.Y);
            if (obj.Y == 0)
            {
                Console.Write("O");
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
