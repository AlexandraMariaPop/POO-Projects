using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Big_Ball_Game
{
    class Canvas
    {
        public static Random rnd=new Random();
        public static int Width { get; set; }
        public static int Height { get; set; }
        public Canvas()
        {
            Width = rnd.Next(500);
            Height= rnd.Next(500);
        }
        public Canvas(int width,int height)
        {
            Width = width;
            Height = height;
        }


    }
}
