using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complex
{
    class ComplexD: Complex
    {
        private List <Complex> multime=new List<Complex>();
        Complex c;
        public ComplexD(Complex c,List<Complex> multime)
        {
            this.c = c;
            this.multime = multime;
        }


        public override void Pow(int pow)
        {
            double r = System.Math.Sqrt(Re * Re + Im * Im);
            double teta = System.Math.Atan(Im / Re);
            System.Console.WriteLine($" Forma trigonometrica : {r * pow}(cos({teta * pow})+isin({teta * pow}))");
        }
        public double Distance()
        {
            double min = Math.Sqrt(Math.Pow((multime[0].Re - Re), 2) + Math.Pow((multime[0].Im - Im), 2)); ;
            foreach (Complex item in multime)
            {
                double aux = Math.Sqrt(Math.Pow((item.Re - Re), 2) + Math.Pow((item.Im - Im), 2));
                if (aux < min)
                    min = aux;
            }
            return min;
        }
    }
}
