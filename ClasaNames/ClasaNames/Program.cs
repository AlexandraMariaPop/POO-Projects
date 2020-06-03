using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasaNames
{
    class Program
    {
        static void Main(string[] args)
        {
            Names n = new Names(3);
            n[0] = "Nume";
            n[1] = "prenume 1";
            n[2] = "prenume 2";
           Console.WriteLine(n);
            //n[5] = "X";
            // Console.WriteLine(n["1"]);
            Console.WriteLine(n["2"]);
            Console.ReadKey();
        }
    }
}
