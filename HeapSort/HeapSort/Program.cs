using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeapSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] v = {55, 31, 5, 79, 1, 21, 22, 19, 66, 35 };
            Heap sort = new Heap();
            sort.HeapSort(v);
            for (int i = 0; i < v.Length; i++)
            {
                Console.WriteLine(v[i]);
            }
            Console.WriteLine("Generic:");
            double[] k = { 23.5, 23.6, 29, 33,-1 };
            GenericHeapSort<double> hp = new GenericHeapSort<double>();
            hp.HeapSort(k);
            for (int i = 0; i <k.Length; i++)
            {
                Console.WriteLine(k[i]);
            }
            
            Console.ReadKey();
        }
    }
}
