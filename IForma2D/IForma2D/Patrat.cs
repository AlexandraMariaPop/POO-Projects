using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IForma2D
{
    class Patrat : IForma2D
    {
        public string Denumire => "PATRAT";
        private double latura;
        public Patrat(double latura)
        {
            this.latura = latura;
        }
        public double Aria()
        {
            return Math.Pow(latura, 2);
        }

        public double LungimeaFrontierei()
        {
            return 4 * latura;
        }

    }
}
