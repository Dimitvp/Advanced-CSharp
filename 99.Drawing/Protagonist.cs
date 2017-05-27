using System;
using _99.Drawing;

namespace SuperSnake
{
    public class Protagonist
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Protagonist()
        {
            this.X = 0;
            this.Y = 0;
        }


        public void Move(int x, int y)
        {
            if (y != 0)
            {
                Console.CursorVisible = false;
            }

            if (this.X + x * 2 < GameConst.Width-2 && this.X + x * 2>=1)
            {
                this.X += x * 2;
            }

            if (this.Y + y < GameConst.Height-1 && this.Y + y >= 1)
            {
                this.Y += y;
            }
        }
    }
}
