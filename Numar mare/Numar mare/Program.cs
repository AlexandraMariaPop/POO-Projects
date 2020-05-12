using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numar_mare
{
    class Program
    {
        static void Main(string[] args)
        {

            long[] a = { 1, 2, 3,4,5 };
            long[] b = { 7, 7, 7 };
            int l1 = a.Length;
            int l2 = b.Length;
            Bignumber a1 = new Bignumber(a,a.Length);
            Bignumber b1 = new Bignumber(b,b.Length);
            Console.WriteLine(b1+a1);
            Console.WriteLine(b1 * a1);
           Console.WriteLine(Fibonacci.GetFibonacci(10));
            Console.WriteLine(Factorial.GetFactorial(11));
            Console.ReadKey();

        }
    }
}
