using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasaStiva
{
    class Program
    {
        static void Main(string[] args)
        {
           Stiva<int> s1 = new Stiva<int>(20);
           s1.Push(5);
           s1.Push(4);
           s1.Push(43);
           s1.Push(14);
           //s1.Clear();
           Console.WriteLine( s1.Pop());
           Console.WriteLine(s1);
            Console.WriteLine();

            Stiva<string> s2 = new Stiva<string>(20);
            s2.Push("ab");
            s2.Push("c");
            s2.Push("DE");
            s2.Push("A");
            //s1.Clear();
            Console.WriteLine(s2.Pop());
            Console.WriteLine(s2);
            Console.ReadKey();
        }
    }
}
