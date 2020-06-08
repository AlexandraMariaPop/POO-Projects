using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complex
{
    class Complex
    {
        public int Re;
        public int Im;

        public Complex()
        {
            this.Re = 0;
            this.Im = 0;
        }
        public Complex(int Re)
        {
            this.Re = Re;
            this.Im = 0;
        }
        public Complex(int Re, int Im)
        {
            this.Re = Re;
            this.Im = Im;
        }
        public static Complex operator +(Complex a,Complex b)
        {
            Complex result = new Complex();

            result.Re = a.Re + b.Re;
            result.Im = a.Im + b.Im;

            return result;
        }
        public static Complex operator -(Complex a, Complex b)
        {
            Complex result = new Complex();
            result.Re = a.Re - b.Re;
            result.Im = a.Im - b.Im;

            return result;
        }
        public static Complex operator *(Complex a,Complex b)
        {
            Complex result = new Complex();
            result.Re = a.Re * b.Re - a.Im * b.Im;
            result.Im = a.Re * b.Im + a.Im * b.Re;

            return result;
        }

        public void TrigonometricForm()
        {
            double r = System.Math.Sqrt(Re * Re + Im * Im);
            double teta = System.Math.Atan(Im / Re);
            System.Console.WriteLine($" Forma trigonometrica : {r}(cos({teta})+isin({teta}))");
        }
        public virtual void Pow(int power)
        {
            Complex result = new Complex();

            double r = System.Math.Sqrt(Re * Re + Im * Im);
            double teta = System.Math.Atan(Im / Re);
            result.Re = (int)(Math.Pow(r, power) * (System.Math.Cos(teta * power)));
            result.Im = (int)(Math.Pow(r, power) * (System.Math.Sin(teta * power)));

            Console.WriteLine(result);
            

        }
        public override string ToString()
        {
            if (Im < 0)
                return string.Format($"{Re} - {System.Math.Abs(Im)}i");
            else
                return string.Format($"{Re} + {Im}i");
        }
    }
}
