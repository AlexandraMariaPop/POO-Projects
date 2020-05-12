using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complex
{
    class Program
    {
        static void Main(string[] args)
        {
            Complex a = new Complex(2, 3);
            Complex b = new Complex(5, 6);

            Complex suma = a+b;
            Console.WriteLine(suma);

            Complex diferenta = a-b;
            Console.WriteLine(diferenta);
            // a.TrigonometricForm();
            //a.PowTrigonometricForm(5);
           
            a.Pow(2);
            List < Complex > multime= new List<Complex>();

            multime.Add(new Complex(3, 4));
            multime.Add(new Complex(5, 8));
            multime.Add(new Complex(1, 11));
            ComplexD c = new ComplexD(a, multime);
            Console.WriteLine(c.Distance());
            Console.ReadKey();
        }
    }
}
