using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace Big_Ball_Game
{
    class RepelentBall
    {
        private int Radius;
        private PointF position;
        private Color color;
        private Direction direction;
        public RepelentBall()
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
