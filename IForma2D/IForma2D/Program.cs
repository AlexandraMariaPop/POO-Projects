using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IForma2D
{
    class Program
    {
        public static void Informations(IForma2D inf)
        {
        Console.WriteLine($"PERIMETRUL {inf.Denumire}ului este {inf.LungimeaFrontierei()}");
            Console.WriteLine($"ARIA {inf.Denumire}ului este {inf.Aria()}");
        }

        static void Main(string[] args)
        {
            Cerc c1 = new Cerc(5);
            Informations(c1);
            Patrat p1 = new Patrat(5);
            Informations(p1);
            Console.ReadKey();
        }
    }
}
