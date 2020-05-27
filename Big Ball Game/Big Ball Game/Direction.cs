using System;
namespace Big_Ball_Game
{
    internal class Direction
    {
        public int dx { get; set; }
        public int dy { get; set; }
        public int speed { get; set; }
        private static Random rnd=new Random();
        public Direction()
        {
            this.dx = 0;
            this.dy = 0;
            this.speed = 0;
        }
        public Direction(int dx,int dy,int speed)
        {
            this.dx = dx;
            this.dy = dy;
            this.speed = speed;
        }
        public Direction(string random)
        {
            this.dx = rnd.Next(50);
            this.dy = rnd.Next(50);
        }
    }
}