using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numar_mare
{
    class Fibonacci : Bignumber
    {

      
        public static Bignumber GetFibonacci(int n)
        {
            long[] aux1 = { 0 };
            Bignumber zeroresult=new Bignumber(aux1,aux1.Length);
            long[] aux2 = { 1 };
            Bignumber oneresult = new Bignumber(aux2, aux2.Length);
            if (n == 0)
                return zeroresult;
            if (n == 1)
                return oneresult;
            else
                return GetFibonacci(n - 1) + GetFibonacci(n - 2);
        }
    }
}
