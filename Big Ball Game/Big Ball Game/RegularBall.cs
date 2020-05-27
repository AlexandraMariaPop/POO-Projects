using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Big_Ball_Game
{
    class RegularBall
    {
        private int Radius;
        private PointF position;
        private Color color;
        private Direction direction;
        public RegularBall()
        {
            Random rnd = new Random();
            this.Radius = rnd.Next(50);
            this.position.X = rnd.Next(Canvas.Width);
            this.position.Y = rnd.Next(Canvas.Height);
            this.color = Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255));
            this.direction = new Direction("random");
        }


    }
}
