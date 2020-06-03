using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IForma2D
{
    class Cerc : IForma2D
    {
        private double raza;
        public string Denumire => "CERC";
        public Cerc(double raza)
        {
            this.raza = raza;
        }
        public double Aria()
        {
            return Math.PI * Math.Pow(raza, 2);
        }

        public double LungimeaFrontierei()
        {
            return 2 * Math.PI * raza;
        }
    }
}
