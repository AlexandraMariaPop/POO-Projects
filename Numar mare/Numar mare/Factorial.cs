using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numar_mare
{
    class Factorial:Bignumber
    {
        public static long factorial(int n)
        {
            if (n == 1)
                return 1;
            else
                return n * factorial(n - 1);
        }
        public static Bignumber GetFactorial(int n)
        {

             long[] aux2 = { 1 };
             Bignumber oneresult = new Bignumber(aux2, aux2.Length);
             long[] aux1 = { n };
             Bignumber nresult = new Bignumber(aux1, aux1.Length);
             if (n == 1)
                 return oneresult;
             else
                 return nresult * GetFactorial(n - 1);
                
           /*
            long[] numberaux = new long[1];
            numberaux[0] = n;
            Bignumber number = new Bignumber(numberaux, numberaux.Length);
            for (long i = n-1; i >= 1; i--)
            {
                long[] aux = new long[1];
                aux[0] = i;
                number = number *( new Bignumber(i-1));
            }
            return number;*/
        }
    }
}
