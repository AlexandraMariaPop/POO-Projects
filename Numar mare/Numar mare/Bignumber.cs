using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numar_mare
{
    class Bignumber
    {
        long[] a;
        int length;
        public Bignumber(long[]a,int length)
        {
            this.a = a;
            this.length = length;
        }
        public Bignumber()
        {
            this.a[0] = 0;
            this.length = 1;
        }
       
        private long GetElement(int i)
        {
            return a[i];
        }
       
        public static Bignumber operator + (Bignumber b1,Bignumber b2)
        {
            if (b1.length >= b2.length)
                return AuxSum(b1, b2);
            else
                return AuxSum(b2, b1);
        }
        public static Bignumber AuxSum(Bignumber a, Bignumber b)
        {
            int l1 = a.length;
            int l2 = b.length;
            long[] sum = new long[l1 + 1];
            int i = l1 - 1;
            int j = l2 - 1;
            int k = l1;
            long carry = 0;
            long s = 0;
            while (j >= 0)
            {
                s = a.GetElement(i) + b.GetElement(j) + carry;
                sum[k] = s % 10;
                carry = s / 10;
                i--;
                j--;
                k--;

            }
            while (i >= 0)
            {
                s = a.GetElement(i) + carry;
                sum[k] = s % 10;
                carry = s / 10;
                i--;
                k--;

            }
            if (carry == 1)
                sum[0] = 1;
            
            Bignumber finalsum = new Bignumber(sum, sum.Length);
            return finalsum;
        }
        public static Bignumber operator *(Bignumber a, Bignumber b)
        {
            int len1 = a.length;
            int len2 = b.length;
           
           long[] result = new long[len1 + len2];

           
            int i_n1 = 0;
            int i_n2 = 0;
            int i;

             
            for (i = len1 - 1; i >= 0; i--)
            {
                long carry = 0;
                long n1 = a.GetElement(i) ;

                
                i_n2 = 0;

                              
                for (int j = len2 - 1; j >= 0; j--)
                {
                    
                   long n2 = b.GetElement(j) ;

                    
                    long sum = n1 * n2 + result[i_n1 + i_n2] + carry;

                     
                    carry = sum / 10;

                    // Store result  
                    result[i_n1 + i_n2] = sum % 10;

                    i_n2++;
                }

                  
                if (carry > 0)
                    result[i_n1 + i_n2] += carry;

                
                i_n1++;
            }
            long[] auxresult = new long[result.Length];
            int k = 0;
            for (int m   = result.Length-1; m >=0; m--)
            {
                auxresult[k] = result[m];
                k++;
            }

            Bignumber finalresult = new Bignumber(auxresult, auxresult.Length);
            return finalresult;
            
        }
    
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            /* int k = 0;
             do
             {
                 k++;
             } while (a[k] == 0);
             for (int i = k+1; i < a.Length; i++)
             {
                 sb.Append(a[k]);
             }*/
            bool ok = true;

             if (a[0] == 0)
                 ok = false;
             if(ok==true)
             {
                 for (int i = 0; i < a.Length; i++)
                 {
                     sb.Append(a[i]);

                 }
             }
             else
             {
                 for (int i = 1; i < a.Length; i++)
                 {
                     sb.Append(a[i]);

                 }
             }
            return sb.ToString(); 
        }
    }
}
