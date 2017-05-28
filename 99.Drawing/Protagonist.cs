using System;
using _99.Drawing;

namespace SuperSnake
{
    public class Protagonist
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        public Protagonist()
        {
            this.X = 0;
            this.Y = 0;
            this.IsAlive = true;
        }

        public bool IsAlive { get; private set; }


        public void Move(int x, int y)
        {

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
